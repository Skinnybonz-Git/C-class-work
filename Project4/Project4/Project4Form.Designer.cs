namespace Project4
{
    partial class Project4Web
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
            btnCalculateOrder.TabIndex = 5;
            btnCalculateOrder.Text = "Calculate Order &Amount";
            btnCalculateOrder.UseVisualStyleBackColor = true;
            btnCalculateOrder.Click += btnCalculate_Click;
            // 
            // btnNewCus
            // 
            btnNewCus.Location = new Point(114, 658);
            btnNewCus.Name = "btnNewCus";
            btnNewCus.Size = new Size(185, 65);
            btnNewCus.TabIndex = 6;
            btnNewCus.Text = "&NewCustomer";
            btnNewCus.UseVisualStyleBackColor = true;
            btnNewCus.Click += btnNewCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(536, 658);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 44);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chkEmployee
            // 
            chkEmployee.AutoSize = true;
            chkEmployee.Location = new Point(589, 349);
            chkEmployee.Name = "chkEmployee";
            chkEmployee.Size = new Size(124, 29);
            chkEmployee.TabIndex = 4;
            chkEmployee.Text = "Employee?";
            chkEmployee.UseVisualStyleBackColor = true;
            // 
            // lstDrinkType
            // 
            lstDrinkType.FormattingEnabled = true;
            lstDrinkType.ItemHeight = 25;
            lstDrinkType.Items.AddRange(new object[] { "Brewed", "Cappucino", "Latte" });
            lstDrinkType.Location = new Point(520, 102);
            lstDrinkType.Name = "lstDrinkType";
            lstDrinkType.Size = new Size(227, 154);
            lstDrinkType.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(517, 312);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(230, 31);
            txtCustomerName.TabIndex = 12;
            txtCustomerName.TabStop = false;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(280, 612);
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(230, 31);
            txtMessage.TabIndex = 13;
            txtMessage.TabStop = false;
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
            txtQuantity.TabIndex = 15;
            txtQuantity.TabStop = false;
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
            // Project4Web
            // 
            AcceptButton = btnCalculateOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnNewCus;
            ClientSize = new Size(780, 735);
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
            Name = "Project4Web";
            Text = "Stephen Burns";
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
    }
}
