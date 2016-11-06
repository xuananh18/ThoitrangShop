using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IPost_CatRepository : IRepository<Post_Cat>
    {
    }
    public class Post_CatRepository : RepositoryBase<Post_Cat>, IPost_CatRepository
    {
        public Post_CatRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
