using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Hospital_management_system
{
    public partial class Pharmasy : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";


        public Pharmasy()
        {
            InitializeComponent();
        }

        // Connection method
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Pharmasy_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        // Add or update medicine record
        private void txtadd_Click(object sender, EventArgs e)
        {
            connection();

            try
            {
                // Retrieve values from the form (no need to retrieve the Phar_Id, as it's an identity column)
                String mname = txtmname.Text;
                String sname = txtsname.Text;
                String qty = txtqty.Text;
                String prize = txtunitpriz.Text;
                String expire = txtexpire.Text;
                String manufacture = txtmanufacture.Text;
                String Total = txttotal.Text;

                

                // Define the SQL command with parameters, excluding Phar_Id
                SqlCommand cmd = new SqlCommand("INSERT INTO Pharmasy (Phar_Pname, Phar_Sname, Phar_Oty, Phar_Uprize, Phar_Expire, Phar_Manufacture, Phar_Total) VALUES (@mname, @sname, @qty ,@prize, @expire, @manufacture, @Total)", con);

                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@prize", prize);
                cmd.Parameters.AddWithValue("@expire", expire);
                cmd.Parameters.AddWithValue("@manufacture", manufacture);
                cmd.Parameters.AddWithValue("@Total", Total);

                // Open the connection, execute the command, and close the connection
                //con.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Use ExecuteNonQuery for insert/update/delete

                // Check if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Data insertion failed!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                // Show detailed error message
                MessageBox.Show("Error: " + ex.Message);
            }

            // Clear the input fields after insertion

            txtmname.Clear();
            txtsname.Clear();
            txtqty.Clear();
            txtunitpriz.Clear();
            txtexpire.Clear();
            txtmanufacture.Clear();
            txttotal.Clear();
        }


        // Fill the DataGridView with pharmacy records
        // Fill the DataGridView with pharmacy records
        void fillgrid()
        {
            try
            {
                connection(); // Ensure the connection is open

                // SQL query to select records from Pharmasy
                string query = "SELECT Phar_Id, Phar_Pname, Phar_Sname, Phar_Oty, Phar_Uprize, Phar_Expire, Phar_Manufacture, Phar_Total FROM Pharmasy";

                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt); // Fill the DataTable with data from the query

                if (dt.Rows.Count > 0)
                {
                    // Assign the DataTable as the DataSource for the DataGridView
                    dataGridView1.DataSource = dt;

                    // Set column size mode for a better layout
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No records found in the Pharmasy table.");
                }
            }
            catch (Exception ex)
            {
                // If an error occurs, show the exception message for easier debugging
                MessageBox.Show("Error in filling grid: " + ex.Message);
            }
            finally
            {
                // Always close the connection to avoid any resource leak
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        // Handle DataGridView cell click for update and delete operations
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Ignore clicks on headers or invalid cells
            }

            // Update record when Update button is clicked
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                es = e; // Store the selected cell for updating

                txtadd.Text = "Update";

                connection();

                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Phar_Id"].Value);

                txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Pname"].Value?.ToString() ?? "";
                txtsname.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Sname"].Value?.ToString() ?? "";
                txtqty.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Oty"].Value?.ToString() ?? "";
                txtunitpriz.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Uprize"].Value?.ToString() ?? "";
                txtexpire.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Expire"].Value?.ToString() ?? "";
                txtmanufacture.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Manufacture"].Value?.ToString() ?? "";
                txttotal.Text = dataGridView1.Rows[e.RowIndex].Cells["Phar_Total"].Value?.ToString() ?? "";
            }

            // Delete record when Delete button is clicked
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Phar_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Pharmasy WHERE Phar_Id = @Phar_Id", con);
                cmd.Parameters.AddWithValue("@Phar_Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pharmacy record deleted successfully!");
                fillgrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void Pharmasy_Load_1(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}
