using System.Collections.Generic;
using System.Data.SqlClient;
using ThoitrangShop.Data.Infrastructure;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetRevenueStatistic(string fromDate, string toDate);
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Order> GetRevenueStatistic(string fromDate, string toDate)
        {
            var parameters = new SqlParameter[]{
                new SqlParameter("@fromDate",fromDate),
                new SqlParameter("@toDate",toDate)
            };
            return DbContext.Database.SqlQuery<Order>("GetRevenueStatistic @fromDate,@toDate", parameters);
        }
    }
}