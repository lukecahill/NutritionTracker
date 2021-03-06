﻿using food_tracker.DAL;
using food_tracker.Interfaces;
using food_tracker.ListItems;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace food_tracker {
    public partial class trackerForm : Form {

        private readonly TextBox[] textBoxes, textBoxesWithoutName;
        private readonly Label[] dailyTotalLabels;
        private readonly Helper helper;
        private readonly INutritionRepository _nutritionRepo = null;
        private readonly IDayRepository _dayRepository = null;
        private string filename = "";

        public trackerForm(INutritionRepository nutrition, IDayRepository day) {
            InitializeComponent();

            textBoxes = new TextBox[] { nameTextBox, caloriesTextBox, fatTextBox, saturatesTextBox, carbsTextBox, sugarsTextBox, fibreTextBox, proteinTextBox, saltTextBox, amountTextbox };
            textBoxesWithoutName = new TextBox[] { caloriesTextBox, fatTextBox, saturatesTextBox, carbsTextBox, sugarsTextBox, fibreTextBox, proteinTextBox, saltTextBox };
            dailyTotalLabels = new Label[] { totalCalLbl, totalFatLbl, totalCarbsLbl, totalFibreLbl, totalProteinLbl, totalSatFatLbl, totalSugarsLbl, totalSaltLbl};

            _nutritionRepo = nutrition;
            _dayRepository = day;
            helper = new Helper();

            setHelpProviders();
            helper.calculateTotals(currentDayItems);
            
            Shown += new EventHandler(loadDataEvent);
        }

        private void setHelpProviders() {
            helpProvider1.SetShowHelp(caloriesTextBox, true);
            helpProvider1.SetHelpString(caloriesTextBox, "Enter the amount of calories in grams.");

            helpProvider1.SetShowHelp(carbsTextBox, true);
            helpProvider1.SetHelpString(carbsTextBox, "Enter the amount of carbohydrates in grams.");

            helpProvider1.SetShowHelp(saturatesTextBox, true);
            helpProvider1.SetHelpString(saturatesTextBox, "Enter the amount of saturated fat in grams.");

            helpProvider1.SetShowHelp(fatTextBox, true);
            helpProvider1.SetHelpString(fatTextBox, "Enter the amount of fat in grams.");

            helpProvider1.SetShowHelp(proteinTextBox, true);
            helpProvider1.SetHelpString(proteinTextBox, "Enter the amount of protein in grams.");

            helpProvider1.SetShowHelp(sugarsTextBox, true);
            helpProvider1.SetHelpString(sugarsTextBox, "Enter the amount of sugars in grams.");

            helpProvider1.SetShowHelp(saltTextBox, true);
            helpProvider1.SetHelpString(saltTextBox, "Enter the amount of salt in grams.");

            helpProvider1.SetShowHelp(fibreTextBox, true);
            helpProvider1.SetHelpString(fibreTextBox, "Enter the amount of fibre in grams.");
        }

        private void loadDataEvent(object sender, EventArgs e) {
            loadData();
            showTotals();
        }

        private void loadData() {
            pastItemsCombo.Items.Clear();
            var day = Md5Hashing.CreateMD5(dateTimePicker.Text.Replace(" ", ""));
            var data = _nutritionRepo.GetAll(day);
            foreach(var item in data) {
                currentDayItems.Items.Add(new FoodBoxItem(item.calories, item.fats, item.saturatedFats, item.carbohydrates, 
                    item.sugars, item.protein, item.salt, item.fibre, item.name, item.NutritionItemId, item.amount, item.dateTime));
            }

            var distinct = _nutritionRepo.GetAllUnique();
            var collection = new AutoCompleteStringCollection();

            foreach (var item in distinct) {
                pastItemsCombo.Items.Add(new FoodComboItem(item.name, item.NutritionItemId, item.calories, item.fats, 
                    item.saturatedFats, item.carbohydrates, item.sugars, item.protein, item.salt, item.fibre, item.amount));
                collection.Add(item.name);
            }
            pastItemsCombo.AutoCompleteCustomSource = collection;
        }

        private void addNewItemButton_Click(object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace(nameTextBox.Text)) {
                nameTextBox.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("You must enter a value for the name field.", "", MessageBoxButtons.OK);
                return;
            }

            if (helper.isFieldEmpty(textBoxesWithoutName)) {
                MessageBox.Show("You must enter a value for all available fields.", "", MessageBoxButtons.OK);
                return;
            }

            var day = addOrUpdateCurrentDay(dateTimePicker.Text.Replace(" ", ""));

            var textboxvalues = helper.parseTextBoxValues(textBoxesWithoutName);
            if(textboxvalues == null) { return; }

            var amount = helper.parseDouble(amountTextbox.Text);
            if(amount == null) {
                amountTextbox.ForeColor = System.Drawing.Color.Red;
                return;
            }
            
            var nutrition = new NutritionItem(nameTextBox.Text, day, textboxvalues, amount.Value);

            _nutritionRepo.Add(nutrition);
            var result = _dayRepository.Update(day);
            if (result == null || typeof(WholeDay) != result.GetType()) Debug.WriteLine($"Could not update that item. Returned result was; {result}");
            
            currentDayItems.Items.Add(new FoodBoxItem(nutrition.calories, nutrition.fats, nutrition.saturatedFats, 
                nutrition.carbohydrates, nutrition.sugars, nutrition.protein, 
                nutrition.salt, nutrition.fibre, nutrition.name, nutrition.NutritionItemId, nutrition.amount, nutrition.dateTime));
            
            showTotals();
            resetFields();
        }
        
        private void showTotals() {            
            var totals = helper.calculateTotals(currentDayItems);

            if (totals != null) {
                totalCalLbl.Text = totals["calories"].ToString();
                totalFatLbl.Text = totals["fats"].ToString();
                totalCarbsLbl.Text = totals["carbohydrates"].ToString();
                totalFibreLbl.Text = totals["fibre"].ToString();
                totalProteinLbl.Text = totals["protein"].ToString();
                totalSatFatLbl.Text = totals["saturatedFats"].ToString();
                totalSugarsLbl.Text = totals["sugars"].ToString();
                totalSaltLbl.Text = totals["salt"].ToString();
            }
        }
        
        private void currentDayItems_DoubleClick(object sender, EventArgs e) {
            if(currentDayItems.SelectedIndex > -1) {
                var item = (FoodBoxItem)currentDayItems.SelectedItem;
                addToComboOrListBox(item);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            resetFields();
            currentDayItems.Items.Clear();
            resetLabels();
            loadData();
            showTotals();
        }
        
        private void removeItem_Click(object sender, EventArgs e) {
            var selectedItem = (FoodBoxItem)currentDayItems.SelectedItem;
            var itemId = selectedItem.nutritionId;
            var removed = _nutritionRepo.Remove(itemId);

            if(removed == false) {
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
            if (pastItemsCombo.SelectedIndex > -1) {
                var item = (FoodComboItem)pastItemsCombo.SelectedItem;
                addToComboOrListBox(item);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Created by Luke Cahill.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void fillWithExampleDataToolStripMenuItem_Click(object sender, EventArgs e) {
            nameTextBox.Text = "Example item";
            caloriesTextBox.Text = "150";
            fatTextBox.Text = "1.5";
            saturatesTextBox.Text = "0.5";
            carbsTextBox.Text = "9.6";
            sugarsTextBox.Text = "9.6";
            fibreTextBox.Text = "3.2";
            proteinTextBox.Text = "6.4";
            saltTextBox.Text = "0.1";
            amountTextbox.Text = "50";
        }

        public void addToComboOrListBox(IListItems item) {
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

            if (item.amount > 0) {
                amountTextbox.Text = item.amount.ToString();
            } else {
                amountTextbox.Clear();
            }
        }

        #region Saving to file

        private void printWeekTotalToolStripMenuItem_Click(object sender, EventArgs e) {
            Debug.WriteLine("Getting timespan");
            var result = _dayRepository.GetTimeSpan(-7, DateTime.UtcNow);
            var sb = new StringBuilder();

            foreach (var item in result) {
                Debug.WriteLine(item.dateTime.ToString("yyyy-MM-dd"));
                Debug.WriteLine(item.dailyTotal);
                sb.Append("The total calories for ");
                sb.Append(item.dateTime.ToString("yyyy-MM-dd"));
                sb.Append(" was ");
                sb.Append(item.dailyTotal);
                sb.Append(".");
                sb.AppendLine();
                sb.AppendLine();
            }
            filename = helper.showSaveFileDialog();

            helper.saveCurrentFile(filename, sb.ToString());
        }

        #endregion

        private string addOrUpdateCurrentDay(string date) {
            date = Md5Hashing.CreateMD5(date);
            var day = _dayRepository.Get(date);

            if (day == null) {
                _dayRepository.Add(new WholeDay(date));
            }

            return date;
        }
    }
}
