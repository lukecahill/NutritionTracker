using System;
using System.Collections.Generic;

namespace food_tracker {
    public class WholeDay {

        public DateTime dateTime { get; set; }

        public virtual List<NutritionItem> foodsDuringDay { get; set; }

        public WholeDay(DateTime date) {
            this.dateTime = date;
        }
    }
}
