namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_amount_to_item : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NutritionItems", "amount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NutritionItems", "amount");
        }
    }
}
