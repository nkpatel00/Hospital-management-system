using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Department : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        OpenFileDialog OpenFileDialog;
        DataGridViewCellEventArgs es;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";
        string i, d;

        public Department()
        {
            InitializeComponent();
            OpenFileDialog = new OpenFileDialog();
        }

        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        void uploadImage()
        {
            OpenFileDialog.ShowDialog();
            try
            {
                i = OpenFileDialog.FileName.ToString();
                pctimg.Load(i); // loading image in pctimg box
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while loading image : " + e.Message);
            }
        }

        private void btnREgister_Click(object sender, EventArgs e)
        {
            connection();

            if (btnREgister.Text == "Register")
            {
                string imageDirectory = Application.StartupPath + "\\Images\\";

                // Check if the directory exists and create it if it doesn't
                if (!Directory.Exists(imageDirectory))
                {
                    Directory.CreateDirectory(imageDirectory);
                }

                // Ensure the file has an extension
                string extension = Path.GetExtension(OpenFileDialog.FileName);
                if (string.IsNullOrEmpty(extension))
                {
                    extension = ".jpg"; // Default to .jpg if no extension is found
                }

                d = imageDirectory + "Image" + extension; // Use "Image" as the base name
                System.IO.File.Copy(i, d, true);

                cmd = new SqlCommand("INSERT INTO Department(Dept_Name, Dept_Location, Dept_Odate, Dept_Otime, Dept_Contect, Dept_Image) VALUES(@Dept_Name, @Dept_Location, @Dept_Odate, @Dept_Otime, @Dept_Contect, @Dept_Image)", con);
                cmd.Parameters.AddWithValue("@Dept_Name", txtDname.Text);
                cmd.Parameters.AddWithValue("@Dept_Location", txtDlocation.Text);
                cmd.Parameters.AddWithValue("@Dept_Odate", txtOdate.Text);
                cmd.Parameters.AddWithValue("@Dept_Otime", txtOtime.Text);
                cmd.Parameters.AddWithValue("@Dept_Contect", txtDcontect.Text);
                cmd.Parameters.AddWithValue("@Dept_Image", d);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully!");
                fillgrid();
            }
            else
            {
                int id = Convert.ToInt16(dataGridView1.Rows[es.RowIndex].Cells["Dept_Id"].Value);

                cmd = new SqlCommand("UPDATE Department SET Dept_Name = @Dept_Name, Dept_Location = @Dept_Location, Dept_Odate = @Dept_Odate, Dept_Otime = @Dept_Otime, Dept_Contect = @Dept_Contect WHERE Dept_Id = @Dept_Id", con);
                cmd.Parameters.AddWithValue("@Dept_Name", txtDname.Text);
                cmd.Parameters.AddWithValue("@Dept_Location", txtDlocation.Text);
                cmd.Parameters.AddWithValue("@Dept_Odate", txtOdate.Text);
                cmd.Parameters.AddWithValue("@Dept_Otime", txtOtime.Text);
                cmd.Parameters.AddWithValue("@Dept_Contect", txtDcontect.Text);
                cmd.Parameters.AddWithValue("@Dept_Id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully!");
                fillgrid();
            }
        }

        void fillgrid()
        {
            connection();
            da = new SqlDataAdapter("SELECT Dept_Id, Dept_Name, Dept_Location, Dept_Odate, Dept_Otime, Dept_Contect, Dept_Image FROM Department", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;
        }

        private void Department_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uploadImage();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure row and column indices are valid to avoid NullReferenceException
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Ignore clicks on the header or invalid cells
            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                es = e;

                btnREgister.Text = "Update";

                connection();

                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Dept_Id"].Value);

                string name = dataGridView1.Rows[e.RowIndex].Cells["Dept_Name"].Value?.ToString() ?? "";
                string location = dataGridView1.Rows[e.RowIndex].Cells["Dept_Location"].Value?.ToString() ?? "";
                string date = dataGridView1.Rows[e.RowIndex].Cells["Dept_Odate"].Value?.ToString() ?? "";
                string time = dataGridView1.Rows[e.RowIndex].Cells["Dept_Otime"].Value?.ToString() ?? "";
                string contect = dataGridView1.Rows[e.RowIndex].Cells["Dept_Contect"].Value?.ToString() ?? "";

                txtDname.Text = name;
                txtDlocation.Text = location;
                txtOdate.Text = date;
                txtOtime.Text = time;
                txtDcontect.Text = contect;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                connection();
                int id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Dept_Id"].Value);
                cmd = new SqlCommand("DELETE FROM Department WHERE Dept_Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
                fillgrid();
            }
        }
    }
}
