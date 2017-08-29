using System.Data.Entity;

namespace food_tracker {
    public class TrackerContext : DbContext {

        public TrackerContext() : base("name=NutritionTrackerContext") {
            Configuration.LazyLoadingEnabled = false;

            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<WholeDay> Days { get; set; }
        public DbSet<NutritionItem> Nutrition { get; set; }
    }
}
