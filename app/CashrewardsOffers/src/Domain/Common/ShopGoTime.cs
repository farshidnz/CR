using System;

namespace CashrewardsOffers.Domain.Common
{
    public class ShopGoTime
    {
        public static DateTimeOffset ConvertToDateTimeOffset(DateTime shopGoTime)
        {
            if (shopGoTime == DateTime.MinValue) return DateTimeOffset.MinValue;
            if (shopGoTime == DateTime.MaxValue) return DateTimeOffset.MaxValue;

            return IsDaylightSavingTime(shopGoTime)
                ? new DateTimeOffset(shopGoTime, TimeSpan.FromHours(11))
                : new DateTimeOffset(shopGoTime, TimeSpan.FromHours(10));
        }

        public static bool IsDaylightSavingTime(DateTime dateTime) =>
            TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time").IsDaylightSavingTime(dateTime);
    }
}
