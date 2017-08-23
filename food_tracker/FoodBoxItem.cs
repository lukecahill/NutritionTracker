using System.Windows.Controls;
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

		public FoodBoxItem() : base() { }
        
        public FoodBoxItem(double cals, double fats, double satFat, double carbs, double sugars, double protein, double salt, double fibre, string name, int itemId, double amount) {
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
        }

        public override string ToString() {
            if (this.amount <= 0) {
                return this.name;
            } else {
                return $"{this.name} - {this.amount}";
            }
        }
	}
}
