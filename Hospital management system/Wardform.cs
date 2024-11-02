using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Wardform : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";

        public Wardform()
        {
            InitializeComponent();
        }

        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Wardform_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            connection();

            if (btnregister.Text == "Add")
            {
                // Insert a new ward record
                cmd = new SqlCommand("INSERT INTO Ward ( Ward_Name, Ward_Doc, Ward_Nurs, Ward_Patient, Ward_Charge) VALUES ( @wname, @nodoc, @nonurs, @nopat, @charge)", con);
                
                cmd.Parameters.AddWithValue("@wname", txtwname.Text);
                cmd.Parameters.AddWithValue("@nodoc", txtnumdoc.Text);
                cmd.Parameters.AddWithValue("@nonurs", txtnumnurs.Text);
                cmd.Parameters.AddWithValue("@nopat", txtnumpat.Text);
                cmd.Parameters.AddWithValue("@charge", txtcharge.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ward record inserted successfully!");
                fillgrid();
            }
            else
            {
                if (es == null)
                {
                    MessageBox.Show("Please select a record to update from the grid.");
                    return;
                }

                // Update the selected ward record
                int id = Convert.ToInt32(dataGridView1.Rows[es.RowIndex].Cells["Ward_Id"].Value);
                cmd = new SqlCommand("UPDATE Ward SET Ward_Name = @wname, Ward_Doc = @nodoc, Ward_Nurs = @nonurs, Ward_Patient = @nopat, Ward_Charge = @charge WHERE Ward_Id = @wid", con);
                cmd.Parameters.AddWithValue("@wid", id);
                cmd.Parameters.AddWithValue("@wname", txtwname.Text);
                cmd.Parameters.AddWithValue("@nodoc", txtnumdoc.Text);
                cmd.Parameters.AddWithValue("@nonurs", txtnumnurs.Text);
                cmd.Parameters.AddWithValue("@nopat", txtnumpat.Text);
                cmd.Parameters.AddWithValue("@charge", txtcharge.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ward record updated successfully!");
                fillgrid();
            }

            clearFields();
        }

        void fillgrid()
        {
            connection();
            da = new SqlDataAdapter("SELECT Ward_Id, Ward_Name, Ward_Doc, Ward_Nurs, Ward_Patient, Ward_Charge FROM Ward", con);
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

                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Ward_Id"].Value);

                    
                txtwname.Text = dataGridView1.Rows[e.RowIndex].Cells["Ward_Name"].Value?.ToString() ?? "";
                txtnumdoc.Text = dataGridView1.Rows[e.RowIndex].Cells["Ward_Doc"].Value?.ToString() ?? "";
                txtnumnurs.Text = dataGridView1.Rows[e.RowIndex].Cells["Ward_Nurs"].Value?.ToString() ?? "";
                txtnumpat.Text = dataGridView1.Rows[e.RowIndex].Cells["Ward_Patient"].Value?.ToString() ?? "";
                txtcharge.Text = dataGridView1.Rows[e.RowIndex].Cells["Ward_Charge"].Value?.ToString() ?? "";
            }

            // Handle Delete button click
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Ward_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Ward WHERE Ward_Id = @wid", con);
                cmd.Parameters.AddWithValue("@wid", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ward record deleted successfully!");
                fillgrid();
            }
        }

        private void clearFields()
        {
                
            txtwname.Clear();
            txtnumdoc.Clear();
            txtnumnurs.Clear();
            txtnumpat.Clear();
            txtcharge.Clear();
            btnregister.Text = "Add";
            es = null;
        }
    }
}
