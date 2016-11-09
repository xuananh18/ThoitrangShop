using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ThoitrangShop.Model.Models;

namespace ThoitrangShop.Data
{
    public class ThoitrangShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public ThoitrangShopDbContext() : base("ThoitrangShopConnection")
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
        public DbSet<Recoment> Recoments { set; get; }
        public DbSet<Item_Cat> Item_Cats { set; get; }
        public DbSet<Item_Sub> Item_Subs { set; get; }
        public DbSet<Post_Cat> Post_Cats { set; get; }
        public DbSet<Post_Sub> Post_Subs { set; get; }
        public DbSet<PostSub> PostSubs { set; get; }
        public DbSet<SubCat> SubCats { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static ThoitrangShopDbContext Create()
        {
            return new ThoitrangShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}