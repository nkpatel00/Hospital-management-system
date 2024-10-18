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
    public partial class Staffform : Form
    {
        public Staffform()
        {
            InitializeComponent();
        }

        private void Staffform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the form
                int sid = int.Parse(txtsid.Text); // Convert to int for Patient_Id
                String fname = txtfname.Text;
                String lname = txtlname.Text;
                String email = txtmail.Text;
                String mobile = txtmobile.Text;
                String role = Comborole.Text;
                String gender = combogender.Text;
                String address = txtadd.Text;

                // Define the connection string (ensure the database path is correct)
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True");

                // Define the SQL command with parameters
                SqlCommand cmd = new SqlCommand("INSERT INTO Staff (Staff_Id, Staff_Fname, Staff_Lname, Staff_Email, Staff_Mobile, Staff_Role, Staff_Gender, Staff_Address) VALUES (@sid, @fname, @lname, @Email, @Mobile, @role, @Gender, @Address)", con);

                // Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address);

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

            txtsid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtmail.Clear();
            txtmobile.Clear();
            Comborole.Text = string.Empty;
            combogender.Text = string.Empty;
            txtadd.Clear();
        }
    }
}
