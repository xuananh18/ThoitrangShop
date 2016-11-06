using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IPost_SubRepository : IRepository<Post_Sub>
    {
    }

    public class Post_SubRepository : RepositoryBase<Post_Sub>, IPost_SubRepository
    {
        public Post_SubRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}