using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IPostCatRepository : IRepository<PostCat>
    {
    }
    public class PostCatRepository : RepositoryBase<PostCat>, IPostCatRepository
    {
        public PostCatRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
