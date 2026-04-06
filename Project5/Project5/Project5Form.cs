using System.IO;
namespace Project5
{
    public partial class Project5Web : Form
    {
        public Project5Web()
        {
            InitializeComponent();
            // Attach the Load event handler
            this.Load += Project5Web_Load;
        }
        //attempted form load
        private void Project5Web_Load(object sender, EventArgs e)
        {
            // a. Welcome message
            MessageBox.Show("Welcome to our Coffee Ordering Application!");

            // b. Load drink types from file
            try
            {
                using (StreamReader sr = new StreamReader("drinktypes.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lstDrinkType.Items.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: drinktypes.txt not found.");
            }
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

            // Size Selection
            double cost = 0;
            if (radioSmall.Checked) cost = 2.0;
            else if (radioMedium.Checked) cost = 3.0;
            else if (radioLarge.Checked) cost = 4.0;

            double orderAmount = CalcOrderAmount(cost, quantity);

            // Discount Logic
            double discountPercent = 0;
            if (chkEmployee.Checked && quantity > 2) discountPercent = 0.10;
            else if (chkEmployee.Checked && quantity <= 2) discountPercent = 0.08;
            else if (!chkEmployee.Checked && quantity > 4) discountPercent = 0.05;

            double discount = CalcDiscount(orderAmount, discountPercent);
            double total = CalcTotal(orderAmount, discount);

            // Display Amounts
            txtOrderAmount.Text = orderAmount.ToString("C");
            txtDiscount.Text = discount.ToString("C");
            txtTotal.Text = total.ToString("C");

            // Calculate Order Amount
            //   double orderAmount = 0;
            //   if (radioSmall.Checked) orderAmount = 2.0 * quantity;
            //   else if (radioMedium.Checked) orderAmount = 3.0 * quantity;
            //   else if (radioLarge.Checked) orderAmount = 4.0 * quantity;



            // Calculate Discount
            //   bool isEmployee = chkEmployee.Checked;
            //   double discount = 0;
            //   if (isEmployee && quantity > 2) discount = orderAmount * 0.10;
            //   else if (isEmployee && quantity <= 2) discount = orderAmount * 0.08;
            //   else if (!isEmployee && quantity > 4) discount = orderAmount * 0.05;

            // Calculate Total
            //   double total = orderAmount - discount;

            // Display amounts
            //   txtOrderAmount.Text = orderAmount.ToString("C");
            //   txtDiscount.Text = discount.ToString("C");
            //   txtTotal.Text = total.ToString("C");

            //Lucky Number Generator
            Random rnd = new Random();
            int luckyNumber = rnd.Next(1, 51);
            txtMessage.Text += $"Your lucky number is: {luckyNumber}";

            // Display message based on quantity
            switch (quantity)
            {
                case 0:
                    txtMessage.Text = $"Sorry {txtCustomerName.Text}, nothing was ordered {txtMessage.Text}";
                    break;
                case 1:
                    txtMessage.Text = $"{txtCustomerName.Text}, your {drinkType} has arrived! {txtMessage.Text}";
                    break;
                case 2:
                    txtMessage.Text = $"{txtCustomerName.Text}, double {drinkType} is coming quickly! {txtMessage.Text}";
                    break;
                default:
                    txtMessage.Text = $"Beware! {txtCustomerName.Text}, your {quantity} {drinkType}s have surrounded you! {txtMessage.Text}";
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
            comboFlavor.SelectedIndex = -1; // Unselect combo box
        }

        // Button click: Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //Clear Drink Button
        private void btnClearDrink_Click(object sender, EventArgs e)
        {
            lstDrinkType.Items.Clear();
        }

        //Add Coffee Flavor Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboFlavor.Text))
            {
                MessageBox.Show("Please enter a coffee flavor.");
                comboFlavor.Focus();
            }
            else
            {
                comboFlavor.Items.Add(comboFlavor.Text);
                comboFlavor.Text = "";
            }
        
        }
        //Order Amount Method
        private double CalcOrderAmount(double cost, int quantity)
        {
            return cost * quantity;
        }

        //Discount Method
        private double CalcDiscount(double orderAmount, double discountPercent)
        {
            return orderAmount * discountPercent;
        }
        //Total Amount Method
        private double CalcTotal(double orderAmount, double discount)
        {
            return orderAmount - discount;
        }
    }
}
