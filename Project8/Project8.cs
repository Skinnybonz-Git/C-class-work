using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormProject8
{
    public partial class Project8 : Form
    {//points to database location
        DataTable productTable = new DataTable();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\ProductDB.mdf;
Integrated Security=True;
Encrypt=False;";
        public Project8()
        {
            InitializeComponent();
        }
        //runs these methods one after other
        private void Project8_Load(object sender, EventArgs e)
        {
            LoadProducts();
            BindListBox();
        }
        //pulls data to listbox from the database
        private void LoadProducts()
        {
            productTable.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(productTable);
            }
        }
        // populates display with  product_number column info
        private void BindListBox()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = productTable;
            lstProducts.DisplayMember = "Product_Number";
        }
        // takes info from rest of selected product key row and links it to proper lbls/txt
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem is DataRowView row)
            {
                lblDescriptionOutcome.Text = row["Description"].ToString();
                lblUnitsOutcome.Text = row["Units_On_Hand"].ToString();
                txtPrice.Text = row["Price"].ToString();
            }
        }
        // exits when button clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}