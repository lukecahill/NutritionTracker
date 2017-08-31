using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace food_tracker {
    public class NutritionItem {

        [Key]
        public int NutritionItemId { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string dayId { get; set; }
        public double calories { get; set; }
        public double carbohydrates { get; set; }
        public double sugars { get; set; }
        public double fats { get; set; }
        public double saturatedFats { get; set; }
        public double protein { get; set; }
        public double salt { get; set; }
        public double fibre { get; set; }
        public DateTime dateTime { get; set; }

        [ForeignKey("dayId")]
        public WholeDay wholeDay { get; set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public NutritionItem() { }
        
        public NutritionItem(string name, string day, List<double> values, double amount) {
            this.name = name;
            this.dayId = day;
            this.calories = values[0];
            this.fats = values[1];
            this.saturatedFats = values[2];
            this.carbohydrates = values[3];
            this.sugars = values[4];
            this.fibre = values[5];
            this.protein = values[6];
            this.salt = values[7];
            this.amount = amount;
            this.dateTime = DateTime.UtcNow;
        }

        public override string ToString() {
            return this.name;
        }
    }
}
