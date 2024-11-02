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
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        OpenFileDialog OpenFileDialog;
        DataGridViewCellEventArgs es;

      //  String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kaushik\source\repos\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

       // void connection()
       // {
       //     con = new SqlConnection(s);
        //    con.Open();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
              String username = txtusr.Text;
              String password = txtpass.Text;

              if (username == "user" && password == "12345")
              {
                  this.Hide();
                  Dashboard ds = new Dashboard();
                  ds.Show();
              }
              else
              {
                  MessageBox.Show("Wrong username or password !!!");
              }
              
/*
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Admin values('"+txtusr.Text+"','"+txtpass.Text+"',)";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully!!"); */
        }
    }
}
