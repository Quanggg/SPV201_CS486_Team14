
namespace SPV201_CS486_Team14
{
    partial class InformationForm
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
            this.labelPerformane = new System.Windows.Forms.Label();
            this.labelExaminerResult = new System.Windows.Forms.Label();
            this.labelExaminerFeedback = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPerformane
            // 
            this.labelPerformane.AutoSize = true;
            this.labelPerformane.Location = new System.Drawing.Point(12, 9);
            this.labelPerformane.Name = "labelPerformane";
            this.labelPerformane.Size = new System.Drawing.Size(100, 13);
            this.labelPerformane.TabIndex = 0;
            this.labelPerformane.Text = "Performance Result";
            // 
            // labelExaminerResult
            // 
            this.labelExaminerResult.AutoSize = true;
            this.labelExaminerResult.Location = new System.Drawing.Point(118, 9);
            this.labelExaminerResult.Name = "labelExaminerResult";
            this.labelExaminerResult.Size = new System.Drawing.Size(83, 13);
            this.labelExaminerResult.TabIndex = 1;
            this.labelExaminerResult.Text = "Examiner Result";
            // 
            // labelExaminerFeedback
            // 
            this.labelExaminerFeedback.AutoSize = true;
            this.labelExaminerFeedback.Location = new System.Drawing.Point(207, 9);
            this.labelExaminerFeedback.Name = "labelExaminerFeedback";
            this.labelExaminerFeedback.Size = new System.Drawing.Size(101, 13);
            this.labelExaminerFeedback.TabIndex = 2;
            this.labelExaminerFeedback.Text = "Examiner Feedback";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contestant Result";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 57);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExaminerFeedback);
            this.Controls.Add(this.labelExaminerResult);
            this.Controls.Add(this.labelPerformane);
            this.Name = "InformationForm";
            this.Text = "InformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerformane;
        private System.Windows.Forms.Label labelExaminerResult;
        private System.Windows.Forms.Label labelExaminerFeedback;
        private System.Windows.Forms.Label label1;
    }
}