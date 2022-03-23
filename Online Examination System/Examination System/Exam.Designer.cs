namespace Examination_System
{
    partial class Exam
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
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_submit.Location = new System.Drawing.Point(817, 469);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(132, 49);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(961, 530);
            this.Controls.Add(this.button_submit);
            this.MaximumSize = new System.Drawing.Size(979, 577);
            this.MinimumSize = new System.Drawing.Size(979, 577);
            this.Name = "Exam";
            this.Text = "Exam Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_submit;
    }
}