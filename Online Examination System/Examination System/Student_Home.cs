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
    public partial class Student_Home : Form
    {
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        public Student_Home(string stid )
        {
            InitializeComponent();
            std_id = stid;
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select * from Course c, Student s , Stud_Course sc where c.Crs_ID=sc.Crs_ID and sc.Stud_ID=s.National_ID and National_ID={stid}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Crs_Name";
            comboBox1.ValueMember = "Crs_ID";
           

            SqlCN.Close();




        }
        string std_id;
        int crid;

        private void button1_Click(object sender, EventArgs e)
        {
            crid = int.Parse(comboBox1.SelectedValue.ToString());

            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            // sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select * from  Stud_Course where Crs_ID={crid} and Stud_ID={std_id}";
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);

            string totalgrade =dt.Rows[0]["Total_Grade"].ToString();
            this.Text = totalgrade;
            SqlCN.Close();
            if (string.IsNullOrEmpty(totalgrade))
            {
               
                object R;

                SqlCN = new SqlConnection();

                SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                    "Integrated Security = true ; TrustServerCertificate=true";

                sqlCmd = new SqlCommand();
                SqlCN.Open();
                // sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = SqlCN;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT TOP(1)Exam_ID FROM Exam WHERE Crs_ID={crid} ORDER BY  Exam_ID DESC";
                R = sqlCmd.ExecuteScalar();
                
                string s = R.ToString();
                int exid = int.Parse(s);
                SqlCN.Close();
                this.Hide();
                Exam exam = new Exam(std_id, exid);
                exam.Show();
            }
            else
            {
                lblerroe.Text = "YOU ALREADY TAKE THIS EXAM";
            }
            SqlCN.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Login form = new Student_Login();
            form.Show();
        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            this.Hide();
            showgrade form = new showgrade(std_id);
            form.Show();

        }

        private void Student_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
