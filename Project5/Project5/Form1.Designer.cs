namespace Project5
{
    partial class Project5Form
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
            lblOrdAmount = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblDrink = new Label();
            grpSize = new GroupBox();
            grpOrdTotal = new GroupBox();
            lblQuantity = new Label();
            butCalcOrd = new Button();
            butNewCus = new Button();
            butExit = new Button();
            chkEmployee = new CheckBox();
            radSmall = new RadioButton();
            radMed = new RadioButton();
            radLarge = new RadioButton();
            listDrink = new ListBox();
            txtCusName = new TextBox();
            txtGreet = new TextBox();
            label6 = new Label();
            txtOrdAmount = new TextBox();
            txtDiscount = new TextBox();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            lblCusname = new Label();
            grpSize.SuspendLayout();
            grpOrdTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrdAmount
            // 
            lblOrdAmount.AutoSize = true;
            lblOrdAmount.Location = new Point(18, 46);
            lblOrdAmount.Name = "lblOrdAmount";
            lblOrdAmount.Size = new Size(132, 25);
            lblOrdAmount.TabIndex = 0;
            lblOrdAmount.Text = "Order Amount:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(18, 110);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(86, 25);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount:";
            lblDiscount.Click += label2_Click;
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
            // lblDrink
            // 
            lblDrink.AutoSize = true;
            lblDrink.Location = new Point(520, 61);
            lblDrink.Name = "lblDrink";
            lblDrink.Size = new Size(100, 25);
            lblDrink.TabIndex = 3;
            lblDrink.Text = "Drink Type:";
            // 
            // grpSize
            // 
            grpSize.Controls.Add(radLarge);
            grpSize.Controls.Add(radMed);
            grpSize.Controls.Add(radSmall);
            grpSize.Location = new Point(29, 41);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(250, 187);
            grpSize.TabIndex = 4;
            grpSize.TabStop = false;
            grpSize.Text = "Size:";
            // 
            // grpOrdTotal
            // 
            grpOrdTotal.Controls.Add(txtTotal);
            grpOrdTotal.Controls.Add(txtDiscount);
            grpOrdTotal.Controls.Add(txtOrdAmount);
            grpOrdTotal.Controls.Add(lblOrdAmount);
            grpOrdTotal.Controls.Add(lblDiscount);
            grpOrdTotal.Controls.Add(lblTotal);
            grpOrdTotal.Location = new Point(29, 377);
            grpOrdTotal.Name = "grpOrdTotal";
            grpOrdTotal.Size = new Size(339, 216);
            grpOrdTotal.TabIndex = 5;
            grpOrdTotal.TabStop = false;
            grpOrdTotal.Text = "Order Total:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(28, 303);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "&Quantity";
            // 
            // butCalcOrd
            // 
            butCalcOrd.Location = new Point(545, 468);
            butCalcOrd.Name = "butCalcOrd";
            butCalcOrd.Size = new Size(179, 67);
            butCalcOrd.TabIndex = 7;
            butCalcOrd.Text = "Calculate Order &Amount";
            butCalcOrd.UseVisualStyleBackColor = true;
            // 
            // butNewCus
            // 
            butNewCus.Location = new Point(114, 658);
            butNewCus.Name = "butNewCus";
            butNewCus.Size = new Size(185, 65);
            butNewCus.TabIndex = 8;
            butNewCus.Text = "&NewCustomer";
            butNewCus.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            butExit.Location = new Point(536, 658);
            butExit.Name = "butExit";
            butExit.Size = new Size(165, 44);
            butExit.TabIndex = 9;
            butExit.Text = "E&xit";
            butExit.UseVisualStyleBackColor = true;
            // 
            // chkEmployee
            // 
            chkEmployee.AutoSize = true;
            chkEmployee.Location = new Point(589, 349);
            chkEmployee.Name = "chkEmployee";
            chkEmployee.Size = new Size(124, 29);
            chkEmployee.TabIndex = 10;
            chkEmployee.Text = "Employee?";
            chkEmployee.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            radSmall.AutoSize = true;
            radSmall.Location = new Point(18, 46);
            radSmall.Name = "radSmall";
            radSmall.Size = new Size(80, 29);
            radSmall.TabIndex = 0;
            radSmall.TabStop = true;
            radSmall.Text = "&Small";
            radSmall.UseVisualStyleBackColor = true;
            // 
            // radMed
            // 
            radMed.AutoSize = true;
            radMed.Location = new Point(18, 90);
            radMed.Name = "radMed";
            radMed.Size = new Size(103, 29);
            radMed.TabIndex = 1;
            radMed.TabStop = true;
            radMed.Text = "&Medium";
            radMed.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            radLarge.AutoSize = true;
            radLarge.Location = new Point(18, 140);
            radLarge.Name = "radLarge";
            radLarge.Size = new Size(80, 29);
            radLarge.TabIndex = 2;
            radLarge.TabStop = true;
            radLarge.Text = "&Large";
            radLarge.UseVisualStyleBackColor = true;
            // 
            // listDrink
            // 
            listDrink.FormattingEnabled = true;
            listDrink.ItemHeight = 25;
            listDrink.Location = new Point(520, 102);
            listDrink.Name = "listDrink";
            listDrink.Size = new Size(227, 154);
            listDrink.TabIndex = 11;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(517, 312);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(230, 31);
            txtCusName.TabIndex = 12;
            txtCusName.TabStop = false;
            // 
            // txtGreet
            // 
            txtGreet.Location = new Point(280, 612);
            txtGreet.Name = "txtGreet";
            txtGreet.ReadOnly = true;
            txtGreet.Size = new Size(230, 31);
            txtGreet.TabIndex = 13;
            txtGreet.TabStop = false;
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
            // txtOrdAmount
            // 
            txtOrdAmount.Location = new Point(156, 40);
            txtOrdAmount.Name = "txtOrdAmount";
            txtOrdAmount.Size = new Size(159, 31);
            txtOrdAmount.TabIndex = 14;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(156, 104);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(157, 31);
            txtDiscount.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(156, 161);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(159, 31);
            txtTotal.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(114, 303);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(230, 31);
            txtQuantity.TabIndex = 15;
            txtQuantity.TabStop = false;
            // 
            // lblCusname
            // 
            lblCusname.AutoSize = true;
            lblCusname.Location = new Point(370, 318);
            lblCusname.Name = "lblCusname";
            lblCusname.Size = new Size(141, 25);
            lblCusname.TabIndex = 16;
            lblCusname.Text = "&Customer Name";
            // 
            // project5Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 735);
            Controls.Add(lblCusname);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtGreet);
            Controls.Add(txtCusName);
            Controls.Add(listDrink);
            Controls.Add(chkEmployee);
            Controls.Add(butExit);
            Controls.Add(butNewCus);
            Controls.Add(butCalcOrd);
            Controls.Add(lblQuantity);
            Controls.Add(grpOrdTotal);
            Controls.Add(grpSize);
            Controls.Add(lblDrink);
            Name = "project5Form";
            Text = "Stephen Burns";
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpOrdTotal.ResumeLayout(false);
            grpOrdTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrdAmount;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblDrink;
        private GroupBox grpSize;
        private GroupBox grpOrdTotal;
        private Label lblQuantity;
        private RadioButton radLarge;
        private RadioButton radMed;
        private RadioButton radSmall;
        private Button butCalcOrd;
        private Button butNewCus;
        private Button butExit;
        private CheckBox chkEmployee;
        private TextBox txtTotal;
        private TextBox txtDiscount;
        private TextBox txtOrdAmount;
        private ListBox listDrink;
        private TextBox txtCusName;
        private TextBox txtGreet;
        private Label label6;
        private TextBox txtQuantity;
        private Label lblCusname;
    }
}
