namespace CaloryBoost.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Calory = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PhotoPath = c.String(),
                        FoodTypes = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PortionTypes = c.String(nullable: false),
                        FoodCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategoryID, cascadeDelete: true)
                .Index(t => t.FoodCategoryID);
            
            CreateTable(
                "dbo.UserMealFoods",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        MealID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.UserID, t.MealID, t.FoodID })
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.MealID)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        PhotoPath = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMealFoods", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserMealFoods", "MealID", "dbo.Meals");
            DropForeignKey("dbo.UserMealFoods", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "FoodCategoryID", "dbo.FoodCategories");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.UserMealFoods", new[] { "FoodID" });
            DropIndex("dbo.UserMealFoods", new[] { "MealID" });
            DropIndex("dbo.UserMealFoods", new[] { "UserID" });
            DropIndex("dbo.Foods", new[] { "FoodCategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.UserMealFoods");
            DropTable("dbo.Foods");
            DropTable("dbo.FoodCategories");
        }
    }
}
