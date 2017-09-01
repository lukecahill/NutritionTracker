using food_tracker.DAL;

namespace food_tracker.Interfaces {
    public interface IDayRepository {
        WholeDay Get(string id);
        void Add(WholeDay day);
        WholeDay Update(string id);
    }
}