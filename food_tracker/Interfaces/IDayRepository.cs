using food_tracker.DAL;

namespace food_tracker.Interfaces {
    public interface IDayRepository {
        WholeDay GetDay(string id);
        void AddDay(WholeDay day);
        WholeDay UpdateDay(string id);
    }
}