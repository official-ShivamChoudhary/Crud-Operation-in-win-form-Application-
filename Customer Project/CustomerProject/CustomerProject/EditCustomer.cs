using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerProject
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";
            string customerId = textId.Text.Trim();
            string customerName = textcustomername.Text.Trim();
            string customerAddress = textcustomeraddress.Text.Trim();
            string customerNumber = textcontactnumber.Text.Trim();

            if (string.IsNullOrEmpty(customerId) || string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(customerAddress) || string.IsNullOrEmpty(customerNumber))
            {
                MessageBox.Show("All fields are required. Please fill in all fields, including Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(customerId, out int parsedCustomerId))
            {
                MessageBox.Show("Invalid Customer ID. Please enter a valid numeric ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(customerName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Customer Name should contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(customerNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit mobile number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Customers SET CustomerName = @customername, CustomerAddress = @customeraddress, CustomerNumber = @customernumber WHERE Id = @customerid";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerid", parsedCustomerId);
                    cmd.Parameters.AddWithValue("@customername", customerName);
                    cmd.Parameters.AddWithValue("@customeraddress", customerAddress);
                    cmd.Parameters.AddWithValue("@customernumber", customerNumber);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textcustomername.Clear();
                        textcustomeraddress.Clear();
                        textcontactnumber.Clear();

                        // Refresh DataGridView to reflect changes
                        LoadCustomerData();

                        // Optionally, set the updated record to appear at the top
                        dataGridView1.Sort(dataGridView1.Columns["Id"], System.ComponentModel.ListSortDirection.Ascending);
                    }
                    else
                    {
                        MessageBox.Show("No matching customer found. Please check the Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Customer newForm = new Customer();
            newForm.Show();
            this.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadCustomerData();
        }




        private void button4_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadCustomerData();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

            string customerIdText = textId.Text.Trim();


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

            textcustomername.Clear();
            textcustomeraddress.Clear();
            textcontactnumber.Clear();


            string connectionString = "Server=SHIVAM;Database=Customerdb;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SearchCustomerById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            textcustomername.Text = reader["CustomerName"]?.ToString() ?? "";
                            textcustomeraddress.Text = reader["CustomerAddress"]?.ToString() ?? "";
                            textcontactnumber.Text = reader["CustomerNumber"]?.ToString() ?? "";
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textcontactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

    }
}
