namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_datetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NutritionItems", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NutritionItems", "dateTime");
        }
    }
}
