using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace food_tracker {
    public partial class trackerForm : Form {

        TrackerContext context = new TrackerContext();
        TextBox[] textBoxes, textBoxesWithoutName;
        Label[] dailyTotalLabels;
        bool development = true;
        Helper helper;

        public trackerForm() {
            InitializeComponent();

            textBoxes = new TextBox[] { nameTextBox, caloriesTextBox, fatTextBox, saturatesTextBox, carbsTextBox, sugarsTextBox, fibreTextBox, proteinTextBox, saltTextBox };
            textBoxesWithoutName = new TextBox[] { caloriesTextBox, fatTextBox, saturatesTextBox, carbsTextBox, sugarsTextBox, fibreTextBox, proteinTextBox, saltTextBox };
            dailyTotalLabels = new Label[] { totalCalLbl, totalFatLbl, totalCarbsLbl, totalFibreLbl, totalProteinLbl, totalSatFatLbl, totalSugarsLbl, totalSaltLbl};

            helper = new Helper();
            helper.calculateTotals(currentDayItems);

            if (development) pastItemsCombo.Visible = true;
            Shown += new EventHandler(loadDataEvent);
        }

        private void loadDataEvent(object sender, EventArgs e) {
            loadData();
        }

        private void loadData() {
            var day = Md5Hashing.CreateMD5(dateTimePicker.Text.Replace(" ", ""));
            var data = context.Nutrition.Where(x => x.dayId == day).ToList();
            foreach(var item in data) {
                currentDayItems.Items.Add(new FoodBoxItem(item.calories, item.fats, item.saturatedFats, item.carbohydrates, item.sugars, item.protein, item.salt, item.fibre, item.name, item.NutritionItemId));
            }
            
            // cost involved with below query, with buffering all the data before returning anything.
            var distinct = context.Nutrition.GroupBy(x => x.name).Select(group => group.FirstOrDefault()).ToArray().Distinct();
            foreach (var item in distinct) {
                pastItemsCombo.Items.Add(new FoodComboItem(item.name, item.NutritionItemId, item.calories, item.fats, item.saturatedFats, item.carbohydrates, item.sugars, item.protein, item.salt, item.fibre));
            }

            showTotals();
        }

        private void addNewItemButton_Click(object sender, EventArgs e) {

            if(String.IsNullOrWhiteSpace(nameTextBox.Text)) {
                MessageBox.Show("You must enter a value for the name field.", "", MessageBoxButtons.OK);
                return;
            }

            if(areFieldsEmpty()) {
                MessageBox.Show("You must enter a value for all available fields.", "", MessageBoxButtons.OK);
                return;
            }

            var day = Md5Hashing.CreateMD5(dateTimePicker.Text.Replace(" ", ""));

            var dayExists = context.Days.FirstOrDefault(x => x.WholeDayId == day);
            if(dayExists == null) {
                context.Days.Add(new WholeDay(day));
            }
            dayExists = null;
            
            var nutrition = new NutritionItem(
                nameTextBox.Text,
                day,
                helper.parseTextBoxForDouble(caloriesTextBox),
                helper.parseTextBoxForDouble(carbsTextBox),
                helper.parseTextBoxForDouble(sugarsTextBox),
                helper.parseTextBoxForDouble(fatTextBox),
                helper.parseTextBoxForDouble(saturatesTextBox),
                helper.parseTextBoxForDouble(proteinTextBox),
                helper.parseTextBoxForDouble(saltTextBox),
                helper.parseTextBoxForDouble(fibreTextBox)
            );
            
            context.Nutrition.Add(nutrition);
            context.SaveChanges();

            // Append the amount to the name for database storage.
            var name = "";
            if (String.IsNullOrEmpty(amountTextbox.Text)) {
                name = nameTextBox.Text;
            } else {
                name = $"{nameTextBox.Text} - {amountTextbox.Text}";
            }

            currentDayItems.Items.Add(new FoodBoxItem(nutrition.calories, nutrition.fats, nutrition.saturatedFats, 
                nutrition.carbohydrates, nutrition.sugars, nutrition.protein, 
                nutrition.salt, nutrition.fibre, name, nutrition.NutritionItemId));
            
            showTotals();
            resetFields();
        }

        private void showTotals() {            
            var totals = helper.calculateTotals(currentDayItems);
            
            totalCalLbl.Text = totals[0].ToString();
            totalFatLbl.Text = totals[1].ToString();
            totalCarbsLbl.Text = totals[2].ToString();
            totalFibreLbl.Text = totals[3].ToString();
            totalProteinLbl.Text = totals[4].ToString();
            totalSatFatLbl.Text = totals[5].ToString();
            totalSugarsLbl.Text = totals[6].ToString();
            totalSaltLbl.Text = totals[7].ToString();
        }
        
        private bool areFieldsEmpty() {
            bool empty = false;
            foreach(var item in textBoxesWithoutName) {
                if(String.IsNullOrWhiteSpace(item.Text)) {
                    return empty = true;
                }
            }

            return empty;
        }

        private void currentDayItems_DoubleClick(object sender, EventArgs e) {
            if(currentDayItems.SelectedIndex > -1) {
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

                nutritionItemId.Text = item.nutritionId.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            // when the user changes the chosen date, everything should update
            resetFields();
            currentDayItems.Items.Clear();
            resetLabels();
            loadData();
        }
        
        private void removeItem_Click(object sender, EventArgs e) {
            var selectedItem = (FoodBoxItem)currentDayItems.SelectedItem;
            var itemId = selectedItem.nutritionId;
            var entity = context.Nutrition.FirstOrDefault(x => x.NutritionItemId == itemId);

            if(entity != null) {
                context.Nutrition.Remove(entity);
                context.SaveChanges();
            } else {
                MessageBox.Show("Could not delete that item.", "Error deleting item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            currentDayItems.Items.Remove(currentDayItems.SelectedItem);
            resetFields();
            showTotals();
        }

        private void currentDayItems_MouseUp(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {

                int index = currentDayItems.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches) {
                    currentDayItems.SelectedIndex = index;
                    menuItemContext.Show(Cursor.Position);
                    menuItemContext.Visible = true;
                }
            }
        }

        private bool addNewNutritionItem() {
            // this will be saving a new item to the database.
            // allows the user to choose from commonly consumed items.
            // required new classes - do not have to be explicity linked 
            //      e.g. a dropdown of these items which then populates the textboxes allowing the user to change before adding. 

            return false;
        }

        #region Reset Methods
        private void resetFields() {
            foreach (var item in textBoxes) {
                item.Clear();
            }
        }

        private void resetLabels() {
            foreach (var item in dailyTotalLabels) {
                item.Text = "-";
            }
        }
        #endregion

        #region Validation
        private void validateDoubleInput(KeyPressEventArgs e) {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9.]")) {
                e.Handled = true;
            }
        }

        private void caloriesTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void fatTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void saturatesTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void carbsTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void sugarsTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void fibreTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void proteinTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        private void saltTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            validateDoubleInput(e);
        }

        #endregion

        private void pastItemsCombo_SelectedIndexChanged(object sender, EventArgs e) {
            var item = (FoodComboItem)pastItemsCombo.SelectedItem;
            if (pastItemsCombo.SelectedIndex > -1) {
                nameTextBox.Text = item.name;
                caloriesTextBox.Text = item.calories.ToString();
                fatTextBox.Text = item.fats.ToString();
                saturatesTextBox.Text = item.saturatedFat.ToString();
                carbsTextBox.Text = item.carbohydrates.ToString();
                sugarsTextBox.Text = item.sugar.ToString();
                fibreTextBox.Text = item.fibre.ToString();
                proteinTextBox.Text = item.protein.ToString();
                saltTextBox.Text = item.salt.ToString();
                nutritionItemId.Text = item.nutritionId.ToString();
            }
        }
    }
}
