using food_tracker.DAL;
using food_tracker.Interfaces;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace food_tracker.Repository {
    public class DayRepository : IDayRepository {

        private readonly TrackerContext _db = null;

        public DayRepository() {
            try {
                _db = new TrackerContext();
            } catch (Exception e) {
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

            var total = _db.Nutrition.Where(x => x.dayId == id).Sum(x => x.calories);
            Debug.WriteLine($"The calculated daily total is: {total}");
            entity.dailyTotal = total;
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
            return entity;
        }
    }
}