using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace food_tracker {
    public class Helper {

        public double[] calculateTotals(ListBox boxItem) {

            // calories, fats, sats, carbs, sugars, proteins, salts, fibre
            double[] values = { 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (FoodBoxItem item in boxItem.Items) {
                values[0] += item.calories;
                values[1] += item.fats;
                values[2] += item.saturatedFat;
                values[3] += item.carbohydrates;
                values[4] += item.sugar;
                values[5] += item.protein;
                values[6] += item.salt;
                values[7] += item.fibre;
            }

            return values;
        }

        public double parseTextBoxForDouble(TextBox text) {
            var parsed = 0.0D;
            if (double.TryParse(text.Text, out parsed)) {
                // suceeded to parse
                Debug.WriteLine($"Parsed number: {parsed}");
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
