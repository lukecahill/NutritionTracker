using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace food_tracker {
    public class WholeDay {

        [Key]
        public int WholeDayId { get; set; }
        public DateTime dateTime { get; set; }
        public virtual List<NutritionItem> foodsDuringDay { get; set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public WholeDay() { }

        public WholeDay(DateTime date) {
            this.dateTime = date;
        }
    }
}
