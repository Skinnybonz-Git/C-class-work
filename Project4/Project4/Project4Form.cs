namespace Project4
{
    public partial class Project4Web : Form
    {
        public Project4Web()
        {
            InitializeComponent();
        }
        // Button click: Calculate Order Amount
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check Customer Name
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Must enter a Customer Name before placing an order.");
                txtCustomerName.Focus();
                return;
            }

            // Clear Message Box
            txtMessage.Clear();

            // Validate Quantity
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a numeric quantity");
                txtQuantity.Focus();
                return;
            }

            // Check Drink Type selection
            string drinkType;
            if (lstDrinkType.SelectedItem != null)
            {
                drinkType = lstDrinkType.SelectedItem.ToString();
            }
            else
            {
                drinkType = "";
            }

            // Calculate Order Amount
            double orderAmount = 0;
            if (radioSmall.Checked) orderAmount = 2.0 * quantity;
            else if (radioMedium.Checked) orderAmount = 3.0 * quantity;
            else if (radioLarge.Checked) orderAmount = 4.0 * quantity;

            // Calculate Discount
            bool isEmployee = chkEmployee.Checked;
            double discount = 0;
            if (isEmployee && quantity > 2) discount = orderAmount * 0.10;
            else if (isEmployee && quantity <= 2) discount = orderAmount * 0.08;
            else if (!isEmployee && quantity > 4) discount = orderAmount * 0.05;

            // Calculate Total
            double total = orderAmount - discount;

            // Display amounts
            txtOrderAmount.Text = orderAmount.ToString("C");
            txtDiscount.Text = discount.ToString("C");
            txtTotal.Text = total.ToString("C");

            // Display message based on quantity
            switch (quantity)
            {
                case 0:
                    txtMessage.Text = $"Sorry {txtCustomerName.Text}, nothing was ordered";
                    break;
                case 1:
                    txtMessage.Text = $"{txtCustomerName.Text}, your {drinkType} has arrived!";
                    break;
                case 2:
                    txtMessage.Text = $"{txtCustomerName.Text}, double {drinkType} is coming quickly!";
                    break;
                default:
                    txtMessage.Text = $"Beware! {txtCustomerName.Text}, your {quantity} {drinkType}s have surrounded you!";
                    break;
            }

        }

        // Button click: New Customer
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtQuantity.Clear();
            txtOrderAmount.Clear();
            txtDiscount.Clear();
            txtTotal.Clear();
            txtMessage.Clear();

            radioSmall.Checked = true;
            lstDrinkType.ClearSelected();
            chkEmployee.Checked = false;

            txtQuantity.Focus();
        }

        // Button click: Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
