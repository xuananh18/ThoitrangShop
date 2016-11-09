using System.Collections.Generic;
using System.Linq;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface ICatRepository : IRepository<Cat>
    {
        IEnumerable<Cat> GetByAlias(string alias);
    }

    public class CatRepository : RepositoryBase<Cat>, ICatRepository
    {
        public CatRepository(IDbFactory dbFactory) : base(dbFactory)
        { }

        public IEnumerable<Cat> GetByAlias(string alias)
        {
            return this.DbContext.Cats.Where(x => x.Alias == alias);
        }
    }
}