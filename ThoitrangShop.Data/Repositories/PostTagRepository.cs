using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }
    class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
