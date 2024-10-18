using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_management_system
{
    public partial class Pharmasy : Form
    {
        public Pharmasy()
        {
            InitializeComponent();
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the form
                int mid = int.Parse(txtmid.Text); // Convert to int for Patient_Id
                String mname = txtmname.Text;
                String sname = txtsname.Text;
                String qty = txtqty.Text;
                String prize = txtunitpriz.Text;
                String expire = txtexpire.Text;
                String manufacture = txtmanufacture.Text;
                String Total = txttotal.Text;

                // Define the connection string (ensure the database path is correct)
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True");

                // Define the SQL command with parameters
                SqlCommand cmd = new SqlCommand("INSERT INTO Pharmasy (Phar_Id, Phar_Pname, Phar_Sname, Phar_Oty, Phar_Uprize, Phar_Expire,Phar_Manufacture,Phar_Total) VALUES (@mid, @mname, @sname, @qty ,@prize, @expire, @manufacture, @Total)", con);

                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@prize", prize);
                cmd.Parameters.AddWithValue("@expire", expire);
                cmd.Parameters.AddWithValue("@manufacture", manufacture);
                cmd.Parameters.AddWithValue("@Total", Total);

                // Open the connection, execute the command, and close the connection
                con.Open();
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

            txtmid.Clear();
            txtmname.Clear();
            txtsname.Clear();
            txtqty.Clear();
            txtunitpriz.Clear();
            txtexpire.Clear();
            txtmanufacture.Clear();
            txttotal.Clear();
        }
    }
}
