namespace Examination_System
{
    partial class Student_Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblerroe = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btngrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(320, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Take Exam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(323, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Couse Name";
            // 
            // lblerroe
            // 
            this.lblerroe.AutoSize = true;
            this.lblerroe.Location = new System.Drawing.Point(435, 158);
            this.lblerroe.Name = "lblerroe";
            this.lblerroe.Size = new System.Drawing.Size(0, 17);
            this.lblerroe.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(855, 489);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 29);
            this.btnback.TabIndex = 25;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btngrade
            // 
            this.btngrade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btngrade.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngrade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngrade.Location = new System.Drawing.Point(320, 407);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(316, 67);
            this.btngrade.TabIndex = 26;
            this.btngrade.Text = "Show Grades";
            this.btngrade.UseVisualStyleBackColor = false;
            this.btngrade.Click += new System.EventHandler(this.btngrade_Click);
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblerroe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Location = new System.Drawing.Point(767, 474);
            this.MaximumSize = new System.Drawing.Size(979, 577);
            this.MinimumSize = new System.Drawing.Size(979, 577);
            this.Name = "Student_Home";
            this.Text = "Student_Home";
            this.Load += new System.EventHandler(this.Student_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label lblerroe;
        private Button btnback;
        private Button btngrade;
    }
}