using food_tracker.DAL;
using System;
using System.Collections.Generic;

namespace food_tracker.Interfaces {
    public interface IDayRepository {
        WholeDay Get(string id);
        void Add(WholeDay day);
        WholeDay Update(string id);
        IEnumerable<WholeDay> GetTimeSpan(int start, DateTime end);
    }
}