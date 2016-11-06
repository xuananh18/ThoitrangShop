using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IItem_CatRepository : IRepository<Item_Cat>
    {
    }

    public class Item_CatRepository : RepositoryBase<Item_Cat>, IItem_CatRepository
    {
        public Item_CatRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}