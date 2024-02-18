using CashrewardsOffers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CashrewardsOffers.Application.Common.Interfaces
{
    public interface IAnzItemPersistenceContext
    {
        Task<List<AnzItem>> GetAllActiveCarouselItems();
        Task<AnzItem> Get(string itemId);
        Task Insert(AnzItem anzItem);
        Task Update(AnzItem anzItem);
        Task<List<AnzItem>> GetPage(int? pageSize = null, int pageNumber = 1, long? updatedAfter = null);
        Task<long> GetCount(long? updatedAfter = null);
    }
}
