namespace WinFormsProject7
{
    public partial class Project7Form : Form
    {
        public Project7Form()
        {
            InitializeComponent();
        }
        // Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string state = txtState.Text.Trim();

            // state to all caps
            state = state.ToUpper();

            // ensure there is a name entry and checks if start index is uppercase
            if (firstName.Length > 0 && !char.IsUpper(firstName[0]))
            {
                MessageBox.Show("Capitalize first letter of first name.");
                txtFirstName.Focus();
                return;
            }

            // ensure there is a name entry and checks if start index is uppercase
            if (lastName.Length > 0 && !char.IsUpper(lastName[0]))
            {
                MessageBox.Show("Capitalize first letter of last name.");
                txtLastName.Focus();
                return;
            }

            // Adds textbox input into list
            string displayText = $"{lastName}, {firstName}, {state}";
            lstCustomers.Items.Add(displayText);

            // Clears textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtState.Clear();
            txtFirstInitial.Clear();
            txtLastInitial.Clear();

            // Jumps back to first name
            txtFirstName.Focus();
        }

        // Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if user selected something
            if (lstCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a name to search for.");
                return;
            }

            // Get selected string
            string selected = lstCustomers.SelectedItem.ToString();

            // Tokenize string
            string[] parts = selected.Split(',');

            if (parts.Length != 3)
            {
                MessageBox.Show("Invalid data format.");
                return;
            }

            string lastName = parts[0].Trim();
            string firstName = parts[1].Trim();
            string state = parts[2].Trim();

            // Display values in textboxes
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtState.Text = state;

            // Set initials
            if (firstName.Length > 0)
                txtFirstInitial.Text = firstName[0].ToString();

            if (lastName.Length > 0)
                txtLastInitial.Text = lastName[0].ToString();
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
