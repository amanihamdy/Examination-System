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
    public partial class showexam : Form
    {
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int instid;
        int idcrs;
        public showexam(int insid ,int crsid)
        {
            InitializeComponent();

            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select * from Exam where Crs_ID ={crsid}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
            comexamid.DataSource = dt;
            comexamid.DisplayMember = "Exam_ID";
            comexamid.ValueMember = "Exam_ID";


            SqlCN.Close();
            instid = insid;
            idcrs = crsid;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(instid,int.Parse(comexamid.SelectedValue.ToString()),idcrs,1);
            form.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoiceExam form = new ChoiceExam(instid);
            form.Show();
        }
    }
}
