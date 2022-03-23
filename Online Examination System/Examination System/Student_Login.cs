using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Examination_System
{
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;

        private void btnSignUpStud_Click(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                         "Integrated Security = true ; TrustServerCertificate=true";

            if(string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                lblerror.Visible = true;
                lblerror.Text = "please enter Email and Password";
            }
            else { 

            SqlCommand cmd = new SqlCommand("select Email, Password, National_ID from Student S where Email=@UserName and Password =@Password", SqlCN);




            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            //SqlCN.Open();
            //int i = cmd.ExecuteNonQuery();
            //SqlCN.Close();

           
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                this.Hide();
                Student_Home form = new Student_Home(dr["National_ID"].ToString());
                form.Show();

            }
            else
            {
                    lblerror.Visible = true;
                lblerror.Text="Please enter Correct Username and Password";
            }
            }

        }

        private void Student_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.Show();
        }
    }
}
