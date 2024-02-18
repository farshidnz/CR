using CashrewardsOffers.Application.MerchantSuggestions.Services;
using CashrewardsOffers.Application.Offers.Services;
using Hangfire;
using Hangfire.Common;
using Hangfire.Storage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unleash;

namespace CashrewardsOffers.API
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            try
            {
                var logLevel = (Environment.GetEnvironmentVariable("LOG_LEVEL")?.ToLower() ?? "warning") switch
                {
                    "verbose" => LogEventLevel.Verbose,
                    "debug" => LogEventLevel.Debug,
                    "information" => LogEventLevel.Information,
                    "warning" => LogEventLevel.Warning,
                    "error" => LogEventLevel.Error,
                    "fatal" => LogEventLevel.Fatal,
                    _ => LogEventLevel.Warning
                };

                Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.ControlledBy(new LoggingLevelSwitch(logLevel))
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .CreateLogger();

                Log.Information("Log Level is {LogLevel}", logLevel);
                Log.Information("Starting up");
                await RunHost(args);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application start-up failed");
                Console.WriteLine($"Application start-up failed: {ex}");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static async Task RunHost(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var hostTask = host.RunAsync();
            using (var scope = host.Services.CreateScope())
            {
                var syncRankedMerchantService = scope.ServiceProvider.GetService<ISyncRankedMerchantService>();
                var syncMerchantService = scope.ServiceProvider.GetService<ISyncMerchantsService>();
                var syncOfferService = scope.ServiceProvider.GetService<ISyncOffersService>();

                var jobs = new List<(string id, Job job, string cron)>
                {
                    new ("ranked-merchant-sync-job", Job.FromExpression(() => syncRankedMerchantService.TrySyncMerchantAsync()), Cron.Minutely()),
                    new ("merchant-sync-job", Job.FromExpression(() => syncMerchantService.TrySyncMerchantsAsync()), Cron.Minutely()),
                    new ("offer-sync-job", Job.FromExpression(() => syncOfferService.TrySyncOffersAsync()), Cron.Minutely())
                };

                var manager = new RecurringJobManager();
                jobs.ForEach(job => manager.AddOrUpdate(job.id, job.job, job.cron));

                var recurringJobs = JobStorage.Current.GetConnection().GetRecurringJobs();
                recurringJobs.ForEach(job => Log.Information("Found hangfire recurring job {Id} Cron:{Cron}", job.Id, job.Cron));

                // init Unleash
                var unleash = scope.ServiceProvider.GetService<IUnleash>();

                await hostTask;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseSerilog();
    }
}
