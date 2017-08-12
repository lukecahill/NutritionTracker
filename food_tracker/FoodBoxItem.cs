using System.Windows.Controls;
using System.Windows.Forms;

namespace food_tracker {
	public class FoodBoxItem : ListBoxItem {

		public int calories { get; set; }
		public int fats { get; set; }
		public int saturatedFat { get; set; }
		public int carbohydrates { get; set; }
		public int sugar { get; set; }
		public int protein { get; set; }
		public int salt { get; set; }
		public string name { get; set; }

		public FoodBoxItem() : base() { }

		public FoodBoxItem(int cals, int fats, int satFat, int carbs, int sugars, int protein, int salt, string name) {
			this.name = name;
			this.calories = cals;
			this.fats = fats;
			this.salt = salt;
			this.saturatedFat = satFat;
			this.carbohydrates = carbs;
			this.sugar = sugars;
			this.protein = protein;
		}

		public override string ToString() {
			return name;
		}
	}
}
