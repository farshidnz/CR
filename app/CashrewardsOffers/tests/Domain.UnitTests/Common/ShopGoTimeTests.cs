using CashrewardsOffers.Domain.Common;
using FluentAssertions;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;

namespace CashrewardsOffers.Domain.UnitTests.Common
{
    public class ShopGoTimeTests
    {
        [Test]
        public void IsDaylightSavingTime_ShouldReturnTrue_GivenSummerDateTime()
        {
            var summerDateTime = new DateTime(2022, 12, 10);

            ShopGoTime.IsDaylightSavingTime(summerDateTime).Should().Be(true);
        }

        [Test]
        public void IsDaylightSavingTime_ShouldReturnFalse_GivenWinterDateTime()
        {
            var winterDateTime = new DateTime(2022, 6, 10);

            ShopGoTime.IsDaylightSavingTime(winterDateTime).Should().Be(false);
        }

        [Test]
        public void ConvertToDateTimeOffset_ShouldReturnAest_GivenSummerDateTime()
        {
            var summerDateTime = new DateTime(2022, 12, 10);

            ShopGoTime.ConvertToDateTimeOffset(summerDateTime).Should().Be(new DateTimeOffset(2022, 12, 10, 0, 0, 0, TimeSpan.FromHours(11)));
        }

        [Test]
        public void ConvertToDateTimeOffset_ShouldReturnAedt_GivenWinterDateTime()
        {
            var winterDateTime = new DateTime(2022, 6, 10);

            ShopGoTime.ConvertToDateTimeOffset(winterDateTime).Should().Be(new DateTimeOffset(2022, 6, 10, 0, 0, 0, TimeSpan.FromHours(10)));
        }
        private class Thing
        {
            public DateTimeOffset Date { get; set; }
        }

        [Test]
        public void Compare()
        {
            var compareLogic = new CompareLogic(new ComparisonConfig { CompareDateTimeOffsetWithOffsets = true});
            var thing1 = new Thing { Date = new DateTimeOffset(2022, 1, 1, 0, 0, 0, TimeSpan.FromHours(10)) };
            var thing2 = new Thing { Date = new DateTimeOffset(2022, 1, 1, 0, 0, 0, TimeSpan.FromHours(11)) };

            var result = compareLogic.Compare(thing1, thing2);


            result.AreEqual.Should().Be(false);
        }
    }
}
