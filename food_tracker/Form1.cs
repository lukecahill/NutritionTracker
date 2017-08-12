using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace food_tracker {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
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

			// need to persist to database for the past days and current day for reloading - below is an exple of how the totals will be calculated.
			var calories = parseTextBoxForInt(caloriesTextBox);
			var fats = parseTextBoxForInt(fatTextBox);
			var sats = parseTextBoxForInt(saturatesTextBox);
			var carbs = parseTextBoxForInt(carbsTextBox);
			var sugars = parseTextBoxForInt(sugarsTextBox);
			var protein = parseTextBoxForInt(proteinTextBox);
			var salt = parseTextBoxForInt(saltTextBox);

			currentDayItems.Items.Add(new FoodBoxItem(calories, fats, sats, carbs, sugars, protein, salt, nameTextBox.Text));

			var totalCalories = 0;
			foreach(FoodBoxItem item in currentDayItems.Items) {
				totalCalories += item.calories;
			}

			totalCal.Text = totalCalories.ToString();

			this.resetFields();
		}

		private int parseTextBoxForInt(System.Windows.Forms.TextBox text) {
			var parsed = int.Parse(text.Text);
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
			// here a double click will populate the 
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
			// when the user changes the chosen date, everything should update
		}

		private void caloriesTextBox_KeyPress(object sender, KeyPressEventArgs e) {
			// validate that a number was entered 
			//if(!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar)) {
			//	e.Handled = true;
			//	return;
			//}
		}
	}
}
