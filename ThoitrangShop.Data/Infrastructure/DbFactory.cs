namespace ThoitrangShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ThoitrangShopDbContext dbContext;

        public ThoitrangShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ThoitrangShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}