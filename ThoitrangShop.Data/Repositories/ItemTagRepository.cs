using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IItemTagRepository : IRepository<ItemTag>
    {
    }

    public class ItemTagRepository : RepositoryBase<ItemTag>, IItemTagRepository
    {
        public ItemTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}