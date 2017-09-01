using System.Collections.Generic;
using food_tracker.DAL;

namespace food_tracker.Interfaces {
    public interface IRepository {

        IEnumerable<NutritionItem> GetAll(string id);
        IEnumerable<NutritionItem> GetAllUnique();
        NutritionItem GetItem(int id);
        void Add(NutritionItem item);
        bool Remove(int id);
    }
}