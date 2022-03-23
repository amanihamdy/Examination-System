using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class showgrade : Form
    {
        string Studid;
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        public showgrade(string stdid)
        {
            InitializeComponent();
            Studid=stdid;

            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select Crs_Name,Total_Grade from Stud_Course sc ,Course c where c.Crs_ID =sc.Crs_ID and Stud_ID={stdid}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
     

            SqlCN.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Home form = new Student_Home(Studid);
            form.Show();
        }
    }
}
