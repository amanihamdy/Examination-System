namespace Examination_System
{
    partial class Instructor_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUpIns = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUpIns
            // 
            this.btnSignUpIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignUpIns.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUpIns.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUpIns.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUpIns.Location = new System.Drawing.Point(395, 393);
            this.btnSignUpIns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUpIns.Name = "btnSignUpIns";
            this.btnSignUpIns.Size = new System.Drawing.Size(274, 61);
            this.btnSignUpIns.TabIndex = 11;
            this.btnSignUpIns.Text = "Log In";
            this.btnSignUpIns.UseVisualStyleBackColor = false;
            this.btnSignUpIns.Click += new System.EventHandler(this.btnSignUpIns_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(263, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(297, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(395, 241);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 27);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserName.Location = new System.Drawing.Point(395, 134);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(274, 27);
            this.txtUserName.TabIndex = 7;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblerror.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblerror.Location = new System.Drawing.Point(400, 324);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(42, 17);
            this.lblerror.TabIndex = 12;
            this.lblerror.Text = "label1";
            this.lblerror.Visible = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(855, 485);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 33);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Instructor_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnSignUpIns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.MaximumSize = new System.Drawing.Size(979, 577);
            this.MinimumSize = new System.Drawing.Size(979, 577);
            this.Name = "Instructor_login";
            this.Text = "Instructor_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSignUpIns;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblerror;
        private Button btnback;
    }
}