﻿using food_tracker.DAL;
using food_tracker.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace food_tracker.Repository {
    public class NutritionRepository : INutritionRepository {

        private readonly TrackerContext _db = null;

        public NutritionRepository() {
            try {
                _db = new TrackerContext();
            } catch(Exception e) {
                Debug.WriteLine($"Could not connect to database, error: {e.Message}.\n\nException type: {e.GetType()}");
            }
        }

        public IEnumerable<NutritionItem> GetAll(string id) => _db.Nutrition.Where(x => x.dayId == id).ToList();

        public IEnumerable<NutritionItem> GetAllUnique() {
            // cost involved with below query, with buffering all the data before returning anything.
            return _db.Nutrition.GroupBy(x => x.name).Select(group => group.FirstOrDefault()).ToArray().Distinct().OrderBy(o => o.dateTime).ThenBy(b => b.name);
        }

        public NutritionItem GetItem(int id) => _db.Nutrition.FirstOrDefault(x => x.NutritionItemId == id);

        public void Add(NutritionItem item) {
            _db.Nutrition.Add(item);
            _db.SaveChanges();
        }

        public bool Remove(int id) {
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
