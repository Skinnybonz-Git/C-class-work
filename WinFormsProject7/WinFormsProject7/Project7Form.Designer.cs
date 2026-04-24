namespace WinFormsProject7
{
    partial class Project7Form
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblState = new Label();
            lblFirstInitial = new Label();
            lblLastInitial = new Label();
            lstCustomers = new ListBox();
            lblCustomers = new Label();
            btnSave = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            txtFirstName = new TextBox();
            txtLastInitial = new TextBox();
            txtFirstInitial = new TextBox();
            txtState = new TextBox();
            txtLastName = new TextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(96, 99);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(96, 253);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(96, 388);
            lblState.Name = "lblState";
            lblState.Size = new Size(55, 25);
            lblState.TabIndex = 2;
            lblState.Text = "State:";
            // 
            // lblFirstInitial
            // 
            lblFirstInitial.AutoSize = true;
            lblFirstInitial.Location = new Point(96, 607);
            lblFirstInitial.Name = "lblFirstInitial";
            lblFirstInitial.Size = new Size(96, 25);
            lblFirstInitial.TabIndex = 3;
            lblFirstInitial.Text = "First Initial:";
            // 
            // lblLastInitial
            // 
            lblLastInitial.AutoSize = true;
            lblLastInitial.Location = new Point(541, 607);
            lblLastInitial.Name = "lblLastInitial";
            lblLastInitial.Size = new Size(94, 25);
            lblLastInitial.TabIndex = 4;
            lblLastInitial.Text = "Last Initial:";
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 25;
            lstCustomers.Location = new Point(901, 63);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(600, 379);
            lstCustomers.Sorted = true;
            lstCustomers.TabIndex = 5;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Location = new Point(925, 23);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(101, 25);
            lblCustomers.TabIndex = 6;
            lblCustomers.Text = "Customers:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(245, 494);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1101, 494);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1347, 642);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(231, 93);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(306, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastInitial
            // 
            txtLastInitial.Location = new Point(641, 604);
            txtLastInitial.Name = "txtLastInitial";
            txtLastInitial.Size = new Size(157, 31);
            txtLastInitial.TabIndex = 11;
            // 
            // txtFirstInitial
            // 
            txtFirstInitial.Location = new Point(198, 601);
            txtFirstInitial.Name = "txtFirstInitial";
            txtFirstInitial.Size = new Size(157, 31);
            txtFirstInitial.TabIndex = 12;
            // 
            // txtState
            // 
            txtState.Location = new Point(231, 385);
            txtState.Name = "txtState";
            txtState.Size = new Size(306, 31);
            txtState.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(231, 247);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(306, 31);
            txtLastName.TabIndex = 1;
            // 
            // Project7Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 731);
            Controls.Add(txtLastName);
            Controls.Add(txtState);
            Controls.Add(txtFirstInitial);
            Controls.Add(txtLastInitial);
            Controls.Add(txtFirstName);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(lblCustomers);
            Controls.Add(lstCustomers);
            Controls.Add(lblLastInitial);
            Controls.Add(lblFirstInitial);
            Controls.Add(lblState);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Project7Form";
            Text = "Stephen Burns";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblState;
        private Label lblFirstInitial;
        private Label lblLastInitial;
        private ListBox lstCustomers;
        private Label lblCustomers;
        private Button btnSave;
        private Button btnSearch;
        private Button btnExit;
        private TextBox txtFirstName;
        private TextBox txtLastInitial;
        private TextBox txtFirstInitial;
        private TextBox txtState;
        private TextBox txtLastName;
    }
}
