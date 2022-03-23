using Microsoft.Data.SqlClient;
using System.Data;

namespace Examination_System
{
    public partial class Form1 : Form
    {
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int instid;
        public Form1(int insid)
        {
            InitializeComponent();
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select Crs_Name from Course c, Ins_Course_Teach i where c.Crs_ID=i.Crs_ID and Ins_ID={insid}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            comcrsname.DataSource = dt;
            comcrsname.DisplayMember = "Crs_Name";
            comcrsname.ValueMember = "Crs_Name";

            SqlCN.Close();
            instid = insid;

        }
        object R;
        int id;
        private void btngenerate_Click(object sender, EventArgs e)
        {
            #region 

            string crsname = comcrsname.SelectedValue.ToString();

            int numoftf = (int)numtf.Value;
            int numofmcq = (int)nummcq.Value;

            if ((numoftf + numofmcq == 10))
            {
                lblerror.Text = "";
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = SqlCN;

                sqlCmd.CommandText = "generate_exam";
                SqlCN.Open();


                sqlCmd.Parameters.Add(new SqlParameter("crs_name", crsname));
                sqlCmd.Parameters.Add(new SqlParameter("N_TF", numoftf));
                sqlCmd.Parameters.Add(new SqlParameter("N_MCQ", numofmcq));

                sqlCmd.ExecuteNonQuery();
                this.Text = crsname;
                lblerror.Text = "Exam Generated";


                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select IDENT_CURRENT('Exam')";
                R = sqlCmd.ExecuteScalar();
                btnshow.Visible = true;
                string s = R.ToString();
                id = int.Parse(s);
                SqlCN.Close();
            }
            else
            {
                lblerror.Text = "Total number of questions must be 10";
            }
            #endregion

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(instid, id, -1, 0);
            form.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Home form = new Instructor_Home(instid);
            form.Show();

        }
    }
}