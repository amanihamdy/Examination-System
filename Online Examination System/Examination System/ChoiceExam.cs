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
    public partial class ChoiceExam : Form
    {

        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int instid;

        public ChoiceExam(int insid)
        {
            InitializeComponent();

            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select * from Course c, Ins_Course_Teach i where c.Crs_ID=i.Crs_ID and Ins_ID={insid}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);

            comcrsname.DataSource = dt;
            comcrsname.DisplayMember = "Crs_Name";
            comcrsname.ValueMember = "Crs_ID";

            
            SqlCN.Close();
            instid = insid;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            showexam showexam = new showexam(instid,int.Parse(comcrsname.SelectedValue.ToString()));
            showexam.Show();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Home form=new Instructor_Home(instid);
            form.Show();
        }
    }
}
