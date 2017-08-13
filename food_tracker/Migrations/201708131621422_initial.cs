namespace food_tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WholeDays",
                c => new
                    {
                        WholeDayId = c.String(nullable: false, maxLength: 128),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WholeDayId);
            
            CreateTable(
                "dbo.NutritionItems",
                c => new
                    {
                        NutritionItemId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        dayId = c.String(maxLength: 128),
                        calories = c.Double(nullable: false),
                        carbohydrates = c.Double(nullable: false),
                        sugars = c.Double(nullable: false),
                        fats = c.Double(nullable: false),
                        saturatedFats = c.Double(nullable: false),
                        protein = c.Double(nullable: false),
                        salt = c.Double(nullable: false),
                        fibre = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.NutritionItemId)
                .ForeignKey("dbo.WholeDays", t => t.dayId)
                .Index(t => t.dayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NutritionItems", "dayId", "dbo.WholeDays");
            DropIndex("dbo.NutritionItems", new[] { "dayId" });
            DropTable("dbo.NutritionItems");
            DropTable("dbo.WholeDays");
        }
    }
}
