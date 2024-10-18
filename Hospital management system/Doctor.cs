using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Doctor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";

        public Doctor()
        {
            InitializeComponent();
        }

        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            connection();

            if (btnadd.Text == "Add")
            {
                // Register a new doctor
                cmd = new SqlCommand("INSERT INTO Doctor (Doctor_Fname, Doctor_Lname, Doctor_Email, Doctor_Mobile, Doctor_Gender, Doctor_Specialization) VALUES (@Doctor_Fname, @Doctor_Lname, @Doctor_Email, @Doctor_Mobile, @Doctor_Gender, @Doctor_Specialization)", con);
                cmd.Parameters.AddWithValue("@Doctor_Fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@Doctor_Lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Doctor_Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Doctor_Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@Doctor_Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Doctor_Specialization", combospecial.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor record inserted successfully!");
                fillgrid();
            }
            else
            {
                if (es == null)
                {
                    MessageBox.Show("Please select a record to update from the grid.");
                    return;
                }

                // Update the selected doctor record
                int id = Convert.ToInt16(dataGridView1.Rows[es.RowIndex].Cells["Doctor_Id"].Value);

                cmd = new SqlCommand("UPDATE Doctor SET Doctor_Fname = @Doctor_Fname, Doctor_Lname = @Doctor_Lname, Doctor_Email = @Doctor_Email, Doctor_Mobile = @Doctor_Mobile, Doctor_Gender = @Doctor_Gender, Doctor_Specialization = @Doctor_Specialization WHERE Doctor_Id = @Doctor_Id", con);
                cmd.Parameters.AddWithValue("@Doctor_Fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@Doctor_Lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Doctor_Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Doctor_Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@Doctor_Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Doctor_Specialization", combospecial.Text);
                cmd.Parameters.AddWithValue("@Doctor_Id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor record updated successfully!");
                fillgrid();
            }
        }

        void fillgrid()
        {
            connection();
            da = new SqlDataAdapter("SELECT Doctor_Id, Doctor_Fname, Doctor_Lname, Doctor_Email, Doctor_Mobile, Doctor_Gender, Doctor_Specialization FROM Doctor", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Ignore clicks on headers or invalid cells
            }

            // Handle Update button click
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                es = e; // Store event for use in update

                btnadd.Text = "Update";

                connection();

                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Doctor_Id"].Value);

                txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Fname"].Value?.ToString() ?? "";
                txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Lname"].Value?.ToString() ?? "";
                txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Email"].Value?.ToString() ?? "";
                txtmobile.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Mobile"].Value?.ToString() ?? "";
                combogender.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Gender"].Value?.ToString() ?? "";
                combospecial.Text = dataGridView1.Rows[e.RowIndex].Cells["Doctor_Specialization"].Value?.ToString() ?? "";
            }

            // Handle Delete button click
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Doctor_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Doctor WHERE Doctor_Id = @Doctor_Id", con);
                cmd.Parameters.AddWithValue("@Doctor_Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor record deleted successfully!");
                fillgrid();
            }
        }
    }
}
