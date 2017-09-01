using food_tracker.DAL;
using food_tracker.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace food_tracker.Repository {
    public class NutritionRepository : IRepository {

        private readonly TrackerContext _db = null;

        public NutritionRepository() {
            try {
                _db = new TrackerContext();
            } catch(Exception e) {
                Debug.WriteLine($"Could not connect to database, error: {e.Message}.\n\nException type: {e.GetType()}");
            }
        }

        public IEnumerable<NutritionItem> GetItems(string id) {
            return _db.Nutrition.Where(x => x.dayId == id).ToList();
        }

        public IEnumerable<NutritionItem> GetItemsUnique() {
            // cost involved with below query, with buffering all the data before returning anything.
            return _db.Nutrition.GroupBy(x => x.name).Select(group => group.FirstOrDefault()).ToArray().Distinct().OrderBy(o => o.dateTime).ThenBy(b => b.name);
        }

        public NutritionItem GetItem(int id) {
            return _db.Nutrition.FirstOrDefault(x => x.NutritionItemId == id);
        }

        public void AddItem(NutritionItem item) {
            _db.Nutrition.Add(item);
            _db.SaveChanges();
        }

        public bool RemoveItem(int id) {
            var entity = _db.Nutrition.FirstOrDefault(x => x.NutritionItemId == id);
            if(entity != null) {
                _db.Nutrition.Remove(entity);
                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
