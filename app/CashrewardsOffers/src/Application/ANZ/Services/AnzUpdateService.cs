﻿using CashrewardsOffers.Application.Common.Interfaces;
using CashrewardsOffers.Domain.Entities;
using CashrewardsOffers.Domain.Enums;
using CashrewardsOffers.Domain.Events;
using System.Threading.Tasks;

namespace CashrewardsOffers.Application.ANZ.Services
{
    public interface IAnzUpdateService
    {
        Task UpdateMerchant(MerchantEventBase domainEvent);
        Task UpdateOffer(OfferEventBase domainEvent);
        Task DeleteMerchant(MerchantDeleted domainEvent);
        Task DeleteOffer(OfferDeleted domainEvent);
    }

    public class AnzUpdateService : IAnzUpdateService
    {
        private readonly IAnzItemPersistenceContext _anzItemPersistenceContext;
        private readonly IAnzItemFactory _anzItemFactory;

        public AnzUpdateService(
            IAnzItemPersistenceContext anzItemPersistenceContext,
            IAnzItemFactory anzItemFactory)
        {
            _anzItemPersistenceContext = anzItemPersistenceContext;
            _anzItemFactory = anzItemFactory;
        }

        public async Task UpdateMerchant(MerchantEventBase domainEvent)
        {
            if (domainEvent.Client != Client.Cashrewards)
            {
                return;
            }

            var anzItem = _anzItemFactory.Create(domainEvent.MerchantId);
            anzItem = await _anzItemPersistenceContext.Get(anzItem.ItemId);
            if (anzItem == null)
            {
                anzItem = _anzItemFactory.Create(domainEvent.MerchantId);
                anzItem.ApplyChanges(domainEvent);
                await _anzItemPersistenceContext.Insert(anzItem);
            }
            else
            {
                anzItem.ApplyChanges(domainEvent);
                await _anzItemPersistenceContext.Update(anzItem);
            }

            if (domainEvent is MerchantChanged _)
            {
                await Resequence();
            }
        }

        public async Task UpdateOffer(OfferEventBase domainEvent)
        {
            if (domainEvent.Client != Client.Cashrewards)
            {
                return;
            }

            var anzItem = _anzItemFactory.Create(domainEvent.Merchant.Id, domainEvent.OfferId);
            anzItem = await _anzItemPersistenceContext.Get(anzItem.ItemId);
            if (anzItem == null)
            {
                anzItem = _anzItemFactory.Create(domainEvent.Merchant.Id, domainEvent.OfferId);
                anzItem.ApplyChanges(domainEvent);
                await _anzItemPersistenceContext.Insert(anzItem);
            }
            else
            {
                anzItem.ApplyChanges(domainEvent);
                await _anzItemPersistenceContext.Update(anzItem);
            }

            if (domainEvent is OfferChanged _)
            {
                await Resequence();
            }
        }

        public async Task DeleteMerchant(MerchantDeleted domainEvent)
        {
            if (domainEvent.Client != Client.Cashrewards)
            {
                return;
            }

            var anzItem = _anzItemFactory.Create(domainEvent.MerchantId);
            anzItem = await _anzItemPersistenceContext.Get(anzItem.ItemId);
            if (anzItem != null)
            {
                anzItem.SetAsDeleted();
                await _anzItemPersistenceContext.Update(anzItem);
                await Resequence();
            }
        }

        public async Task DeleteOffer(OfferDeleted domainEvent)
        {
            if (domainEvent.Client != Client.Cashrewards)
            {
                return;
            }

            var anzItem = _anzItemFactory.Create(domainEvent.Merchant.Id, domainEvent.OfferId);
            anzItem = await _anzItemPersistenceContext.Get(anzItem.ItemId);
            if (anzItem != null)
            {
                anzItem.SetAsDeleted();
                await _anzItemPersistenceContext.Update(anzItem);
                await Resequence();
            }
        }

        private async Task Resequence()
        {
            var items = await _anzItemPersistenceContext.GetAllActiveCarouselItems();
            var itemsToUpdate = new Rankings()
                .Add(new InStoreMerchantRanking())
                .Add(new PopularMerchantRanking())
                .Add(new FeaturedOffersRanking())
                .AnzItemsToUpdate(items);

            foreach(var item in itemsToUpdate)
            {
                item.SetLastUpdated();
                await _anzItemPersistenceContext.Update(item);
            }
        }

        private record struct Indexed<T>(T Item, int Index);
    }
}
