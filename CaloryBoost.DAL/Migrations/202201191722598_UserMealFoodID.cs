namespace CaloryBoost.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserMealFoodID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserMealFoods");
            AddColumn("dbo.UserMealFoods", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserMealFoods", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserMealFoods");
            DropColumn("dbo.UserMealFoods", "ID");
            AddPrimaryKey("dbo.UserMealFoods", new[] { "UserID", "MealID", "FoodID" });
        }
    }
}
