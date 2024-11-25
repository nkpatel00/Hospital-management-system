using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Hospital_management_system
{
    public partial class frmReport : Form
    {
        public frmReport(string RptType)
        {
            InitializeComponent();
            Report = RptType;
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Hospital management system\Hospital management system\HMS_DB.mdf;Integrated Security=True";
        string Report;
        string cryPath = "" ;
        string xml = "" ;
        private ReportDocument cr = new ReportDocument();

        private void connection()
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }


        private void loadReport()
        {
            connection();
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string rqry ="";

            //switch case for loading different reports
            switch(Report)
            {
                case "Paient":
                    rqry = "select * from Patient";
                    cryPath = @"E:/Hospital management system/Hospital management system/Pateint_repo.rpt";
                    xml = @"E:/Hospital management system/Hospital management system/data.xml";
                    break;

                case "Ward":
                    rqry = "select * from Ward";
                    cryPath = @"E:/Hospital management system/Hospital management system/Ward_repo.rpt";
                    xml = @"E:/Hospital management system/Hospital management system/Warddata.xml";
                    break;

                case "Staff":
                    rqry = "select * from Staff";
                    cryPath = @"E:/Hospital management system/Hospital management system/Staff_repo.rpt";
                    xml = @"E:/Hospital management system/Hospital management system/Staffdata.xml";
                    break;
            }

            da = new SqlDataAdapter(rqry, con);
            da.Fill(ds);


            //generating xml schema and data file
            ds.WriteXmlSchema(xml);

            //load report
            cr.Load(cryPath);
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            connection();  // Open database connection
            loadReport();  // Load the report data
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}