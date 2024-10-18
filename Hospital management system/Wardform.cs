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
    public partial class Wardform : Form
    {
        public Wardform()
        {
            InitializeComponent();
        }

        private void Wardform_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the form
                int wid = int.Parse(txtwid.Text); // Convert to int for Patient_Id
                String wname = txtwname.Text;
                String nodoc = txtnumdoc.Text;
                String nonurs = txtnumnurs.Text;
                String nopat = txtnumpat.Text;
                String charge = txtcharge.Text;

                // Define the connection string (ensure the database path is correct)
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True");

                // Define the SQL command with parameters
                SqlCommand cmd = new SqlCommand("INSERT INTO Ward (Ward_Id, Ward_Name, Ward_Doc, Ward_Nurs, Ward_Patient, Ward_Charge) VALUES (@wid, @wname, @nodoc, @nonurs ,@nopat , @charge)", con);

                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@wid", wid);
                cmd.Parameters.AddWithValue("@wname", wname);
                cmd.Parameters.AddWithValue("@nodoc", nodoc);
                cmd.Parameters.AddWithValue("@nonurs", nonurs);
                cmd.Parameters.AddWithValue("@nopat", nopat);
                cmd.Parameters.AddWithValue("@charge", charge);

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


            txtwid.Clear();
            txtwname.Clear();
            txtnumdoc.Clear();
            txtnumdoc.Clear();
            txtnumpat.Clear();
            txtcharge.Clear();
        }
    }
}
