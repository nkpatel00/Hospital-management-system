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
    public partial class Dashboardform : Form
    {
        public Dashboardform()
        {
            InitializeComponent();
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel3.ForeColor = System.Drawing.Color.Black;
            panel4.ForeColor = System.Drawing.Color.Black;
            panel2.ForeColor = System.Drawing.Color.Black;
            panel1.ForeColor = System.Drawing.Color.Blue;



            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel3.ForeColor = System.Drawing.Color.Black;
            panel4.ForeColor = System.Drawing.Color.Black;
            panel2.ForeColor = System.Drawing.Color.Blue;
            panel1.ForeColor = System.Drawing.Color.Black;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel3.ForeColor = System.Drawing.Color.Black;
            panel4.ForeColor = System.Drawing.Color.Blue;
            panel2.ForeColor = System.Drawing.Color.Black;
            panel1.ForeColor = System.Drawing.Color.Black;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel3.ForeColor = System.Drawing.Color.Blue;
            panel4.ForeColor = System.Drawing.Color.Black;
            panel2.ForeColor = System.Drawing.Color.Black;
            panel1.ForeColor = System.Drawing.Color.Black;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
