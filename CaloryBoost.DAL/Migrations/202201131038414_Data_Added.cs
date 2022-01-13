namespace CaloryBoost.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data_Added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "Calory", c => c.Double(nullable: false));
            AlterColumn("dbo.Foods", "Portion", c => c.Double(nullable: false));
            AlterColumn("dbo.UserMealFoods", "Portion", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserMealFoods", "Portion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Foods", "Portion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Foods", "Calory", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
