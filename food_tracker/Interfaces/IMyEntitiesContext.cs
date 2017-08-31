using System.Data.Entity;
using food_tracker.DAL;

namespace food_tracker.Interfaces {
    public interface IMyEntitiesContext {
        IDbSet<NutritionItem> Nutrition { get; set; }
        IDbSet<WholeDay> Days { get; set; }

        int SaveChanges();
    }
}