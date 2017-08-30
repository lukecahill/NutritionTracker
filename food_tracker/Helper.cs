using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace food_tracker {
    public class Helper {

        public Dictionary<string, double> calculateTotals(ListBox boxItem) {

            var returnDictionary = new Dictionary<string, double>() {
                { "calories", 0.0D },
                { "fats", 0.0D },
                { "saturatedFats", 0.0D },
                { "sugars", 0.0D },
                { "protein", 0.0D },
                { "salt", 0.0D },
                { "fibre", 0.0D },
                { "carbohydrates", 0.0D },
            };

            if (boxItem.Items.Count > 0) {
                foreach (FoodBoxItem item in boxItem.Items) {
                    returnDictionary["calories"] += item.calories;
                    returnDictionary["fats"] += item.fats;
                    returnDictionary["saturatedFats"] += item.saturatedFat;
                    returnDictionary["sugars"] += item.sugar;
                    returnDictionary["protein"] += item.protein;
                    returnDictionary["salt"] += item.salt;
                    returnDictionary["fibre"] += item.fibre;
                    returnDictionary["carbohydrates"] += item.carbohydrates;
                }

                return returnDictionary;
            }

            return null;
        }

        public double parseTextBoxForDouble(TextBox text) {
            var parsed = 0.0D;
            if (double.TryParse(text.Text, out parsed)) {
                // suceeded to parse
                Debug.WriteLine($"Parsed number: {parsed}");
            } else if (String.IsNullOrWhiteSpace(text.Text)) {
                Debug.WriteLine("Parsed number was empty; returning 0.");
            } else {
                Debug.WriteLine($"Could not parse {text.Text} - ensure that this is a valid number.");
                MessageBox.Show("Error when attempting to parse integer values");
            }

            return parsed;
        }

        public bool areFieldsEmpty(TextBox[] textboxes) {
            bool empty = false;
            foreach (var item in textboxes) {
                if (String.IsNullOrWhiteSpace(item.Text)) {
                    return empty = true;
                }
            }

            return empty;
        }
    }
}
