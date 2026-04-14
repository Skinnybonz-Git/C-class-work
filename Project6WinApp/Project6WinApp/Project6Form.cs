using System;
using System.Windows.Forms;

namespace Project6WinApp
{
    public partial class Project6Form : Form
    {
        // 0 = Sunday ... 6 = Saturday
        private double[] drinkSales = new double[7];
        private double[] foodSales = new double[7];
        public Project6Form()
        {
            InitializeComponent();
            this.CancelButton = btnExit;

            
        }
        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            if (cmbEntryDay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a day of the week.");
                cmbEntryDay.Focus();
                return;
            }

            if (!double.TryParse(txtDrinkSales.Text, out double drink))
            {
                MessageBox.Show("Please enter a valid drink sales amount.");
                txtDrinkSales.Focus();
                return;
            }

            if (!double.TryParse(txtFoodSales.Text, out double food))
            {
                MessageBox.Show("Please enter a valid food sales amount.");
                txtFoodSales.Focus();
                return;
            }

            int index = cmbEntryDay.SelectedIndex;

            drinkSales[index] = drink;
            foodSales[index] = food;

            MessageBox.Show("Sales values have been saved.");

            txtDrinkSales.Clear();
            txtFoodSales.Clear();
            cmbEntryDay.SelectedIndex = -1;
        }

        // Lookup Sales
        private void btnLookupSales_Click(object sender, EventArgs e)
        {
            if (cmbLookupDay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a day of the week.");
                cmbLookupDay.Focus();
                return;
            }

            int index = cmbLookupDay.SelectedIndex;

            string day = cmbLookupDay.SelectedItem.ToString();
            double drink = drinkSales[index];
            double food = foodSales[index];

            MessageBox.Show($"For {day} the drink sales are ${drink} and food sales are ${food}");

            cmbLookupDay.SelectedIndex = -1;
        }

        // Calculations
        private double CalculateDrinkTotal()
        {
            double total = 0;

            foreach (double d in drinkSales)
                total += d;

            return total;
        }

        private double CalculateFoodTotal()
        {
            double total = 0;

            foreach (double f in foodSales)
                total += f;

            return total;
        }

        // Display Report
        private void btnDisplayAmount_Click(object sender, EventArgs e)
        {
            if (rbWeeklyDrink.Checked)
            {
                double total = CalculateDrinkTotal();
                MessageBox.Show($"Weekly drink total is ${total}");
                rbWeeklyDrink.Checked = false;
            }
            else if (rbWeeklyFood.Checked)
            {
                double total = CalculateFoodTotal();
                MessageBox.Show($"Weekly food total is ${total}");
                rbWeeklyFood.Checked = false;
            }
            else if (rbWeeklyOverall.Checked)
            {
                double total = CalculateDrinkTotal() + CalculateFoodTotal();
                MessageBox.Show($"Weekly overall total is ${total}");
                rbWeeklyOverall.Checked = false;
            }
            else
            {
                MessageBox.Show("Please select a report to show.");
            }
        }


        // Clear All Sales
        private void btnClearAllSales_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drinkSales.Length; i++)
            {
                drinkSales[i] = 0;
                foodSales[i] = 0;
            }

            MessageBox.Show("All sales have been cleared.");
        }

        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
