using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadform(new Dashboardform());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(Form f)
        {
            mainP.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainP.Controls.Add(f);
            f.Show();
      
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loadform(new Staffform());
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            loadform(new Wardform());
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            loadform(new Department());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            loadform(new Patient());
        }

        private void mainP_Paint(object sender, PaintEventArgs e)
        {
            loadform(new Patient());
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            loadform(new Doctor());
        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadform(new Dashboardform());
        }

        private void btnPharmasy_Click(object sender, EventArgs e)
        {
            loadform(new Pharmasy());
        }
    }
}
