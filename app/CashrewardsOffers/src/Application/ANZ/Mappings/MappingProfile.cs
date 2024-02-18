using CashrewardsOffers.Application.ANZ.Queries.GetAnzItems.v1;
using CashrewardsOffers.Domain.Entities;
using CashrewardsOffers.Domain.Events;
using CashrewardsOffers.Domain.ValueObjects;
using Mapster;
using System;

namespace CashrewardsOffers.Application.ANZ.Mappings
{
    public class MappingProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AnzItem, AnzItemInfo>()
                .Map(dest => dest.Id, src => src.ItemId)
                .Map(dest => dest.Merchant.StartDateTime, src => AnzTime.MinValue)
                .Map(dest => dest.Merchant.EndDateTime, src => AnzTime.MaxValue)
                .Map(dest => dest.Offer, src => src.Offer.Id > 0 ? src.Offer : null)
                .Map(dest => dest.Offer.FeaturedRanking, src => src.Offer.FeaturedRanking)
                .Map(dest => dest.Offer.EndDateTime, src => new DateTimeOffset(src.Offer.EndDateTime, TimeSpan.Zero).ToUniversalTime())
                .Map(dest => dest.IsDeleted, src => src.IsUnavailable);

            config.NewConfig<MerchantChangedCategoryItem, AnzMerchantCategory>()
                .Map(dest => dest.Id, src => src.CategoryId);

            config.NewConfig<OfferMerchantChangedCategoryItem, AnzMerchantCategory>()
                .Map(dest => dest.Id, src => src.CategoryId);
        }
    }
}
