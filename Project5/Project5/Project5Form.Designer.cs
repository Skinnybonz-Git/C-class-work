namespace Project5
{
    partial class Project5Web
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
            components = new System.ComponentModel.Container();
            lblOrderAmount = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblDrinkType = new Label();
            grpSize = new GroupBox();
            radioLarge = new RadioButton();
            radioMedium = new RadioButton();
            radioSmall = new RadioButton();
            grpOrdTotal = new GroupBox();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtOrderAmount = new TextBox();
            lblQuantity = new Label();
            btnCalculateOrder = new Button();
            btnNewCus = new Button();
            btnExit = new Button();
            chkEmployee = new CheckBox();
            lstDrinkType = new ListBox();
            txtCustomerName = new TextBox();
            txtMessage = new TextBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            lblCustomername = new Label();
            comboFlavor = new ComboBox();
            btnAdd = new Button();
            btnClearDrink = new Button();
            lblCoffeeFlavor = new Label();
            toolAddCoffee = new ToolTip(components);
            toolExit = new ToolTip(components);
            toolQuantity = new ToolTip(components);
            toolNewCustomer = new ToolTip(components);
            toolClearDrink = new ToolTip(components);
            toolCalculate = new ToolTip(components);
            toolMessage = new ToolTip(components);
            toolCustomerName = new ToolTip(components);
            toolEmployee = new ToolTip(components);
            grpSize.SuspendLayout();
            grpOrdTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderAmount
            // 
            lblOrderAmount.AutoSize = true;
            lblOrderAmount.Location = new Point(18, 46);
            lblOrderAmount.Name = "lblOrderAmount";
            lblOrderAmount.Size = new Size(132, 25);
            lblOrderAmount.TabIndex = 0;
            lblOrderAmount.Text = "Order Amount:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(18, 110);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(86, 25);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 167);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // lblDrinkType
            // 
            lblDrinkType.AutoSize = true;
            lblDrinkType.Location = new Point(520, 61);
            lblDrinkType.Name = "lblDrinkType";
            lblDrinkType.Size = new Size(100, 25);
            lblDrinkType.TabIndex = 1;
            lblDrinkType.Text = "Drink Type:";
            // 
            // grpSize
            // 
            grpSize.Controls.Add(radioLarge);
            grpSize.Controls.Add(radioMedium);
            grpSize.Controls.Add(radioSmall);
            grpSize.Location = new Point(29, 41);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(250, 187);
            grpSize.TabIndex = 0;
            grpSize.TabStop = false;
            grpSize.Text = "Size:";
            // 
            // radioLarge
            // 
            radioLarge.AutoSize = true;
            radioLarge.Location = new Point(18, 140);
            radioLarge.Name = "radioLarge";
            radioLarge.Size = new Size(80, 29);
            radioLarge.TabIndex = 2;
            radioLarge.TabStop = true;
            radioLarge.Text = "&Large";
            radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            radioMedium.AutoSize = true;
            radioMedium.Location = new Point(18, 90);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(103, 29);
            radioMedium.TabIndex = 1;
            radioMedium.TabStop = true;
            radioMedium.Text = "&Medium";
            radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            radioSmall.AutoSize = true;
            radioSmall.Location = new Point(18, 46);
            radioSmall.Name = "radioSmall";
            radioSmall.Size = new Size(80, 29);
            radioSmall.TabIndex = 0;
            radioSmall.TabStop = true;
            radioSmall.Text = "&Small";
            radioSmall.UseVisualStyleBackColor = true;
            // 
            // grpOrdTotal
            // 
            grpOrdTotal.Controls.Add(txtTotal);
            grpOrdTotal.Controls.Add(txtDiscount);
            grpOrdTotal.Controls.Add(txtOrderAmount);
            grpOrdTotal.Controls.Add(lblOrderAmount);
            grpOrdTotal.Controls.Add(lblDiscount);
            grpOrdTotal.Controls.Add(lblTotal);
            grpOrdTotal.Location = new Point(29, 377);
            grpOrdTotal.Name = "grpOrdTotal";
            grpOrdTotal.Size = new Size(339, 216);
            grpOrdTotal.TabIndex = 8;
            grpOrdTotal.TabStop = false;
            grpOrdTotal.Text = "Order Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(156, 161);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(159, 31);
            txtTotal.TabIndex = 16;
            txtTotal.TabStop = false;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(156, 104);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(157, 31);
            txtDiscount.TabIndex = 15;
            txtDiscount.TabStop = false;
            // 
            // txtOrderAmount
            // 
            txtOrderAmount.Location = new Point(156, 40);
            txtOrderAmount.Name = "txtOrderAmount";
            txtOrderAmount.ReadOnly = true;
            txtOrderAmount.Size = new Size(159, 31);
            txtOrderAmount.TabIndex = 14;
            txtOrderAmount.TabStop = false;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(28, 303);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "&Quantity";
            // 
            // btnCalculateOrder
            // 
            btnCalculateOrder.Location = new Point(545, 468);
            btnCalculateOrder.Name = "btnCalculateOrder";
            btnCalculateOrder.Size = new Size(179, 67);
            btnCalculateOrder.TabIndex = 6;
            btnCalculateOrder.Text = "Calculate Order &Amount";
            toolCalculate.SetToolTip(btnCalculateOrder, "When you are ready to price order, click here.\r\n");
            btnCalculateOrder.UseVisualStyleBackColor = true;
            btnCalculateOrder.Click += btnCalculate_Click;
            // 
            // btnNewCus
            // 
            btnNewCus.Location = new Point(114, 658);
            btnNewCus.Name = "btnNewCus";
            btnNewCus.Size = new Size(185, 65);
            btnNewCus.TabIndex = 7;
            btnNewCus.Text = "&NewCustomer";
            toolNewCustomer.SetToolTip(btnNewCus, "To clear previous order/reset order, click here.\r\n");
            btnNewCus.UseVisualStyleBackColor = true;
            btnNewCus.Click += btnNewCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(536, 658);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 44);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            toolExit.SetToolTip(btnExit, "When you are ready to exit application, click here.\r\n");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chkEmployee
            // 
            chkEmployee.AutoSize = true;
            chkEmployee.Location = new Point(589, 349);
            chkEmployee.Name = "chkEmployee";
            chkEmployee.Size = new Size(124, 29);
            chkEmployee.TabIndex = 5;
            chkEmployee.Text = "Employee?";
            toolEmployee.SetToolTip(chkEmployee, "If you are an employee click here for a discount.\r\nIf your not we'll know.\r\n");
            chkEmployee.UseVisualStyleBackColor = true;
            // 
            // lstDrinkType
            // 
            lstDrinkType.FormattingEnabled = true;
            lstDrinkType.ItemHeight = 25;
            lstDrinkType.Items.AddRange(new object[] { "Brewed", "Cappucino", "Frappe", "Iced", "Latte" });
            lstDrinkType.Location = new Point(520, 102);
            lstDrinkType.Name = "lstDrinkType";
            lstDrinkType.Size = new Size(227, 154);
            lstDrinkType.Sorted = true;
            lstDrinkType.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(517, 312);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(230, 31);
            txtCustomerName.TabIndex = 4;
            txtCustomerName.TabStop = false;
            toolCustomerName.SetToolTip(txtCustomerName, "Enter your name here.");
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(65, 612);
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(648, 31);
            txtMessage.TabIndex = 13;
            txtMessage.TabStop = false;
            toolMessage.SetToolTip(txtMessage, "Your selected coffee, price, and lucky numbers\r\nwill appear here after calculation.\r\n");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 353);
            label6.MaximumSize = new Size(0, 5);
            label6.Name = "label6";
            label6.Size = new Size(16, 5);
            label6.TabIndex = 14;
            label6.Text = ":";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(114, 303);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(230, 31);
            txtQuantity.TabIndex = 3;
            txtQuantity.TabStop = false;
            toolQuantity.SetToolTip(txtQuantity, "Enter amount of coffee here.");
            // 
            // lblCustomername
            // 
            lblCustomername.AutoSize = true;
            lblCustomername.Location = new Point(370, 318);
            lblCustomername.Name = "lblCustomername";
            lblCustomername.Size = new Size(141, 25);
            lblCustomername.TabIndex = 3;
            lblCustomername.Text = "&Customer Name";
            // 
            // comboFlavor
            // 
            comboFlavor.FormattingEnabled = true;
            comboFlavor.Items.AddRange(new object[] { "Chocolate Almond", "French Roast", "Kona Blend", "Regular Decaf", "Regular Roast", "Vanilla Nut" });
            comboFlavor.Location = new Point(313, 87);
            comboFlavor.Name = "comboFlavor";
            comboFlavor.Size = new Size(182, 33);
            comboFlavor.Sorted = true;
            comboFlavor.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 34);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add Coffee";
            toolAddCoffee.SetToolTip(btnAdd, "Add your own flavor here.");
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClearDrink
            // 
            btnClearDrink.Location = new Point(559, 262);
            btnClearDrink.Name = "btnClearDrink";
            btnClearDrink.Size = new Size(165, 34);
            btnClearDrink.TabIndex = 18;
            btnClearDrink.Text = "Clear Drink Types";
            toolClearDrink.SetToolTip(btnClearDrink, "To clear drink types, click here.\r\n");
            btnClearDrink.UseVisualStyleBackColor = true;
            btnClearDrink.Click += btnClearDrink_Click;
            // 
            // lblCoffeeFlavor
            // 
            lblCoffeeFlavor.AutoSize = true;
            lblCoffeeFlavor.Location = new Point(342, 27);
            lblCoffeeFlavor.Name = "lblCoffeeFlavor";
            lblCoffeeFlavor.Size = new Size(117, 25);
            lblCoffeeFlavor.TabIndex = 19;
            lblCoffeeFlavor.Text = "Coffee Flavor";
            // 
            // toolAddCoffee
            // 
            toolAddCoffee.Popup += toolTip1_Popup;
            // 
            // Project5Web
            // 
            AcceptButton = btnCalculateOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnNewCus;
            ClientSize = new Size(780, 735);
            Controls.Add(lblCoffeeFlavor);
            Controls.Add(btnClearDrink);
            Controls.Add(btnAdd);
            Controls.Add(comboFlavor);
            Controls.Add(lblCustomername);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtMessage);
            Controls.Add(txtCustomerName);
            Controls.Add(lstDrinkType);
            Controls.Add(chkEmployee);
            Controls.Add(btnExit);
            Controls.Add(btnNewCus);
            Controls.Add(btnCalculateOrder);
            Controls.Add(lblQuantity);
            Controls.Add(grpOrdTotal);
            Controls.Add(grpSize);
            Controls.Add(lblDrinkType);
            Name = "Project5Web";
            Text = "Stephen Burns";
            toolAddCoffee.SetToolTip(this, "Add your own flavor here.\r\n");
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpOrdTotal.ResumeLayout(false);
            grpOrdTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderAmount;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblDrinkType;
        private GroupBox grpSize;
        private GroupBox grpOrdTotal;
        private Label lblQuantity;
        private RadioButton radioLarge;
        private RadioButton radioMedium;
        private RadioButton radioSmall;
        private Button btnCalculateOrder;
        private Button btnNewCus;
        private Button btnExit;
        private CheckBox chkEmployee;
        private TextBox txtTotal;
        private TextBox txtDiscount;
        private TextBox txtOrderAmount;
        private ListBox lstDrinkType;
        private TextBox txtCustomerName;
        private TextBox txtMessage;
        private Label label6;
        private TextBox txtQuantity;
        private Label lblCustomername;
        private ComboBox comboFlavor;
        private Button btnAdd;
        private Button btnClearDrink;
        private Label lblCoffeeFlavor;
        private ToolTip toolAddCoffee;
        private ToolTip toolCustomerName;
        private ToolTip toolQuantity;
        private ToolTip toolExit;
        private ToolTip toolNewCustomer;
        private ToolTip toolClearDrink;
        private ToolTip toolCalculate;
        private ToolTip toolMessage;
        private ToolTip toolEmployee;
    }
}
