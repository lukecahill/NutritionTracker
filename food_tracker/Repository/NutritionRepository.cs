using System.Collections.Generic;
using System.Linq;
using food_tracker.Interfaces;
using food_tracker.DAL;
using System.Diagnostics;
using System;
using System.Data.Entity;

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

        public WholeDay GetDay(string id) {
            return _db.Days.FirstOrDefault(x => x.WholeDayId == id);
        }

        public void AddDay(WholeDay day) {
            _db.Days.Add(day);
            _db.SaveChanges();
        }

        public WholeDay UpdateDay(string id) {
            var entity = _db.Days.FirstOrDefault(x => x.WholeDayId == id);

            if (entity == null) return null;

            // TODO: add column onto database with the total calories for the day. Mark this as modified and then save. 
            var total = _db.Nutrition.Where(x => x.dayId == id).Sum(x => x.calories);
            Debug.WriteLine($"The calculated daily total is: {total}");
            //entry.dailyTotal = total;
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
            return entity;
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
