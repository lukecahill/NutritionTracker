using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using food_tracker.DAL;
using food_tracker.Interfaces;

namespace food_tracker {
    public class Helper {
        private readonly IRepository _repo = null;

        public Helper(IRepository repo) {
            _repo = repo;
        }

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

        public double? parseDouble(string text) {
            var parsed = 0.0D;
            if (double.TryParse(text, out parsed)) {
                // suceeded to parse
                Debug.WriteLine($"Parsed number: {parsed}");
            } else if (String.IsNullOrWhiteSpace(text)) {
                Debug.WriteLine("Parsed number was empty; returning 0.");
            } else {
                Debug.WriteLine($"Could not parse {text} - ensure that this is a valid number.");
                MessageBox.Show("Error when attempting to parse integer values");
                return null;
            }

            return parsed;
        }

        public bool isFieldEmpty(TextBox[] textboxes) {
            bool empty = false;
            foreach (var item in textboxes) {
                if (String.IsNullOrWhiteSpace(item.Text)) {
                    return empty = true;
                }
            }

            return empty;
        }

        public string addOrUpdateCurrentDay(string date) {
            date = Md5Hashing.CreateMD5(date);
            var day = _repo.GetDay(date);

            if(day == null) {
                _repo.AddDay(new WholeDay(date));
            }

            return date;
        }
    }
}
