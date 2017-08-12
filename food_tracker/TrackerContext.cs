using System.Data.Entity;

namespace food_tracker {
    public class TrackerContext : DbContext {
        // need to think what DB sets are needed
        public DbSet<WholeDay> Days { get; set; }
    }
}
