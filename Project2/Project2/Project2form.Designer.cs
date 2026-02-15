namespace Project2
{
    partial class Project2form
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
            ShopNamelbl = new Label();
            Instructionlbl = new Label();
            smallcoffee = new PictureBox();
            mediumcoffee = new PictureBox();
            largecoffee = new PictureBox();
            lblCost = new Label();
            lblPrice = new Label();
            btnHidePrice = new Button();
            btnPhone = new Button();
            btnExit = new Button();
            btnShowPrice = new Button();
            ((System.ComponentModel.ISupportInitialize)smallcoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediumcoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)largecoffee).BeginInit();
            SuspendLayout();
            // 
            // ShopNamelbl
            // 
            ShopNamelbl.AutoSize = true;
            ShopNamelbl.BorderStyle = BorderStyle.Fixed3D;
            ShopNamelbl.Location = new Point(287, 127);
            ShopNamelbl.Margin = new Padding(11, 0, 11, 0);
            ShopNamelbl.Name = "ShopNamelbl";
            ShopNamelbl.Size = new Size(802, 67);
            ShopNamelbl.TabIndex = 0;
            ShopNamelbl.Text = "Steve's Burning Hot Coffee";
            ShopNamelbl.Click += label1_Click;
            // 
            // Instructionlbl
            // 
            Instructionlbl.AutoSize = true;
            Instructionlbl.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Instructionlbl.ForeColor = SystemColors.ControlText;
            Instructionlbl.Location = new Point(508, 236);
            Instructionlbl.Name = "Instructionlbl";
            Instructionlbl.Size = new Size(324, 41);
            Instructionlbl.TabIndex = 1;
            Instructionlbl.Text = "Click Image for Price";
            Instructionlbl.Click += Instructionlbl_Click;
            // 
            // smallcoffee
            // 
            smallcoffee.Image = Properties.Resources.small_coffee;
            smallcoffee.Location = new Point(120, 332);
            smallcoffee.Name = "smallcoffee";
            smallcoffee.Size = new Size(224, 139);
            smallcoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            smallcoffee.TabIndex = 2;
            smallcoffee.TabStop = false;
            smallcoffee.Click += smallcoffee_Click;
            // 
            // mediumcoffee
            // 
            mediumcoffee.Image = Properties.Resources.Medium_Coffee;
            mediumcoffee.Location = new Point(497, 332);
            mediumcoffee.Name = "mediumcoffee";
            mediumcoffee.Size = new Size(257, 139);
            mediumcoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            mediumcoffee.TabIndex = 3;
            mediumcoffee.TabStop = false;
            mediumcoffee.Click += mediumcoffee_Click;
            // 
            // largecoffee
            // 
            largecoffee.Image = Properties.Resources.Large_Coffee;
            largecoffee.Location = new Point(912, 332);
            largecoffee.Name = "largecoffee";
            largecoffee.Size = new Size(322, 139);
            largecoffee.SizeMode = PictureBoxSizeMode.StretchImage;
            largecoffee.TabIndex = 5;
            largecoffee.TabStop = false;
            largecoffee.Click += largecoffee_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCost.ForeColor = SystemColors.ControlText;
            lblCost.Location = new Point(197, 569);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(111, 48);
            lblCost.TabIndex = 6;
            lblCost.Text = "Cost:";
            lblCost.Click += label1_Click_1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;
            lblPrice.Location = new Point(464, 569);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 48);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "$";
            lblPrice.Click += lblPrice_Click;
            // 
            // btnHidePrice
            // 
            btnHidePrice.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHidePrice.ForeColor = SystemColors.ControlText;
            btnHidePrice.Location = new Point(788, 568);
            btnHidePrice.Name = "btnHidePrice";
            btnHidePrice.Size = new Size(198, 60);
            btnHidePrice.TabIndex = 8;
            btnHidePrice.Text = "Hide Price";
            btnHidePrice.UseVisualStyleBackColor = true;
            btnHidePrice.Click += btnHidePrice_Click;
            // 
            // btnPhone
            // 
            btnPhone.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhone.ForeColor = SystemColors.ControlText;
            btnPhone.Location = new Point(171, 731);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(184, 91);
            btnPhone.TabIndex = 9;
            btnPhone.Text = "Display Phone #";
            btnPhone.UseVisualStyleBackColor = true;
            btnPhone.Click += btnPhone_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(1017, 762);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(156, 60);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnShowPrice
            // 
            btnShowPrice.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPrice.ForeColor = SystemColors.ControlText;
            btnShowPrice.Location = new Point(1068, 568);
            btnShowPrice.Name = "btnShowPrice";
            btnShowPrice.Size = new Size(177, 60);
            btnShowPrice.TabIndex = 11;
            btnShowPrice.Text = "Show Price";
            btnShowPrice.UseVisualStyleBackColor = true;
            btnShowPrice.Click += btnShowPrice_Click;
            // 
            // Project2form
            // 
            AutoScaleDimensions = new SizeF(38F, 65F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 852);
            Controls.Add(btnShowPrice);
            Controls.Add(btnExit);
            Controls.Add(btnPhone);
            Controls.Add(btnHidePrice);
            Controls.Add(lblPrice);
            Controls.Add(lblCost);
            Controls.Add(largecoffee);
            Controls.Add(mediumcoffee);
            Controls.Add(smallcoffee);
            Controls.Add(Instructionlbl);
            Controls.Add(ShopNamelbl);
            Font = new Font("Georgia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Blue;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(11, 8, 11, 8);
            MaximizeBox = false;
            Name = "Project2form";
            Text = "Stephen Burns";
            ((System.ComponentModel.ISupportInitialize)smallcoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediumcoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)largecoffee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShopNamelbl;
        private Label Instructionlbl;
        private PictureBox smallcoffee;
        private PictureBox mediumcoffee;
        private PictureBox largecoffee;
        private Label lblCost;
        private Label lblPrice;
        private Button btnHidePrice;
        private Button btnPhone;
        private Button btnExit;
        private Button btnShowPrice;
    }
}
