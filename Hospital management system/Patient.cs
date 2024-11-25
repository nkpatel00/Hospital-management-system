using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

using CrystalDecisions.Shared;


namespace Hospital_management_system
{
    public partial class Patient : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";

        public Patient()
        {
            InitializeComponent();
        }

        // Connection method
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            fillgrid();  // Fill the grid when form loads
        }

        // Add or update patient record
        private void btnregister_Click(object sender, EventArgs e)
        {
            connection();

            if (btnregister.Text == "Register")
            {
                // Add new patient record
                cmd = new SqlCommand("INSERT INTO Patient (Patient_Fname, Patient_Lname, Patient_Email, Patient_Mobile, Patient_Age, Patient_DOB, Patient_Gender, Patient_Address) VALUES (@Patient_Fname, @Patient_Lname, @Patient_Email, @Patient_Mobile, @Patient_Age, @Patient_DOB, @Patient_Gender, @Patient_Address)", con);
                cmd.Parameters.AddWithValue("@Patient_Fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@Patient_Lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Patient_Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Patient_Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", txtage.Text);
                cmd.Parameters.AddWithValue("@Patient_DOB", txtdob.Text);
                cmd.Parameters.AddWithValue("@Patient_Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Patient_Address", txtadd.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient record inserted successfully!");
                fillgrid(); // Refresh the grid after adding
            }
            else
            {
                if (es == null)
                {
                    MessageBox.Show("Please select a record to update from the grid.");
                    return;
                }

                // Update the selected patient record
                int id = Convert.ToInt16(dataGridView1.Rows[es.RowIndex].Cells["Patient_Id"].Value);

                cmd = new SqlCommand("UPDATE Patient SET Patient_Fname = @Patient_Fname, Patient_Lname = @Patient_Lname, Patient_Email = @Patient_Email, Patient_Mobile = @Patient_Mobile, Patient_Age = @Patient_Age, Patient_DOB = @Patient_DOB, Patient_Gender = @Patient_Gender, Patient_Address = @Patient_Address WHERE Patient_Id = @Patient_Id", con);
                cmd.Parameters.AddWithValue("@Patient_Fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@Patient_Lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@Patient_Email", txtmail.Text);
                cmd.Parameters.AddWithValue("@Patient_Mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", txtage.Text);
                cmd.Parameters.AddWithValue("@Patient_DOB", txtdob.Text);
                cmd.Parameters.AddWithValue("@Patient_Gender", combogender.Text);
                cmd.Parameters.AddWithValue("@Patient_Address", txtadd.Text);
                cmd.Parameters.AddWithValue("@Patient_Id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient record updated successfully!");
                fillgrid(); // Refresh the grid after updating
            }
        }

        // Fill the grid with patient records
        void fillgrid()
        {
            connection();
            da = new SqlDataAdapter("SELECT Patient_Id, Patient_Fname, Patient_Lname, Patient_Email, Patient_Mobile, Patient_Age, Patient_DOB, Patient_Gender, Patient_Address FROM Patient", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        // Handle grid cell clicks for Update and Delete
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

                btnregister.Text = "Update";  // Change button text to indicate update mode

                connection();

                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Patient_Id"].Value);

                txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Fname"].Value?.ToString() ?? "";
                txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Lname"].Value?.ToString() ?? "";
                txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Email"].Value?.ToString() ?? "";
                txtmobile.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Mobile"].Value?.ToString() ?? "";
                txtage.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Age"].Value?.ToString() ?? "";
                txtdob.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_DOB"].Value?.ToString() ?? "";
                combogender.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Gender"].Value?.ToString() ?? "";
                txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells["Patient_Address"].Value?.ToString() ?? "";
            }

            // Handle Delete button click
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Patient_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Patient WHERE Patient_Id = @Patient_Id", con);
                cmd.Parameters.AddWithValue("@Patient_Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient record deleted successfully!");
                fillgrid();  // Refresh the grid after deleting
            }
        }


        //Butt for generating crystal report
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //da = new SqlDataAdapter("select * from Patient", con);
            //ds = new DataSet();
            //da.Fill(ds);
            //string xml = @" E:/Hospital management system/Hospital management system/data.xml";
            //ds.WriteXmlSchema(xml);

            string RptType = "Paient";

            frmReport frm = new frmReport(RptType);
            frm.Show();

        }

        private void pateint_repo1_InitReport(object sender, EventArgs e)
        {
            

        }

        private void crystalReport11_InitReport(object sender, EventArgs e)
        {
            
        }
    }
}
