using System;
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

        [ForeignKey("dayId")]
        public WholeDay wholeDay { get; set; }

        [Obsolete("Only needed for serialization and materialization", true)]
        public NutritionItem() { }

        public NutritionItem(string name, string day, double calories, double carbohydrates, double sugars, double fats, double satFat, double protein, double salt, double fibre, double amount) {
            this.name = name;
            this.dayId = day;
            this.calories = calories;
            this.carbohydrates = carbohydrates;
            this.sugars = sugars;
            this.fats = fats;
            this.saturatedFats = satFat;
            this.protein = protein;
            this.salt = salt;
            this.fibre = fibre;
            this.amount = amount;
        }

        public override string ToString() {
            return this.name;
        }
    }
}
