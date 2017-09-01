namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_daily_total : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WholeDays", "dailyTotal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WholeDays", "dailyTotal");
        }
    }
}
