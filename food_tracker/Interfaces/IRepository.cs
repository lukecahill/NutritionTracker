using System.Collections.Generic;
using food_tracker.DAL;

namespace food_tracker.Interfaces {
    public interface IRepository {

        WholeDay GetDay(string id);
        void AddDay(WholeDay day);
        WholeDay UpdateDay(string id);

        IEnumerable<NutritionItem> GetItems(string id);
        IEnumerable<NutritionItem> GetItemsUnique();
        NutritionItem GetItem(int id);
        void AddItem(NutritionItem item);
        bool RemoveItem(int id);
    }
}