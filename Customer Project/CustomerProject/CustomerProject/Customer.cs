using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomerProject
{
    public partial class Customer : Form
    {
        // Pagination 

        private int pageNumber = 1;
        private int pageSize = 5;

        public Customer()
        {
            InitializeComponent();
        }

        // Load customer data when form loads

        private void Customer_Load_1(object sender, EventArgs e)
        {

            LoadCustomerData();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";
            string customerName = textcustomername.Text.Trim();
            string customerAddress = textcustomeraddress.Text.Trim();
            string customerNumber = textcontactnumber.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerAddress) || string.IsNullOrEmpty(customerNumber))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate customerNumber (must be exactly 10 digits and numeric)
            if (customerNumber.Length != 10 || !customerNumber.All(char.IsDigit))
            {
                MessageBox.Show("Customer number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert query
            string query = "INSERT INTO Customers (CustomerName, CustomerAddress, CustomerNumber) VALUES (@customername, @customeraddress, @customernumber)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customername", customerName);
                        cmd.Parameters.AddWithValue("@customeraddress", customerAddress);
                        cmd.Parameters.AddWithValue("@customernumber", customerNumber);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh DataGridView to show new record
                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear input fields after successful submission
            textcustomername.Clear();
            textcustomeraddress.Clear();
            textcontactnumber.Clear();
        }



        private void textcontactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }






        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    string query = @"
                        WITH CTE AS (
                            SELECT Id, CustomerName, CustomerAddress, CustomerNumber,
                                   ROW_NUMBER() OVER (ORDER BY Id ASC) AS RowNum
                            FROM Customers
                        )
                        SELECT Id, CustomerName, CustomerAddress, CustomerNumber
                        FROM CTE
                        WHERE RowNum BETWEEN @StartRow AND @EndRow";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int startRow = (pageNumber - 1) * pageSize + 1;
                        int endRow = pageNumber * pageSize;

                        cmd.Parameters.AddWithValue("@StartRow", startRow);
                        cmd.Parameters.AddWithValue("@EndRow", endRow);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            EditCustomer newForm = new EditCustomer();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteCustomer newForm = new DeleteCustomer();
            newForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Searchbar newForm = new Searchbar();
            newForm.Show();
            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)

        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadCustomerData();
            }
        }


        private void button6_Click(object sender, EventArgs e)

        {
            pageNumber++;
            LoadCustomerData();
        }



    }
}
