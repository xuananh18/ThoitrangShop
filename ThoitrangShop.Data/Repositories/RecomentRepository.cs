using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IRecomentRepository : IRepository<Recoment>
    {
    }
    public class RecomentRepository : RepositoryBase<Recoment>, IRecomentRepository
    {
        public RecomentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
