namespace Examination_System
{
    partial class Instructor_Home
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
            this.btnshowexam = new System.Windows.Forms.Button();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshowexam
            // 
            this.btnshowexam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnshowexam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshowexam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshowexam.Location = new System.Drawing.Point(284, 300);
            this.btnshowexam.Name = "btnshowexam";
            this.btnshowexam.Size = new System.Drawing.Size(339, 62);
            this.btnshowexam.TabIndex = 3;
            this.btnshowexam.Text = "Show Exam";
            this.btnshowexam.UseVisualStyleBackColor = false;
            this.btnshowexam.Click += new System.EventHandler(this.btnshowexam_Click);
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btngenerate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngenerate.Location = new System.Drawing.Point(284, 142);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(339, 62);
            this.btngenerate.TabIndex = 2;
            this.btngenerate.Text = "Generate Exam";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(855, 489);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 29);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Instructor_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnshowexam);
            this.Controls.Add(this.btngenerate);
            this.MaximumSize = new System.Drawing.Size(979, 577);
            this.MinimumSize = new System.Drawing.Size(979, 577);
            this.Name = "Instructor_Home";
            this.Text = "Instructor_Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnshowexam;
        private Button btngenerate;
        private Button btnback;
    }
}