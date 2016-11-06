using System.Collections.Generic;
using System.Linq;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetListItemByTag(string tagId, int page, int pageSize, out int totalRow);
    }
    public class ItemRepository: RepositoryBase<Item>,IItemRepository
    {
        public ItemRepository(IDbFactory dbFactory):base(dbFactory)
        { }
        public IEnumerable<Item> GetListItemByTag(string tagId, int page, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Items
                        join pt in DbContext.ItemTags
                        on p.ID_Item equals pt.ID_Item
                        where pt.ID_Tag == tagId
                        select p;
            totalRow = query.Count();

            return query.OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
        }

    }
}
