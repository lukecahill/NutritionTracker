using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace food_tracker {
    public partial class Form1 : Form {

        TrackerContext context = new TrackerContext();
        public Form1() {
            InitializeComponent();
            this.loadData();
        }

        private void loadData() {
            var data = context.Nutrition.ToList();
            foreach(var item in data) {
                currentDayItems.Items.Add(new FoodBoxItem(item.calories, item.fats, item.saturatedFats, item.carbohydrates, item.sugars, item.protein, item.salt, item.fibre, item.name));
            }

            this.showTotals();
        }

        private void addNewItemButton_Click(object sender, EventArgs e) {

            if(String.IsNullOrWhiteSpace(this.nameTextBox.Text)) {
                MessageBox.Show("You must enter a value for the name field.", "", MessageBoxButtons.OK);
                return;
            }

            if(this.areFieldsEmpty()) {
                MessageBox.Show("You must enter a value for all available fields.", "", MessageBoxButtons.OK);
                return;
            }

            var day = "";
            if(currentDayItems.Items.Count <= 0) {
                day = dateTimePicker.Text.Replace(" ", "");
            } else {
                day = dateTimePicker.Text.Replace(" ", "");
            }

            // need to persist to database for the past days and current day for reloading - below is an exple of how the totals will be calculated.
            var nutrition = new NutritionItem(
                nameTextBox.Text,
                day,
                parseTextBoxForDouble(caloriesTextBox), 
                parseTextBoxForDouble(carbsTextBox),
                parseTextBoxForDouble(sugarsTextBox),
                parseTextBoxForDouble(fatTextBox),
                parseTextBoxForDouble(saturatesTextBox),
                parseTextBoxForDouble(proteinTextBox),
                parseTextBoxForDouble(saltTextBox),
                parseTextBoxForDouble(fibreTextBox)
            );

            currentDayItems.Items.Add(new FoodBoxItem(nutrition.calories, nutrition.fats, nutrition.saturatedFats, 
                nutrition.carbohydrates, nutrition.sugars, nutrition.protein, 
                nutrition.salt, nutrition.fibre, nameTextBox.Text));

            context.Nutrition.Add(nutrition);
            context.SaveChanges();
            
            this.showTotals();
            this.resetFields();
        }

        private void showTotals() {
            double totalCalories = 0, totalFats = 0, totalSats = 0, totalCarbs = 0, totalSugars = 0, totalProteins = 0, totalSalts = 0, totalFibres = 0;

            foreach (FoodBoxItem item in currentDayItems.Items) {
                totalCalories += item.calories;
                totalFats += item.fats;
                totalSats += item.saturatedFat;
                totalCarbs += item.carbohydrates;
                totalSugars += item.sugar;
                totalProteins += item.protein;
                totalSalts += item.salt;
                totalFibres += item.fibre;
            }

            totalCalLbl.Text = totalCalories.ToString();
            totalFatLbl.Text = totalFats.ToString();
            totalCarbsLbl.Text = totalCarbs.ToString();
            totalFibreLbl.Text = totalFibres.ToString();
            totalProteinLbl.Text = totalProteins.ToString();
            totalSatFatLbl.Text = totalSats.ToString();
            totalSugarsLbl.Text = totalSugars.ToString();
            totalSaltLbl.Text = totalSalts.ToString();
        }

        private double parseTextBoxForDouble(TextBox text) {
            var parsed = double.Parse(text.Text);
            return parsed;
        }

        private void resetFields() {
            nameTextBox.Clear();
            caloriesTextBox.Clear();
            fatTextBox.Clear();
            saturatesTextBox.Clear();
            carbsTextBox.Clear();
            sugarsTextBox.Clear();
            fibreTextBox.Clear();
            proteinTextBox.Clear();
            saltTextBox.Clear();
        }

        private bool areFieldsEmpty() {
            return String.IsNullOrWhiteSpace(caloriesTextBox.Text) || String.IsNullOrWhiteSpace(fatTextBox.Text) || String.IsNullOrWhiteSpace(saturatesTextBox.Text)
                || String.IsNullOrWhiteSpace(carbsTextBox.Text) || String.IsNullOrWhiteSpace(sugarsTextBox.Text) || String.IsNullOrWhiteSpace(fibreTextBox.Text)
                || String.IsNullOrWhiteSpace(proteinTextBox.Text) || String.IsNullOrWhiteSpace(saltTextBox.Text);
        }

        private void currentDayItems_DoubleClick(object sender, EventArgs e) {
            if(currentDayItems.SelectedIndex > -1) {
                MessageBox.Show("");
            }
            try {
                var item = (FoodBoxItem)currentDayItems.SelectedItem;
                nameTextBox.Text = item.name;
                caloriesTextBox.Text = item.calories.ToString();
                fatTextBox.Text = item.fats.ToString();
                saturatesTextBox.Text = item.saturatedFat.ToString();
                carbsTextBox.Text = item.carbohydrates.ToString();
                sugarsTextBox.Text = item.sugar.ToString();
                fibreTextBox.Text = item.fibre.ToString();
                proteinTextBox.Text = item.protein.ToString();
                saltTextBox.Text = item.salt.ToString();
            } catch(NullReferenceException ex) {
                Debug.WriteLine("User clicked an empty list box item.");
                Debug.WriteLine(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            // when the user changes the chosen date, everything should update
            this.resetFields();
            currentDayItems.Items.Clear();
        }

        private void caloriesTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // validate that a number was entered 
            //if(!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar)) {
            //    e.Handled = true;
            //    return;
            //}
        }
    }
}
