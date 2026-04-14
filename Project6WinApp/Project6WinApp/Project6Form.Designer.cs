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
            txtFoodSales = new TextBox();
            txtDrinkSales = new TextBox();
            cmbEntryDay = new ComboBox();
            btnSaveSales = new Button();
            lblFoodSales = new Label();
            lblDrinkSales = new Label();
            lblDayWeek1 = new Label();
            grpLookupSales = new GroupBox();
            cmbLookupDay = new ComboBox();
            btnLookupSales = new Button();
            lblDayWeek2 = new Label();
            grpSalesReport = new GroupBox();
            rbWeeklyOverall = new RadioButton();
            rbWeeklyFood = new RadioButton();
            rbWeeklyDrink = new RadioButton();
            btnDisplayAmount = new Button();
            lblTitle = new Label();
            btnClearAllSales = new Button();
            btnExit = new Button();
            grpSalesEntry.SuspendLayout();
            grpLookupSales.SuspendLayout();
            grpSalesReport.SuspendLayout();
            SuspendLayout();
            // 
            // grpSalesEntry
            // 
            grpSalesEntry.Controls.Add(txtFoodSales);
            grpSalesEntry.Controls.Add(txtDrinkSales);
            grpSalesEntry.Controls.Add(cmbEntryDay);
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
            // txtFoodSales
            // 
            txtFoodSales.Location = new Point(501, 138);
            txtFoodSales.Name = "txtFoodSales";
            txtFoodSales.Size = new Size(216, 31);
            txtFoodSales.TabIndex = 9;
            // 
            // txtDrinkSales
            // 
            txtDrinkSales.Location = new Point(501, 69);
            txtDrinkSales.Name = "txtDrinkSales";
            txtDrinkSales.Size = new Size(216, 31);
            txtDrinkSales.TabIndex = 8;
            // 
            // cmbEntryDay
            // 
            cmbEntryDay.FormattingEnabled = true;
            cmbEntryDay.Location = new Point(40, 110);
            cmbEntryDay.Name = "cmbEntryDay";
            cmbEntryDay.Size = new Size(180, 33);
            cmbEntryDay.TabIndex = 7;
            // 
            // btnSaveSales
            // 
            btnSaveSales.Location = new Point(261, 190);
            btnSaveSales.Name = "btnSaveSales";
            btnSaveSales.Size = new Size(159, 42);
            btnSaveSales.TabIndex = 0;
            btnSaveSales.Text = "Save Sales Data";
            btnSaveSales.UseVisualStyleBackColor = true;
            btnSaveSales.Click += btnSaveSales_Click;
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
            // lblDrinkSales
            // 
            lblDrinkSales.AutoSize = true;
            lblDrinkSales.Location = new Point(385, 72);
            lblDrinkSales.Name = "lblDrinkSales";
            lblDrinkSales.Size = new Size(99, 25);
            lblDrinkSales.TabIndex = 5;
            lblDrinkSales.Text = "Drink Sales";
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
            // grpLookupSales
            // 
            grpLookupSales.Controls.Add(cmbLookupDay);
            grpLookupSales.Controls.Add(btnLookupSales);
            grpLookupSales.Controls.Add(lblDayWeek2);
            grpLookupSales.Location = new Point(27, 522);
            grpLookupSales.Name = "grpLookupSales";
            grpLookupSales.Size = new Size(285, 278);
            grpLookupSales.TabIndex = 1;
            grpLookupSales.TabStop = false;
            grpLookupSales.Text = "Look Up Sales";
            // 
            // cmbLookupDay
            // 
            cmbLookupDay.FormattingEnabled = true;
            cmbLookupDay.Location = new Point(40, 98);
            cmbLookupDay.Name = "cmbLookupDay";
            cmbLookupDay.Size = new Size(180, 33);
            cmbLookupDay.TabIndex = 8;
            // 
            // btnLookupSales
            // 
            btnLookupSales.Location = new Point(69, 176);
            btnLookupSales.Name = "btnLookupSales";
            btnLookupSales.Size = new Size(135, 77);
            btnLookupSales.TabIndex = 5;
            btnLookupSales.Text = "Look Up Sales";
            btnLookupSales.UseVisualStyleBackColor = true;
            btnLookupSales.Click += btnLookupSales_Click;
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
            // grpSalesReport
            // 
            grpSalesReport.Controls.Add(rbWeeklyOverall);
            grpSalesReport.Controls.Add(rbWeeklyFood);
            grpSalesReport.Controls.Add(rbWeeklyDrink);
            grpSalesReport.Controls.Add(btnDisplayAmount);
            grpSalesReport.Location = new Point(412, 522);
            grpSalesReport.Name = "grpSalesReport";
            grpSalesReport.Size = new Size(362, 278);
            grpSalesReport.TabIndex = 2;
            grpSalesReport.TabStop = false;
            grpSalesReport.Text = "Sales Reporting";
            // 
            // rbWeeklyOverall
            // 
            rbWeeklyOverall.AutoSize = true;
            rbWeeklyOverall.Location = new Point(83, 150);
            rbWeeklyOverall.Name = "rbWeeklyOverall";
            rbWeeklyOverall.Size = new Size(273, 29);
            rbWeeklyOverall.TabIndex = 4;
            rbWeeklyOverall.TabStop = true;
            rbWeeklyOverall.Text = "Calculate Overall Weekly Sales";
            rbWeeklyOverall.UseVisualStyleBackColor = true;
            // 
            // rbWeeklyFood
            // 
            rbWeeklyFood.AutoSize = true;
            rbWeeklyFood.Location = new Point(83, 98);
            rbWeeklyFood.Name = "rbWeeklyFood";
            rbWeeklyFood.Size = new Size(260, 29);
            rbWeeklyFood.TabIndex = 3;
            rbWeeklyFood.TabStop = true;
            rbWeeklyFood.Text = "Calculate Weekly Food Sales";
            rbWeeklyFood.UseVisualStyleBackColor = true;
            // 
            // rbWeeklyDrink
            // 
            rbWeeklyDrink.AutoSize = true;
            rbWeeklyDrink.Location = new Point(83, 45);
            rbWeeklyDrink.Name = "rbWeeklyDrink";
            rbWeeklyDrink.Size = new Size(260, 29);
            rbWeeklyDrink.TabIndex = 2;
            rbWeeklyDrink.TabStop = true;
            rbWeeklyDrink.Text = "Calculate Weekly Drink Sales";
            rbWeeklyDrink.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAmount
            // 
            btnDisplayAmount.Location = new Point(135, 194);
            btnDisplayAmount.Name = "btnDisplayAmount";
            btnDisplayAmount.Size = new Size(128, 69);
            btnDisplayAmount.TabIndex = 1;
            btnDisplayAmount.Text = "Display Amount";
            btnDisplayAmount.UseVisualStyleBackColor = true;
            btnDisplayAmount.Click += btnDisplayAmount_Click;
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
            // btnClearAllSales
            // 
            btnClearAllSales.Location = new Point(96, 829);
            btnClearAllSales.Name = "btnClearAllSales";
            btnClearAllSales.Size = new Size(159, 42);
            btnClearAllSales.TabIndex = 4;
            btnClearAllSales.Text = "Clear All Sales";
            btnClearAllSales.UseVisualStyleBackColor = true;
            btnClearAllSales.Click += btnClearAllSales_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(516, 829);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Project6Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 896);
            Controls.Add(btnExit);
            Controls.Add(btnClearAllSales);
            Controls.Add(lblTitle);
            Controls.Add(grpSalesReport);
            Controls.Add(grpLookupSales);
            Controls.Add(grpSalesEntry);
            Name = "Project6Form";
            Text = "Stephen Burns";
            grpSalesEntry.ResumeLayout(false);
            grpSalesEntry.PerformLayout();
            grpLookupSales.ResumeLayout(false);
            grpLookupSales.PerformLayout();
            grpSalesReport.ResumeLayout(false);
            grpSalesReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSalesEntry;
        private GroupBox grpLookupSales;
        private GroupBox grpSalesReport;
        private Label lblTitle;
        private ComboBox cmbEntryDay;
        private Button btnSaveSales;
        private Label lblFoodSales;
        private Label lblDrinkSales;
        private Label lblDayWeek1;
        private ComboBox cmbLookupDay;
        private Button btnLookupSales;
        private Label lblDayWeek2;
        private RadioButton rbWeeklyOverall;
        private RadioButton rbWeeklyFood;
        private RadioButton rbWeeklyDrink;
        private Button btnDisplayAmount;
        private Button btnClearAllSales;
        private Button btnExit;
        private TextBox txtFoodSales;
        private TextBox txtDrinkSales;
    }
}
