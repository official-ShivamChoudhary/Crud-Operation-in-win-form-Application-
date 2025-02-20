using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerProject
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Customer newForm = new Customer();
            newForm.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";
            string customerId = textBox1.Text.Trim();

            // Check if the Customer ID is provided
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Please enter a Customer ID to delete the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the input is numeric
            if (!int.TryParse(customerId, out int parsedCustomerId))
            {
                MessageBox.Show("Invalid Customer ID. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            // Query to delete the customer record
            string query = "DELETE FROM Customers WHERE Id = @customerid";

            try
            {
                // Open SQL connection and execute the delete query
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerid", parsedCustomerId);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear fields after successful deletion
                            textname.Clear();
                            textaddress.Clear();
                            textnumber.Clear();
                            // Refresh the DataGridView after deletion
                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("No matching customer found. Please check the Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }


        private int pageNumber = 1;
        private int pageSize = 5;

        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    string query = @"
                    WITH CTE AS (
                        SELECT Id, CustomerName, CustomerAddress, CustomerNumber,
                               ROW_NUMBER() OVER (ORDER BY Id Asc) AS RowNum
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

        private void button3_Click_1(object sender, EventArgs e)
        {

            string customerIdText = textBox1.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(customerIdText))
            {
                MessageBox.Show("Please enter a Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(customerIdText, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID. Please enter a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SearchCustomerById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            textname.Text = reader["CustomerName"] != DBNull.Value ? reader["CustomerName"].ToString() : "";
                            textaddress.Text = reader["CustomerAddress"] != DBNull.Value ? reader["CustomerAddress"].ToString() : "";
                            textnumber.Text = reader["CustomerNumber"] != DBNull.Value ? reader["CustomerNumber"].ToString() : "";
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textname.Clear();
                            textaddress.Clear();
                            textnumber.Clear();
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadCustomerData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadCustomerData();
        }



    }
}
