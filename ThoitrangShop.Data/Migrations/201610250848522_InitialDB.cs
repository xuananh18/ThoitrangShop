namespace ThoitrangShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        ID_Cat = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_Cat);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID_Footer = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Footer);
            
            CreateTable(
                "dbo.Item_Cats",
                c => new
                    {
                        ID_Item = c.Int(nullable: false),
                        ID_Cat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Item, t.ID_Cat })
                .ForeignKey("dbo.Cats", t => t.ID_Cat, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.ID_Item, cascadeDelete: true)
                .Index(t => t.ID_Item)
                .Index(t => t.ID_Cat);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID_Item = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Image = c.String(maxLength: 256),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_Item);
            
            CreateTable(
                "dbo.Item_Subs",
                c => new
                    {
                        ID_Item = c.Int(nullable: false),
                        ID_SubCat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Item, t.ID_SubCat })
                .ForeignKey("dbo.Items", t => t.ID_Item, cascadeDelete: true)
                .ForeignKey("dbo.SubCats", t => t.ID_SubCat, cascadeDelete: true)
                .Index(t => t.ID_Item)
                .Index(t => t.ID_SubCat);
            
            CreateTable(
                "dbo.SubCats",
                c => new
                    {
                        ID_SubCat = c.Int(nullable: false, identity: true),
                        ID_Cat = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Alias = c.String(nullable: false),
                        Description = c.String(),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(),
                        HomeFlag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_SubCat)
                .ForeignKey("dbo.Cats", t => t.ID_Cat, cascadeDelete: true)
                .Index(t => t.ID_Cat);
            
            CreateTable(
                "dbo.ItemTags",
                c => new
                    {
                        ID_Item = c.Int(nullable: false),
                        ID_Tag = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID_Item, t.ID_Tag })
                .ForeignKey("dbo.Items", t => t.ID_Item, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.ID_Tag, cascadeDelete: true)
                .Index(t => t.ID_Item)
                .Index(t => t.ID_Tag);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID_Tag = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Tag);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID_Goup = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Goup);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID_Menu = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        URL = c.String(nullable: false, maxLength: 256),
                        DisplayOrder = c.Int(),
                        ID_Group = c.Int(nullable: false),
                        Target = c.String(maxLength: 10),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Menu)
                .ForeignKey("dbo.MenuGroups", t => t.ID_Group, cascadeDelete: true)
                .Index(t => t.ID_Group);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID_Customer = c.Int(nullable: false),
                        ID_Item = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Customer, t.ID_Item })
                .ForeignKey("dbo.Items", t => t.ID_Item, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.ID_Customer, cascadeDelete: true)
                .Index(t => t.ID_Customer)
                .Index(t => t.ID_Item);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID_Customer = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Address = c.String(nullable: false, maxLength: 256),
                        Email = c.String(nullable: false, maxLength: 256),
                        Mobile = c.String(nullable: false, maxLength: 50),
                        Message = c.String(nullable: false, maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        PaymentMethod = c.String(maxLength: 256),
                        PaymentStatus = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Customer);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID_Page = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Content = c.String(),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Page);
            
            CreateTable(
                "dbo.Post_Cats",
                c => new
                    {
                        ID_Post = c.Int(nullable: false),
                        ID_PostCat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Post, t.ID_PostCat })
                .ForeignKey("dbo.Posts", t => t.ID_Post, cascadeDelete: true)
                .ForeignKey("dbo.PostCats", t => t.ID_PostCat, cascadeDelete: true)
                .Index(t => t.ID_Post)
                .Index(t => t.ID_PostCat);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID_Post = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Image = c.String(),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_Post);
            
            CreateTable(
                "dbo.PostCats",
                c => new
                    {
                        ID_PostCat = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Alias = c.String(nullable: false),
                        Description = c.String(),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(),
                        HomeFlag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_PostCat);
            
            CreateTable(
                "dbo.Post_Subs",
                c => new
                    {
                        ID_Post = c.Int(nullable: false),
                        ID_PostSub = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Post, t.ID_PostSub })
                .ForeignKey("dbo.Posts", t => t.ID_Post, cascadeDelete: true)
                .ForeignKey("dbo.PostSubs", t => t.ID_PostSub, cascadeDelete: true)
                .Index(t => t.ID_Post)
                .Index(t => t.ID_PostSub);
            
            CreateTable(
                "dbo.PostSubs",
                c => new
                    {
                        ID_PostSub = c.Int(nullable: false, identity: true),
                        ID_PostCat = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Alias = c.String(nullable: false),
                        Description = c.String(),
                        ParentID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(),
                        HomeFlag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdateedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID_PostSub)
                .ForeignKey("dbo.PostCats", t => t.ID_PostCat, cascadeDelete: true)
                .Index(t => t.ID_PostCat);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        ID_Post = c.Int(nullable: false),
                        ID_Tag = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID_Post, t.ID_Tag })
                .ForeignKey("dbo.Posts", t => t.ID_Post, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.ID_Tag, cascadeDelete: true)
                .Index(t => t.ID_Post)
                .Index(t => t.ID_Tag);
            
            CreateTable(
                "dbo.Recoments",
                c => new
                    {
                        ID_Rec = c.Int(nullable: false),
                        ID_Item = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_Rec, t.ID_Item })
                .ForeignKey("dbo.Items", t => t.ID_Item, cascadeDelete: true)
                .Index(t => t.ID_Item);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID_Slide = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        URL = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Slide);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID_Support = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Yahoo = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Support);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID_System = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID_System);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID_Visit = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Visit);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recoments", "ID_Item", "dbo.Items");
            DropForeignKey("dbo.PostTags", "ID_Tag", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "ID_Post", "dbo.Posts");
            DropForeignKey("dbo.Post_Subs", "ID_PostSub", "dbo.PostSubs");
            DropForeignKey("dbo.PostSubs", "ID_PostCat", "dbo.PostCats");
            DropForeignKey("dbo.Post_Subs", "ID_Post", "dbo.Posts");
            DropForeignKey("dbo.Post_Cats", "ID_PostCat", "dbo.PostCats");
            DropForeignKey("dbo.Post_Cats", "ID_Post", "dbo.Posts");
            DropForeignKey("dbo.OrderDetails", "ID_Customer", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "ID_Item", "dbo.Items");
            DropForeignKey("dbo.Menus", "ID_Group", "dbo.MenuGroups");
            DropForeignKey("dbo.ItemTags", "ID_Tag", "dbo.Tags");
            DropForeignKey("dbo.ItemTags", "ID_Item", "dbo.Items");
            DropForeignKey("dbo.Item_Subs", "ID_SubCat", "dbo.SubCats");
            DropForeignKey("dbo.SubCats", "ID_Cat", "dbo.Cats");
            DropForeignKey("dbo.Item_Subs", "ID_Item", "dbo.Items");
            DropForeignKey("dbo.Item_Cats", "ID_Item", "dbo.Items");
            DropForeignKey("dbo.Item_Cats", "ID_Cat", "dbo.Cats");
            DropIndex("dbo.Recoments", new[] { "ID_Item" });
            DropIndex("dbo.PostTags", new[] { "ID_Tag" });
            DropIndex("dbo.PostTags", new[] { "ID_Post" });
            DropIndex("dbo.PostSubs", new[] { "ID_PostCat" });
            DropIndex("dbo.Post_Subs", new[] { "ID_PostSub" });
            DropIndex("dbo.Post_Subs", new[] { "ID_Post" });
            DropIndex("dbo.Post_Cats", new[] { "ID_PostCat" });
            DropIndex("dbo.Post_Cats", new[] { "ID_Post" });
            DropIndex("dbo.OrderDetails", new[] { "ID_Item" });
            DropIndex("dbo.OrderDetails", new[] { "ID_Customer" });
            DropIndex("dbo.Menus", new[] { "ID_Group" });
            DropIndex("dbo.ItemTags", new[] { "ID_Tag" });
            DropIndex("dbo.ItemTags", new[] { "ID_Item" });
            DropIndex("dbo.SubCats", new[] { "ID_Cat" });
            DropIndex("dbo.Item_Subs", new[] { "ID_SubCat" });
            DropIndex("dbo.Item_Subs", new[] { "ID_Item" });
            DropIndex("dbo.Item_Cats", new[] { "ID_Cat" });
            DropIndex("dbo.Item_Cats", new[] { "ID_Item" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.Recoments");
            DropTable("dbo.PostTags");
            DropTable("dbo.PostSubs");
            DropTable("dbo.Post_Subs");
            DropTable("dbo.PostCats");
            DropTable("dbo.Posts");
            DropTable("dbo.Post_Cats");
            DropTable("dbo.Pages");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Tags");
            DropTable("dbo.ItemTags");
            DropTable("dbo.SubCats");
            DropTable("dbo.Item_Subs");
            DropTable("dbo.Items");
            DropTable("dbo.Item_Cats");
            DropTable("dbo.Footers");
            DropTable("dbo.Cats");
        }
    }
}
