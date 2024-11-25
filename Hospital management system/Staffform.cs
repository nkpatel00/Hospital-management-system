using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Staffform : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";

        public Staffform()
        {
            InitializeComponent();
        }

        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Staffform_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            connection();

            if (btnregister.Text == "Register")
            {
                // Register a new staff member
                cmd = new SqlCommand("INSERT INTO Staff (Staff_Fname, Staff_Lname, Staff_Email, Staff_Mobile, Staff_Role, Staff_Gender, Staff_Address) VALUES (@fname, @lname, @Email, @Mobile, @role, @Gender, @Address)", con);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@role", Comborole.Text);
                cmd.Parameters.AddWithValue("@Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Address", txtadd.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff record inserted successfully!");
                fillgrid();

                // Reset the form for new entry
                btnregister.Text = "Add";
                es = null;
            }
            else
            {
                if (es == null)
                {
                    MessageBox.Show("Please select a record to update from the grid.");
                    return;
                }

                // Update the selected staff record
                int id = Convert.ToInt16(dataGridView1.Rows[es.RowIndex].Cells["Staff_Id"].Value);

                cmd = new SqlCommand("UPDATE Staff SET Staff_Fname = @fname, Staff_Lname = @lname, Staff_Email = @Email, Staff_Mobile = @Mobile, Staff_Role = @role, Staff_Gender = @Gender, Staff_Address = @Address WHERE Staff_Id = @Staff_Id", con);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@role", Comborole.Text);
                cmd.Parameters.AddWithValue("@Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Address", txtadd.Text);
                cmd.Parameters.AddWithValue("@Staff_Id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff record updated successfully!");
                fillgrid();

                // Reset the form for new entry
                btnregister.Text = "Add";
                es = null;
            }
        }

        void fillgrid()
        {
            connection();
            da = new SqlDataAdapter("SELECT Staff_Id, Staff_Fname, Staff_Lname, Staff_Email, Staff_Mobile, Staff_Role, Staff_Gender, Staff_Address FROM Staff", con);
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

                btnregister.Text = "Update";

                connection();

                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Staff_Id"].Value);

                txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Fname"].Value?.ToString() ?? "";
                txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Lname"].Value?.ToString() ?? "";
                txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Email"].Value?.ToString() ?? "";
                txtmobile.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Mobile"].Value?.ToString() ?? "";
                Comborole.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Role"].Value?.ToString() ?? "";
                combogender.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Gender"].Value?.ToString() ?? "";
                txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells["Staff_Address"].Value?.ToString() ?? "";
            }

            // Handle Delete button click
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Staff_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Staff WHERE Staff_Id = @Staff_Id", con);
                cmd.Parameters.AddWithValue("@Staff_Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff record deleted successfully!");
                fillgrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //da = new SqlDataAdapter("select * from Staff", con);
            //ds = new DataSet();
            //da.Fill(ds);
            //string xml = @" E:/Hospital management system/Hospital management system/Staffdata.xml";
            //ds.WriteXmlSchema(xml);

            string RptType = "Staff";

            frmReport frm = new frmReport(RptType);
            frm.Show();
        }
    }
}
