using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data
{
    public class ThoitrangShopDbContext:DbContext
    {
        public ThoitrangShopDbContext():base("ThoitrangShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCat> PostCats { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Item> Items { set; get; }
        public DbSet<Cat> Cats { set; get; }
        public DbSet<ItemTag> ItemTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            
        }
    }
}
