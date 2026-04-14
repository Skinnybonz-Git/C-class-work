namespace Project6WinApp
{
    partial class Project6Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSalesEntry = new GroupBox();
            grpLookSales = new GroupBox();
            grpSalesReport = new GroupBox();
            lblTitle = new Label();
            lblDayWeek1 = new Label();
            lblDrinkSales = new Label();
            lblFoodSales = new Label();
            lblDayWeek2 = new Label();
            btnSaveSales = new Button();
            btnLookSales = new Button();
            btnDisplayAmount = new Button();
            btnClearSales = new Button();
            btnExit = new Button();
            radioCalWeekDrink = new RadioButton();
            radioCalWeekFood = new RadioButton();
            radioCalOverWeek = new RadioButton();
            comboDayWeek1 = new ComboBox();
            comboDayWeek2 = new ComboBox();
            txtDrinkSales = new TextBox();
            txtFoodSales = new TextBox();
            grpSalesEntry.SuspendLayout();
            grpLookSales.SuspendLayout();
            grpSalesReport.SuspendLayout();
            SuspendLayout();
            // 
            // grpSalesEntry
            // 
            grpSalesEntry.Controls.Add(txtFoodSales);
            grpSalesEntry.Controls.Add(txtDrinkSales);
            grpSalesEntry.Controls.Add(comboDayWeek1);
            grpSalesEntry.Controls.Add(btnSaveSales);
            grpSalesEntry.Controls.Add(lblFoodSales);
            grpSalesEntry.Controls.Add(lblDrinkSales);
            grpSalesEntry.Controls.Add(lblDayWeek1);
            grpSalesEntry.Location = new Point(27, 206);
            grpSalesEntry.Name = "grpSalesEntry";
            grpSalesEntry.Size = new Size(747, 253);
            grpSalesEntry.TabIndex = 0;
            grpSalesEntry.TabStop = false;
            grpSalesEntry.Text = "Sales Entry";
            // 
            // grpLookSales
            // 
            grpLookSales.Controls.Add(comboDayWeek2);
            grpLookSales.Controls.Add(btnLookSales);
            grpLookSales.Controls.Add(lblDayWeek2);
            grpLookSales.Location = new Point(27, 522);
            grpLookSales.Name = "grpLookSales";
            grpLookSales.Size = new Size(285, 278);
            grpLookSales.TabIndex = 1;
            grpLookSales.TabStop = false;
            grpLookSales.Text = "Look Up Sales";
            // 
            // grpSalesReport
            // 
            grpSalesReport.Controls.Add(radioCalOverWeek);
            grpSalesReport.Controls.Add(radioCalWeekFood);
            grpSalesReport.Controls.Add(radioCalWeekDrink);
            grpSalesReport.Controls.Add(btnDisplayAmount);
            grpSalesReport.Location = new Point(412, 522);
            grpSalesReport.Name = "grpSalesReport";
            grpSalesReport.Size = new Size(362, 278);
            grpSalesReport.TabIndex = 2;
            grpSalesReport.TabStop = false;
            grpSalesReport.Text = "Sales Reporting";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(157, 79);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(518, 48);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Stephen's Burning Hot Coffee";
            // 
            // lblDayWeek1
            // 
            lblDayWeek1.AutoSize = true;
            lblDayWeek1.Location = new Point(40, 69);
            lblDayWeek1.Name = "lblDayWeek1";
            lblDayWeek1.Size = new Size(113, 25);
            lblDayWeek1.TabIndex = 4;
            lblDayWeek1.Text = "Day of Week";
            // 
            // lblDrinkSales
            // 
            lblDrinkSales.AutoSize = true;
            lblDrinkSales.Location = new Point(385, 72);
            lblDrinkSales.Name = "lblDrinkSales";
            lblDrinkSales.Size = new Size(99, 25);
            lblDrinkSales.TabIndex = 5;
            lblDrinkSales.Text = "Drink Sales";
            // 
            // lblFoodSales
            // 
            lblFoodSales.AutoSize = true;
            lblFoodSales.Location = new Point(385, 141);
            lblFoodSales.Name = "lblFoodSales";
            lblFoodSales.Size = new Size(99, 25);
            lblFoodSales.TabIndex = 6;
            lblFoodSales.Text = "Food Sales";
            // 
            // lblDayWeek2
            // 
            lblDayWeek2.AutoSize = true;
            lblDayWeek2.Location = new Point(40, 70);
            lblDayWeek2.Name = "lblDayWeek2";
            lblDayWeek2.Size = new Size(113, 25);
            lblDayWeek2.TabIndex = 4;
            lblDayWeek2.Text = "Day of Week";
            // 
            // btnSaveSales
            // 
            btnSaveSales.Location = new Point(261, 190);
            btnSaveSales.Name = "btnSaveSales";
            btnSaveSales.Size = new Size(159, 42);
            btnSaveSales.TabIndex = 0;
            btnSaveSales.Text = "Save Sales Data";
            btnSaveSales.UseVisualStyleBackColor = true;
            // 
            // btnLookSales
            // 
            btnLookSales.Location = new Point(69, 176);
            btnLookSales.Name = "btnLookSales";
            btnLookSales.Size = new Size(135, 77);
            btnLookSales.TabIndex = 5;
            btnLookSales.Text = "Look Up Sales";
            btnLookSales.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAmount
            // 
            btnDisplayAmount.Location = new Point(135, 194);
            btnDisplayAmount.Name = "btnDisplayAmount";
            btnDisplayAmount.Size = new Size(128, 69);
            btnDisplayAmount.TabIndex = 1;
            btnDisplayAmount.Text = "Display Amount";
            btnDisplayAmount.UseVisualStyleBackColor = true;
            // 
            // btnClearSales
            // 
            btnClearSales.Location = new Point(96, 829);
            btnClearSales.Name = "btnClearSales";
            btnClearSales.Size = new Size(159, 42);
            btnClearSales.TabIndex = 4;
            btnClearSales.Text = "Clear All Sales";
            btnClearSales.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(516, 829);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // radioCalWeekDrink
            // 
            radioCalWeekDrink.AutoSize = true;
            radioCalWeekDrink.Location = new Point(83, 45);
            radioCalWeekDrink.Name = "radioCalWeekDrink";
            radioCalWeekDrink.Size = new Size(260, 29);
            radioCalWeekDrink.TabIndex = 2;
            radioCalWeekDrink.TabStop = true;
            radioCalWeekDrink.Text = "Calculate Weekly Drink Sales";
            radioCalWeekDrink.UseVisualStyleBackColor = true;
            // 
            // radioCalWeekFood
            // 
            radioCalWeekFood.AutoSize = true;
            radioCalWeekFood.Location = new Point(83, 98);
            radioCalWeekFood.Name = "radioCalWeekFood";
            radioCalWeekFood.Size = new Size(260, 29);
            radioCalWeekFood.TabIndex = 3;
            radioCalWeekFood.TabStop = true;
            radioCalWeekFood.Text = "Calculate Weekly Food Sales";
            radioCalWeekFood.UseVisualStyleBackColor = true;
            // 
            // radioCalOverWeek
            // 
            radioCalOverWeek.AutoSize = true;
            radioCalOverWeek.Location = new Point(83, 150);
            radioCalOverWeek.Name = "radioCalOverWeek";
            radioCalOverWeek.Size = new Size(273, 29);
            radioCalOverWeek.TabIndex = 4;
            radioCalOverWeek.TabStop = true;
            radioCalOverWeek.Text = "Calculate Overall Weekly Sales";
            radioCalOverWeek.UseVisualStyleBackColor = true;
            // 
            // comboDayWeek1
            // 
            comboDayWeek1.FormattingEnabled = true;
            comboDayWeek1.Location = new Point(40, 110);
            comboDayWeek1.Name = "comboDayWeek1";
            comboDayWeek1.Size = new Size(180, 33);
            comboDayWeek1.TabIndex = 7;
            // 
            // comboDayWeek2
            // 
            comboDayWeek2.FormattingEnabled = true;
            comboDayWeek2.Location = new Point(40, 98);
            comboDayWeek2.Name = "comboDayWeek2";
            comboDayWeek2.Size = new Size(180, 33);
            comboDayWeek2.TabIndex = 8;
            // 
            // txtDrinkSales
            // 
            txtDrinkSales.Location = new Point(501, 69);
            txtDrinkSales.Name = "txtDrinkSales";
            txtDrinkSales.Size = new Size(216, 31);
            txtDrinkSales.TabIndex = 8;
            // 
            // txtFoodSales
            // 
            txtFoodSales.Location = new Point(501, 138);
            txtFoodSales.Name = "txtFoodSales";
            txtFoodSales.Size = new Size(216, 31);
            txtFoodSales.TabIndex = 9;
            // 
            // Project6Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 896);
            Controls.Add(btnExit);
            Controls.Add(btnClearSales);
            Controls.Add(lblTitle);
            Controls.Add(grpSalesReport);
            Controls.Add(grpLookSales);
            Controls.Add(grpSalesEntry);
            Name = "Project6Form";
            Text = "Stephen Burns";
            grpSalesEntry.ResumeLayout(false);
            grpSalesEntry.PerformLayout();
            grpLookSales.ResumeLayout(false);
            grpLookSales.PerformLayout();
            grpSalesReport.ResumeLayout(false);
            grpSalesReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSalesEntry;
        private GroupBox grpLookSales;
        private GroupBox grpSalesReport;
        private Label lblTitle;
        private ComboBox comboDayWeek1;
        private Button btnSaveSales;
        private Label lblFoodSales;
        private Label lblDrinkSales;
        private Label lblDayWeek1;
        private ComboBox comboDayWeek2;
        private Button btnLookSales;
        private Label lblDayWeek2;
        private RadioButton radioCalOverWeek;
        private RadioButton radioCalWeekFood;
        private RadioButton radioCalWeekDrink;
        private Button btnDisplayAmount;
        private Button btnClearSales;
        private Button btnExit;
        private TextBox txtFoodSales;
        private TextBox txtDrinkSales;
    }
}
