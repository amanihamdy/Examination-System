namespace Examination_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nummcq = new System.Windows.Forms.NumericUpDown();
            this.numtf = new System.Windows.Forms.NumericUpDown();
            this.comcrsname = new System.Windows.Forms.ComboBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nummcq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtf)).BeginInit();
            this.SuspendLayout();
            // 
            // nummcq
            // 
            this.nummcq.Location = new System.Drawing.Point(294, 189);
            this.nummcq.Name = "nummcq";
            this.nummcq.Size = new System.Drawing.Size(305, 27);
            this.nummcq.TabIndex = 0;
            // 
            // numtf
            // 
            this.numtf.Location = new System.Drawing.Point(294, 238);
            this.numtf.Name = "numtf";
            this.numtf.Size = new System.Drawing.Size(305, 27);
            this.numtf.TabIndex = 1;
            // 
            // comcrsname
            // 
            this.comcrsname.FormattingEnabled = true;
            this.comcrsname.Location = new System.Drawing.Point(294, 137);
            this.comcrsname.Name = "comcrsname";
            this.comcrsname.Size = new System.Drawing.Size(305, 28);
            this.comcrsname.TabIndex = 2;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btngenerate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btngenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngenerate.Location = new System.Drawing.Point(294, 338);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(305, 55);
            this.btngenerate.TabIndex = 3;
            this.btngenerate.Text = "Generate Exam";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(295, 289);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 20);
            this.lblerror.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generate Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of MCQ Questions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(55, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of T/F Questions";
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnshow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnshow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshow.Location = new System.Drawing.Point(295, 420);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(305, 55);
            this.btnshow.TabIndex = 10;
            this.btnshow.Text = "Show Generated Exam";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Visible = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnback
            // 
            this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(855, 484);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 34);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.comcrsname);
            this.Controls.Add(this.numtf);
            this.Controls.Add(this.nummcq);
            this.MaximumSize = new System.Drawing.Size(979, 577);
            this.MinimumSize = new System.Drawing.Size(979, 577);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nummcq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nummcq;
        private NumericUpDown numtf;
        private ComboBox comcrsname;
        private Button btngenerate;
        private Label lblerror;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnshow;
        private Button btnback;
    }
}