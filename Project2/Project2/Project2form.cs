namespace Project2
{
    public partial class Project2form : Form
    {
        public Project2form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Small coffee image clicked: displays small price
        private void smallcoffee_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "$2.00";
        }

        private void Instructionlbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //Medium coffee clicked: displays medium price
        private void mediumcoffee_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "$3.00";
        }
        //Large coffee clicked: displays large price
        private void largecoffee_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "$4.00";
        }
        //Hide button clicked: hides price label
        private void btnHidePrice_Click(object sender, EventArgs e)
        {
            lblPrice.Visible = false;
        }
        //Show button clicked: shows price label
        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Visible = true;
        }
        //Display Phone clicked: show message box popup with phone number
        private void btnPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call us at: (260)555-0123");
        }
        // Exit button clicked: closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
