﻿using System.Windows.Controls;

namespace food_tracker {
    public class FoodComboItem : ComboBoxItem {

        public double calories { get; set; }
        public double fats { get; set; }
        public double saturatedFat { get; set; }
        public double carbohydrates { get; set; }
        public double sugar { get; set; }
        public double protein { get; set; }
        public double salt { get; set; }
        public double fibre { get; set; }
        public string name { get; set; }
        public int nutritionId { get; set; }

        public FoodComboItem() : base() { }

        public FoodComboItem(string name, int itemId, double cals, double fats, double satFat, double carbs, double sugars, double protein, double salt, double fibre) {
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
        }

        public override string ToString() {
            return this.name;
        }
    }
}