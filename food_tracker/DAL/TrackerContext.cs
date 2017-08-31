using System.Data.Entity;

namespace food_tracker {
    public class TrackerContext : DbContext, IMyEntitiesContext {

        public TrackerContext() : base() {
            Configuration.LazyLoadingEnabled = false;

            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public IDbSet<WholeDay> Days { get; set; }
        public IDbSet<NutritionItem> Nutrition { get; set; }
        
        public override int SaveChanges() {
            return base.SaveChanges();
        }
    }
}
