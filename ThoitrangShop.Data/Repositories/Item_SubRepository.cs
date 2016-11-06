using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IItem_SubRepository : IRepository<Item_Sub>
    {
    }
    public class Item_SubRepository : RepositoryBase<Item_Sub>, IItem_SubRepository
    {
        public Item_SubRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
