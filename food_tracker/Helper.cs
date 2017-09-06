using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace food_tracker {
    public class Helper {

        public Helper() {}

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

        public List<double> parseTextBoxValues(TextBox[] textBoxesWithoutName) {
            var textboxvalues = new List<double>();
            foreach (var textbox in textBoxesWithoutName) {
                var value = parseDouble(textbox.Text);
                if (value != null) {
                    textboxvalues.Add(value.Value);
                } else {
                    // should return what textbox contained an invalid number. 
                    textbox.ForeColor = System.Drawing.Color.Red;
                    return null;
                }
            }

            return textboxvalues;
        }

        public void saveCurrentFile(string filename, string textToWrite) {
            using (var stream = new StreamWriter(filename)) {
                stream.NewLine = "\n";
                stream.WriteLine(textToWrite);
                stream.Flush();
            }
        }

        public string showSaveFileDialog() {
            DialogResult diagResult;
            var filename = "";
            using (var saveFile = new SaveFileDialog()) {
                saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|(*.*)";
                diagResult = saveFile.ShowDialog();

                if (diagResult == DialogResult.OK) {
                    filename = saveFile.FileName;
                }
            }

            return filename;
        }
    }
}
