using System.Data.Entity;

namespace food_tracker {
    public class TrackerContext : DbContext {
        public DbSet<WholeDay> Days { get; set; }
        public DbSet<NutritionItem> Nutrition { get; set; }
    }
}
