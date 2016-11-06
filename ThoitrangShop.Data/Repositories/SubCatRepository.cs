using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface ISubCatRepository : IRepository<SubCat>
    {
    }
    public class SubCatRepository : RepositoryBase<SubCat>, ISubCatRepository
    {
        public SubCatRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
