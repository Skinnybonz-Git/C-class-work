namespace Project3
{
    public partial class Project3Web : Form
    {
        public Project3Web()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Prices (constants)
            const decimal PRICE_JAVA = 1.50m;
            const decimal PRICE_MOCHA = 3.25m;
            const decimal PRICE_LATTE = 2.95m;
            const decimal PRICE_FRAPPE = 3.65m;
            const decimal TAX_RATE = 0.07m;

            int javaQty, latteQty, mochaQty, frappeQty;

            // Convert inputs using Try/Catch (as required)
            try
            {
                javaQty = Convert.ToInt32(txtJavaQty.Text);
            }
            catch
            {
                MessageBox.Show("Java quantity must be a whole number (example: 0, 1, 2).");
                txtJavaQty.Focus();
                txtJavaQty.SelectAll();
                return;
            }

            try
            {
                latteQty = Convert.ToInt32(txtLatteQty.Text);
            }
            catch
            {
                MessageBox.Show("Latte quantity must be a whole number (example: 0, 1, 2).");
                txtLatteQty.Focus();
                txtLatteQty.SelectAll();
                return;
            }

            try
            {
                mochaQty = Convert.ToInt32(txtMochaQty.Text);
            }
            catch
            {
                MessageBox.Show("Mocha quantity must be a whole number (example: 0, 1, 2).");
                txtMochaQty.Focus();
                txtMochaQty.SelectAll();
                return;
            }

            try
            {
                frappeQty = Convert.ToInt32(txtFrappeQty.Text);
            }
            catch
            {
                MessageBox.Show("Frappe quantity must be a whole number (example: 0, 1, 2).");
                txtFrappeQty.Focus();
                txtFrappeQty.SelectAll();
                return;
            }

            // Calculations
            decimal subtotal =
                (javaQty * PRICE_JAVA) +
                (latteQty * PRICE_LATTE) +
                (mochaQty * PRICE_MOCHA) +
                (frappeQty * PRICE_FRAPPE);

            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            // Display totals in currency format
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtOrderTotal.Text = total.ToString("C");

            // Thank-you message (magenta text)
            txtMessage.ForeColor = Color.Magenta;
            txtMessage.Text = $"Thank you {txtCustomerName.Text} for your order.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtJavaQty.Clear();
            txtLatteQty.Clear();
            txtMochaQty.Clear();
            txtFrappeQty.Clear();

            txtSubtotal.Clear();
            txtTax.Clear();
            txtOrderTotal.Clear();

            txtMessage.Clear();

            txtCustomerName.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
