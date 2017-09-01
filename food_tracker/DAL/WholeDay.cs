using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace food_tracker.DAL {
    public class WholeDay {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string WholeDayId { get; set; }
        public DateTime dateTime { get; set; }
        public double dailyTotal { get; set; }
        public virtual IEnumerable<NutritionItem> foodsDuringDay { get; set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public WholeDay() { }

        public WholeDay(string dayId) {
            this.WholeDayId = dayId;
            this.dateTime = DateTime.UtcNow;
            this.dailyTotal = 0;
        }
    }
}
