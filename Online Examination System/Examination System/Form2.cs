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
    public partial class Form2 : Form
    {
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int exid;
        int insid;
        int flag;
        int crsid;
        public Form2(int id,int r,int crs,int f)
        {
            InitializeComponent();
            exid = r;
            insid = id;
            flag = f;
            crsid = crs;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            GroupBox[] groupboxs = new GroupBox[10];
            RadioButton[] radioButtons = new RadioButton[40];

            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;
            SqlCN.Close();
            SqlCN.Open();
            sqlCmd.CommandText = "FormateExam";
            this.Text = exid.ToString();
            sqlCmd.Parameters.Add(new SqlParameter("exid", exid));
          
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            int i = 0;
            int j = 0;
            foreach (DataRow item in dt.Rows)
            {
                groupboxs[i] = new GroupBox();
                groupboxs[i++].Text =item["ques"].ToString();

                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q1"].ToString();
            
                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q2"].ToString();
               
                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q3"].ToString();
              
                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q4"].ToString();
 
            }



            int plbl = 20;
            for (int a = 0; a < 10; a++)
            {
                int prad = 61;

             //   groupboxs[a].AutoSize=true;
                groupboxs[a].Location = new Point(0,plbl);
                groupboxs[a].Size = new Size(750, 200);

                this.Controls.Add(groupboxs[a]);

                for (int b = (a * 4) ; b < (a * 4) + 4; b++)
                {
                    radioButtons[b].Location = new Point(0,prad);
                  
                    radioButtons[b].AutoSize = true;
                    radioButtons[b].Left = 20;
                    if(radioButtons[b].Text!=" ")
                        groupboxs[a].Controls.Add((RadioButton)radioButtons[b]);
                    prad += 30;
                }
              
                plbl += 230;
         
            }

            SqlCN.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (flag == 0)
            {
                Form1 form = new Form1(insid);
                form.Show();
            }
            else
            {
                showexam form = new showexam(insid,crsid);
                form.Show();
            }

        }
    }
}
