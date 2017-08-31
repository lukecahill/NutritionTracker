using System.Data.Entity;

namespace food_tracker {
    public interface IMyEntitiesContext {
        IDbSet<NutritionItem> Nutrition { get; set; }
        IDbSet<WholeDay> Days { get; set; }

        int SaveChanges();
    }
}