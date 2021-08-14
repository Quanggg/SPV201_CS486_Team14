
namespace SPV201_CS486_Team14
{
    partial class ExaminerForm
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
            this.labelExaminer = new System.Windows.Forms.Label();
            this.panelExaminer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelExaminer
            // 
            this.labelExaminer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExaminer.Location = new System.Drawing.Point(0, 0);
            this.labelExaminer.Name = "labelExaminer";
            this.labelExaminer.Size = new System.Drawing.Size(800, 77);
            this.labelExaminer.TabIndex = 0;
            this.labelExaminer.Text = "Examiner";
            // 
            // panelExaminer
            // 
            this.panelExaminer.AutoScroll = true;
            this.panelExaminer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExaminer.Location = new System.Drawing.Point(0, 77);
            this.panelExaminer.Name = "panelExaminer";
            this.panelExaminer.Size = new System.Drawing.Size(800, 373);
            this.panelExaminer.TabIndex = 1;
            // 
            // ExaminerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExaminer);
            this.Controls.Add(this.labelExaminer);
            this.Name = "ExaminerForm";
            this.Text = "ExaminerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExaminer;
        private System.Windows.Forms.Panel panelExaminer;
    }
}