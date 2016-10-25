using System.Collections.Generic;
using System.Linq;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IItemRepository
    { }
    public class ItemRepository: RepositoryBase<Item>,IItemRepository
    {
        public ItemRepository(IDbFactory dbFactory):base(dbFactory)
        { }
    }
}
