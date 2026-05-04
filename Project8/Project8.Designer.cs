namespace WinFormProject8
{
    partial class Project8
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
            lblProduct = new Label();
            lblDescription = new Label();
            lblUnits = new Label();
            lblPrice = new Label();
            lstProducts = new ListBox();
            btnExit = new Button();
            txtPrice = new TextBox();
            lblDescriptionOutcome = new Label();
            lblUnitsOutcome = new Label();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(190, 24);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(148, 25);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product Number:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(266, 229);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Location = new Point(239, 276);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(129, 25);
            lblUnits.TabIndex = 2;
            lblUnits.Text = "Units On Hand";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(319, 322);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(108, 61);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(680, 129);
            lstProducts.TabIndex = 4;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(349, 396);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(392, 316);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(140, 31);
            txtPrice.TabIndex = 6;
            // 
            // lblDescriptionOutcome
            // 
            lblDescriptionOutcome.AutoSize = true;
            lblDescriptionOutcome.Location = new Point(392, 229);
            lblDescriptionOutcome.Name = "lblDescriptionOutcome";
            lblDescriptionOutcome.Size = new Size(59, 25);
            lblDescriptionOutcome.TabIndex = 7;
            lblDescriptionOutcome.Text = "label5";
            // 
            // lblUnitsOutcome
            // 
            lblUnitsOutcome.AutoSize = true;
            lblUnitsOutcome.Location = new Point(392, 276);
            lblUnitsOutcome.Name = "lblUnitsOutcome";
            lblUnitsOutcome.Size = new Size(59, 25);
            lblUnitsOutcome.TabIndex = 8;
            lblUnitsOutcome.Text = "label6";
            // 
            // Project8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUnitsOutcome);
            Controls.Add(lblDescriptionOutcome);
            Controls.Add(txtPrice);
            Controls.Add(btnExit);
            Controls.Add(lstProducts);
            Controls.Add(lblPrice);
            Controls.Add(lblUnits);
            Controls.Add(lblDescription);
            Controls.Add(lblProduct);
            Name = "Project8";
            Text = "Product Database";
            Load += Project8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblDescription;
        private Label lblUnits;
        private Label lblPrice;
        private ListBox lstProducts;
        private Button btnExit;
        private TextBox txtPrice;
        private Label lblDescriptionOutcome;
        private Label lblUnitsOutcome;
    }
}
