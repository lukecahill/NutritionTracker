namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WholeDays",
                c => new
                    {
                        WholeDayId = c.Int(nullable: false, identity: true),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WholeDayId);
            
            CreateTable(
                "dbo.NutritionItems",
                c => new
                    {
                        NutritionItemId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        calories = c.Double(nullable: false),
                        carbohydrates = c.Double(nullable: false),
                        sugars = c.Double(nullable: false),
                        fats = c.Double(nullable: false),
                        saturatedFats = c.Double(nullable: false),
                        protein = c.Double(nullable: false),
                        salt = c.Double(nullable: false),
                        fibre = c.Double(nullable: false),
                        WholeDay_WholeDayId = c.Int(),
                    })
                .PrimaryKey(t => t.NutritionItemId)
                .ForeignKey("dbo.WholeDays", t => t.WholeDay_WholeDayId)
                .Index(t => t.WholeDay_WholeDayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NutritionItems", "WholeDay_WholeDayId", "dbo.WholeDays");
            DropIndex("dbo.NutritionItems", new[] { "WholeDay_WholeDayId" });
            DropTable("dbo.NutritionItems");
            DropTable("dbo.WholeDays");
        }
    }
}
