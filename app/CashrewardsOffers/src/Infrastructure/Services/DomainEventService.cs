using CashrewardsOffers.Application.Common.Interfaces;
using CashrewardsOffers.Domain.Common;
using CashrewardsOffers.Infrastructure.AWS;
using CashrewardsOffers.Infrastructure.Extensions;
using MassTransit.Mediator;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CashrewardsOffers.Infrastructure.Services
{
    public interface IDomainEventService
    {
        Task PublishEventOutbox();
    }

    public class DomainEventService : IDomainEventService
    {
        private readonly IEventOutboxPersistenceContext eventOutboxPersistenceContext;
        private readonly IMediator mediator;
        private readonly IAWSEventServiceFactory eventServiceFactory;

        public DomainEventService(
            IEventOutboxPersistenceContext eventOutboxPersistenceContext,
            IMediator mediator,
            IAWSEventServiceFactory eventServiceFactory)
        {
            this.eventOutboxPersistenceContext = eventOutboxPersistenceContext;
            this.mediator = mediator;
            this.eventServiceFactory = eventServiceFactory;
        }

        private async Task Publish(DomainEvent domainEvent)
        {
            Log.Information("Publishing domain event {EventType} - {EventId}", domainEvent.Metadata.EventType, domainEvent.Metadata.EventID);

            domainEvent.Metadata.PublishedDateTimeUTC = DateTime.UtcNow;

            await Task.WhenAll(PublishToExternalEventDestinations(domainEvent),
                               PublishToInternalEventHandlers(domainEvent));
        }

        public async Task PublishToInternalEventHandlers(DomainEvent domainEvent)
        {
            await mediator.PublishEvent(domainEvent);
        }

        private async Task PublishToExternalEventDestinations(DomainEvent domainEvent)
        {
            var externalPublishers = eventServiceFactory.GetAWSPublishersForEvent(domainEvent);
            var hasEventPublishers = externalPublishers?.Any() ?? false;
            if (hasEventPublishers)
            {
                await Task.WhenAll(externalPublishers.Select(x => x.Publish(domainEvent)));
            }
        }

        public async Task PublishEventOutbox()
        {
            try
            {
                var domainEvent = await eventOutboxPersistenceContext.GetNext();
                while (domainEvent != null)
                {
                    await Publish(domainEvent);
                    await eventOutboxPersistenceContext.Delete(domainEvent.Metadata.EventID);

                    domainEvent = await eventOutboxPersistenceContext.GetNext();
                }
            }
            catch (Exception e)
            {
                Log.Error(e, $"Exception in publishing event outbox, Error: {e.Message}");
            }
        }
    }
}
