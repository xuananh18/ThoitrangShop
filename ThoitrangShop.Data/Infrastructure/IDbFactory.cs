using System;

namespace ThoitrangShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ThoitrangShopDbContext Init();
    }
}