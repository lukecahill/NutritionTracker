﻿namespace food_tracker {
	partial class trackerForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.currentDayItems = new System.Windows.Forms.ListBox();
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.saturatesTextBox = new System.Windows.Forms.TextBox();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.sugarsTextBox = new System.Windows.Forms.TextBox();
            this.proteinTextBox = new System.Windows.Forms.TextBox();
            this.fibreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.totalSaltLbl = new System.Windows.Forms.Label();
            this.totalProteinLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalFibreLbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalSugarsLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalCarbsLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.totalSatFatLbl = new System.Windows.Forms.Label();
            this.totalFatLbl = new System.Windows.Forms.Label();
            this.totalCalLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutritionItemId = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pastItemsCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillWithExampleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printWeekTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.menuItemContext.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentDayItems
            // 
            this.currentDayItems.FormattingEnabled = true;
            this.currentDayItems.Location = new System.Drawing.Point(12, 80);
            this.currentDayItems.Name = "currentDayItems";
            this.currentDayItems.Size = new System.Drawing.Size(416, 134);
            this.currentDayItems.TabIndex = 0;
            this.currentDayItems.DoubleClick += new System.EventHandler(this.currentDayItems_DoubleClick);
            this.currentDayItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentDayItems_MouseUp);
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(300, 72);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(100, 58);
            this.addNewItemButton.TabIndex = 1;
            this.addNewItemButton.Text = "Add";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(157, 161);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbsTextBox.TabIndex = 2;
            this.carbsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carbsTextBox_KeyPress);
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(17, 161);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.caloriesTextBox.TabIndex = 3;
            this.caloriesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caloriesTextBox_KeyPress);
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(17, 197);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatTextBox.TabIndex = 4;
            this.fatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatTextBox_KeyPress);
            // 
            // saturatesTextBox
            // 
            this.saturatesTextBox.Location = new System.Drawing.Point(17, 237);
            this.saturatesTextBox.Name = "saturatesTextBox";
            this.saturatesTextBox.Size = new System.Drawing.Size(100, 20);
            this.saturatesTextBox.TabIndex = 5;
            this.saturatesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saturatesTextBox_KeyPress);
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(300, 197);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(100, 20);
            this.saltTextBox.TabIndex = 6;
            this.saltTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saltTextBox_KeyPress);
            // 
            // sugarsTextBox
            // 
            this.sugarsTextBox.Location = new System.Drawing.Point(157, 197);
            this.sugarsTextBox.Name = "sugarsTextBox";
            this.sugarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.sugarsTextBox.TabIndex = 8;
            this.sugarsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sugarsTextBox_KeyPress);
            // 
            // proteinTextBox
            // 
            this.proteinTextBox.Location = new System.Drawing.Point(300, 161);
            this.proteinTextBox.Name = "proteinTextBox";
            this.proteinTextBox.Size = new System.Drawing.Size(100, 20);
            this.proteinTextBox.TabIndex = 9;
            this.proteinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proteinTextBox_KeyPress);
            // 
            // fibreTextBox
            // 
            this.fibreTextBox.Location = new System.Drawing.Point(157, 237);
            this.fibreTextBox.Name = "fibreTextBox";
            this.fibreTextBox.Size = new System.Drawing.Size(100, 20);
            this.fibreTextBox.TabIndex = 10;
            this.fibreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fibreTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saturated Fat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Carbohydrates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sugars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fibre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Protein";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salt";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(416, 20);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.totalSaltLbl);
            this.panel1.Controls.Add(this.totalProteinLbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.totalFibreLbl);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.totalSugarsLbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.totalCarbsLbl);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.totalSatFatLbl);
            this.panel1.Controls.Add(this.totalFatLbl);
            this.panel1.Controls.Add(this.totalCalLbl);
            this.panel1.Location = new System.Drawing.Point(12, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 146);
            this.panel1.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Carbs";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(193, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Salt";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSaltLbl
            // 
            this.totalSaltLbl.AutoSize = true;
            this.totalSaltLbl.Location = new System.Drawing.Point(224, 117);
            this.totalSaltLbl.Name = "totalSaltLbl";
            this.totalSaltLbl.Size = new System.Drawing.Size(10, 13);
            this.totalSaltLbl.TabIndex = 36;
            this.totalSaltLbl.Text = "-";
            // 
            // totalProteinLbl
            // 
            this.totalProteinLbl.AutoSize = true;
            this.totalProteinLbl.Location = new System.Drawing.Point(224, 95);
            this.totalProteinLbl.Name = "totalProteinLbl";
            this.totalProteinLbl.Size = new System.Drawing.Size(10, 13);
            this.totalProteinLbl.TabIndex = 34;
            this.totalProteinLbl.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Current Day Totals";
            // 
            // totalFibreLbl
            // 
            this.totalFibreLbl.AutoSize = true;
            this.totalFibreLbl.Location = new System.Drawing.Point(224, 72);
            this.totalFibreLbl.Name = "totalFibreLbl";
            this.totalFibreLbl.Size = new System.Drawing.Size(10, 13);
            this.totalFibreLbl.TabIndex = 32;
            this.totalFibreLbl.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(178, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Protein";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Fibre";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Calories";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSugarsLbl
            // 
            this.totalSugarsLbl.AutoSize = true;
            this.totalSugarsLbl.Location = new System.Drawing.Point(224, 50);
            this.totalSugarsLbl.Name = "totalSugarsLbl";
            this.totalSugarsLbl.Size = new System.Drawing.Size(10, 13);
            this.totalSugarsLbl.TabIndex = 30;
            this.totalSugarsLbl.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fat";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCarbsLbl
            // 
            this.totalCarbsLbl.AutoSize = true;
            this.totalCarbsLbl.Location = new System.Drawing.Point(57, 117);
            this.totalCarbsLbl.Name = "totalCarbsLbl";
            this.totalCarbsLbl.Size = new System.Drawing.Size(10, 13);
            this.totalCarbsLbl.TabIndex = 28;
            this.totalCarbsLbl.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Sat. Fat";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Sugars";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSatFatLbl
            // 
            this.totalSatFatLbl.AutoSize = true;
            this.totalSatFatLbl.Location = new System.Drawing.Point(57, 95);
            this.totalSatFatLbl.Name = "totalSatFatLbl";
            this.totalSatFatLbl.Size = new System.Drawing.Size(10, 13);
            this.totalSatFatLbl.TabIndex = 26;
            this.totalSatFatLbl.Text = "-";
            // 
            // totalFatLbl
            // 
            this.totalFatLbl.AutoSize = true;
            this.totalFatLbl.Location = new System.Drawing.Point(57, 72);
            this.totalFatLbl.Name = "totalFatLbl";
            this.totalFatLbl.Size = new System.Drawing.Size(10, 13);
            this.totalFatLbl.TabIndex = 24;
            this.totalFatLbl.Text = "-";
            // 
            // totalCalLbl
            // 
            this.totalCalLbl.AutoSize = true;
            this.totalCalLbl.Location = new System.Drawing.Point(57, 50);
            this.totalCalLbl.Name = "totalCalLbl";
            this.totalCalLbl.Size = new System.Drawing.Size(10, 13);
            this.totalCalLbl.TabIndex = 22;
            this.totalCalLbl.Text = "-";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.nameTextBox.Location = new System.Drawing.Point(94, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name this item";
            // 
            // menuItemContext
            // 
            this.menuItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItem});
            this.menuItemContext.Name = "contextMenuStrip1";
            this.menuItemContext.Size = new System.Drawing.Size(118, 26);
            // 
            // removeItem
            // 
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(117, 22);
            this.removeItem.Text = "Remove";
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // nutritionItemId
            // 
            this.nutritionItemId.AutoSize = true;
            this.nutritionItemId.Location = new System.Drawing.Point(12, 60);
            this.nutritionItemId.Name = "nutritionItemId";
            this.nutritionItemId.Size = new System.Drawing.Size(58, 13);
            this.nutritionItemId.TabIndex = 23;
            this.nutritionItemId.Text = "itemIdHere";
            this.nutritionItemId.Visible = false;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(94, 110);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(182, 20);
            this.amountTextbox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Amount (ml/g)";
            // 
            // pastItemsCombo
            // 
            this.pastItemsCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.pastItemsCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pastItemsCombo.FormattingEnabled = true;
            this.pastItemsCombo.Location = new System.Drawing.Point(16, 34);
            this.pastItemsCombo.Name = "pastItemsCombo";
            this.pastItemsCombo.Size = new System.Drawing.Size(384, 21);
            this.pastItemsCombo.TabIndex = 26;
            this.pastItemsCombo.SelectedIndexChanged += new System.EventHandler(this.pastItemsCombo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Choose an existing item:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.addNewItemButton);
            this.panel2.Controls.Add(this.carbsTextBox);
            this.panel2.Controls.Add(this.pastItemsCombo);
            this.panel2.Controls.Add(this.caloriesTextBox);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.fatTextBox);
            this.panel2.Controls.Add(this.amountTextbox);
            this.panel2.Controls.Add(this.saturatesTextBox);
            this.panel2.Controls.Add(this.saltTextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.sugarsTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.proteinTextBox);
            this.panel2.Controls.Add(this.fibreTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 276);
            this.panel2.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(297, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 36);
            this.label17.TabIndex = 30;
            this.label17.Text = "Amounts should be in grams";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillWithExampleDataToolStripMenuItem,
            this.printWeekTotalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // fillWithExampleDataToolStripMenuItem
            // 
            this.fillWithExampleDataToolStripMenuItem.Name = "fillWithExampleDataToolStripMenuItem";
            this.fillWithExampleDataToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fillWithExampleDataToolStripMenuItem.Text = "&Fill with Example Data";
            this.fillWithExampleDataToolStripMenuItem.Click += new System.EventHandler(this.fillWithExampleDataToolStripMenuItem_Click);
            // 
            // printWeekTotalToolStripMenuItem
            // 
            this.printWeekTotalToolStripMenuItem.Name = "printWeekTotalToolStripMenuItem";
            this.printWeekTotalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.printWeekTotalToolStripMenuItem.Text = "&Print Week Total";
            this.printWeekTotalToolStripMenuItem.Click += new System.EventHandler(this.printWeekTotalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // trackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nutritionItemId);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.currentDayItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "trackerForm";
            this.Text = "Nutrition Tracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuItemContext.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox currentDayItems;
		private System.Windows.Forms.Button addNewItemButton;
		private System.Windows.Forms.TextBox carbsTextBox;
		private System.Windows.Forms.TextBox caloriesTextBox;
		private System.Windows.Forms.TextBox fatTextBox;
		private System.Windows.Forms.TextBox saturatesTextBox;
		private System.Windows.Forms.TextBox saltTextBox;
		private System.Windows.Forms.TextBox sugarsTextBox;
		private System.Windows.Forms.TextBox proteinTextBox;
		private System.Windows.Forms.TextBox fibreTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label totalSaltLbl;
		private System.Windows.Forms.Label totalProteinLbl;
		private System.Windows.Forms.Label totalFibreLbl;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label totalSugarsLbl;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label totalCarbsLbl;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label totalSatFatLbl;
		private System.Windows.Forms.Label totalFatLbl;
		private System.Windows.Forms.Label totalCalLbl;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip menuItemContext;
        private System.Windows.Forms.ToolStripMenuItem removeItem;
        private System.Windows.Forms.Label nutritionItemId;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox pastItemsCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillWithExampleDataToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem printWeekTotalToolStripMenuItem;
    }
}

