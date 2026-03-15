namespace Project3
{
    partial class Project3Web
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
            label1 = new Label();
            txtCustomerName = new Label();
            lblJava = new Label();
            lblMocha = new Label();
            lblLatte = new Label();
            lblFrappe = new Label();
            grpboxQuantity = new GroupBox();
            txtFrappeQty = new TextBox();
            txtLatteQty = new TextBox();
            txtMochaQty = new TextBox();
            txtJavaQty = new TextBox();
            grpboxTotal = new GroupBox();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            txtSub = new Label();
            lblTax = new Label();
            lblOrderTotal = new Label();
            txtName = new TextBox();
            txtMessage = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnExit = new Button();
            grpboxQuantity.SuspendLayout();
            grpboxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 21);
            label1.Name = "label1";
            label1.Size = new Size(481, 55);
            label1.TabIndex = 0;
            label1.Text = "Stephen's Coffee Shop";
            // 
            // txtCustomerName
            // 
            txtCustomerName.AutoSize = true;
            txtCustomerName.Location = new Point(122, 103);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(59, 25);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Text = "Name";
            // 
            // lblJava
            // 
            lblJava.AutoSize = true;
            lblJava.Location = new Point(36, 58);
            lblJava.Name = "lblJava";
            lblJava.Size = new Size(45, 25);
            lblJava.TabIndex = 0;
            lblJava.Text = "&Java";
            // 
            // lblMocha
            // 
            lblMocha.AutoSize = true;
            lblMocha.Location = new Point(36, 133);
            lblMocha.Name = "lblMocha";
            lblMocha.Size = new Size(66, 25);
            lblMocha.TabIndex = 4;
            lblMocha.Text = "&Mocha";
            // 
            // lblLatte
            // 
            lblLatte.AutoSize = true;
            lblLatte.Location = new Point(312, 58);
            lblLatte.Name = "lblLatte";
            lblLatte.Size = new Size(50, 25);
            lblLatte.TabIndex = 2;
            lblLatte.Text = "&Latte";
            lblLatte.Click += label5_Click;
            // 
            // lblFrappe
            // 
            lblFrappe.AutoSize = true;
            lblFrappe.Location = new Point(312, 133);
            lblFrappe.Name = "lblFrappe";
            lblFrappe.Size = new Size(67, 25);
            lblFrappe.TabIndex = 6;
            lblFrappe.Text = "&Frappe";
            // 
            // grpboxQuantity
            // 
            grpboxQuantity.Controls.Add(txtFrappeQty);
            grpboxQuantity.Controls.Add(txtLatteQty);
            grpboxQuantity.Controls.Add(txtMochaQty);
            grpboxQuantity.Controls.Add(txtJavaQty);
            grpboxQuantity.Controls.Add(lblJava);
            grpboxQuantity.Controls.Add(lblMocha);
            grpboxQuantity.Controls.Add(lblLatte);
            grpboxQuantity.Controls.Add(lblFrappe);
            grpboxQuantity.Location = new Point(174, 169);
            grpboxQuantity.Name = "grpboxQuantity";
            grpboxQuantity.Size = new Size(583, 194);
            grpboxQuantity.TabIndex = 2;
            grpboxQuantity.TabStop = false;
            grpboxQuantity.Text = "Quantity Ordered";
            // 
            // txtFrappeQty
            // 
            txtFrappeQty.Location = new Point(389, 130);
            txtFrappeQty.Name = "txtFrappeQty";
            txtFrappeQty.Size = new Size(150, 31);
            txtFrappeQty.TabIndex = 7;
            // 
            // txtLatteQty
            // 
            txtLatteQty.Location = new Point(389, 58);
            txtLatteQty.Name = "txtLatteQty";
            txtLatteQty.Size = new Size(150, 31);
            txtLatteQty.TabIndex = 3;
            // 
            // txtMochaQty
            // 
            txtMochaQty.Location = new Point(110, 133);
            txtMochaQty.Name = "txtMochaQty";
            txtMochaQty.Size = new Size(150, 31);
            txtMochaQty.TabIndex = 5;
            // 
            // txtJavaQty
            // 
            txtJavaQty.Location = new Point(110, 58);
            txtJavaQty.Name = "txtJavaQty";
            txtJavaQty.Size = new Size(150, 31);
            txtJavaQty.TabIndex = 1;
            // 
            // grpboxTotal
            // 
            grpboxTotal.Controls.Add(txtOrderTotal);
            grpboxTotal.Controls.Add(txtTax);
            grpboxTotal.Controls.Add(txtSubtotal);
            grpboxTotal.Controls.Add(txtSub);
            grpboxTotal.Controls.Add(lblTax);
            grpboxTotal.Controls.Add(lblOrderTotal);
            grpboxTotal.Location = new Point(225, 392);
            grpboxTotal.Name = "grpboxTotal";
            grpboxTotal.Size = new Size(423, 247);
            grpboxTotal.TabIndex = 7;
            grpboxTotal.TabStop = false;
            grpboxTotal.Text = "Totals";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(192, 195);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(150, 31);
            txtOrderTotal.TabIndex = 15;
            txtOrderTotal.TabStop = false;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(192, 127);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(150, 31);
            txtTax.TabIndex = 14;
            txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(192, 58);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 13;
            txtSubtotal.TabStop = false;
            // 
            // txtSub
            // 
            txtSub.AutoSize = true;
            txtSub.Location = new Point(36, 58);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(79, 25);
            txtSub.TabIndex = 2;
            txtSub.Text = "Subtotal";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(36, 133);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(36, 25);
            lblTax.TabIndex = 3;
            lblTax.Text = "Tax";
            lblTax.Click += label10_Click;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(36, 201);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(100, 25);
            lblOrderTotal.TabIndex = 4;
            lblOrderTotal.Text = "Order Total";
            // 
            // txtName
            // 
            txtName.Location = new Point(225, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(532, 31);
            txtName.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.ForeColor = Color.Magenta;
            txtMessage.Location = new Point(141, 655);
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(586, 31);
            txtMessage.TabIndex = 12;
            txtMessage.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(69, 714);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 59);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "&Submit Order";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(387, 721);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(734, 721);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Project3Web
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(904, 785);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtMessage);
            Controls.Add(txtName);
            Controls.Add(grpboxTotal);
            Controls.Add(grpboxQuantity);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Project3Web";
            Text = "Stephen Burns";
            Load += Form1_Load;
            grpboxQuantity.ResumeLayout(false);
            grpboxQuantity.PerformLayout();
            grpboxTotal.ResumeLayout(false);
            grpboxTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtCustomerName;
        private Label lblJava;
        private Label lblMocha;
        private Label lblLatte;
        private Label lblFrappe;
        private GroupBox grpboxQuantity;
        private TextBox txtJavaQty;
        private GroupBox grpboxTotal;
        private Label txtSub;
        private Label lblTax;
        private Label lblOrderTotal;
        private TextBox txtName;
        private TextBox txtFrappeQty;
        private TextBox txtLatteQty;
        private TextBox txtMochaQty;
        private Button btnSubmit;
        private TextBox txtMessage;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
    }
}
