using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IPostSubRepository : IRepository<PostSub>
    {
    }

    public class PostSubRepository : RepositoryBase<PostSub>, IPostSubRepository
    {
        public PostSubRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}