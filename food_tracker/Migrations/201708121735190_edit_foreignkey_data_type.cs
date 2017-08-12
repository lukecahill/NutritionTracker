namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_foreignkey_data_type : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NutritionItems", "dayId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NutritionItems", "dayId");
        }
    }
}
