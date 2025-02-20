using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProject
{
    public partial class Searchbar : Form
    {
        public Searchbar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the search input from the textbox
            string customerName = textcustomername.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter a customer name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SearchCustomerByName", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind result to DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer newForm = new Customer();
            newForm.Show();
            this.Close();
        }



        private void Searchbar_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT Id, CustomerName, CustomerAddress, CustomerNumber FROM Customers";  // Correct column name

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind data to DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }


    }
}
