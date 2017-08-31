using System;
using System.Windows.Controls;
using food_tracker.Interfaces;

namespace food_tracker {
	public class FoodBoxItem : ListBoxItem, IListItems {

		public double calories { get; set; }
        public double amount { get; set; }
        public double fats { get; set; }
		public double saturatedFat { get; set; }
		public double carbohydrates { get; set; }
		public double sugar { get; set; }
		public double protein { get; set; }
		public double salt { get; set; }
		public double fibre { get; set; }
		public string name { get; set; }
        public int nutritionId { get; set; }
        public DateTime dateTime { get; set; }

		public FoodBoxItem() : base() { }
        
        public FoodBoxItem(double cals, double fats, double satFat, double carbs, double sugars, double protein, double salt, double fibre, string name, int itemId, double amount, DateTime dateTime) {
            this.name = name;
            this.calories = cals;
            this.fats = fats;
            this.salt = salt;
            this.saturatedFat = satFat;
            this.carbohydrates = carbs;
            this.sugar = sugars;
            this.protein = protein;
            this.fibre = fibre;
            this.nutritionId = itemId;
            this.amount = amount;
            this.dateTime = dateTime;
        }

        public override string ToString() {
            if(this.dateTime == null) {
                return this.name;
            }

            if (this.amount <= 0) {
                return $"{this.name, -35}\t-\t{this.dateTime.ToString("HH:mm:ss"), -10}";
            } else {
                return $"{this.name, -35}\t-\t{this.amount, -6}\t-\t{this.dateTime.ToString("HH:mm:ss"), -10}";
            }
        }
    }
}
