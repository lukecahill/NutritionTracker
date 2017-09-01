using System.Data.Entity;

namespace food_tracker.DAL {
    public class TrackerContext : DbContext {

        public TrackerContext() : base() {
            Configuration.LazyLoadingEnabled = false;

            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public IDbSet<WholeDay> Days { get; set; }
        public IDbSet<NutritionItem> Nutrition { get; set; }
    }
}
