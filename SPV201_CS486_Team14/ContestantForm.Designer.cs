
namespace SPV201_CS486_Team14
{
    partial class ContestantForm
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
            this.labelContestant = new System.Windows.Forms.Label();
            this.panelContestant = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelContestant
            // 
            this.labelContestant.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContestant.Location = new System.Drawing.Point(0, 0);
            this.labelContestant.Name = "labelContestant";
            this.labelContestant.Size = new System.Drawing.Size(800, 61);
            this.labelContestant.TabIndex = 0;
            this.labelContestant.Text = "Contestants";
            // 
            // panelContestant
            // 
            this.panelContestant.AutoScroll = true;
            this.panelContestant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContestant.Location = new System.Drawing.Point(0, 61);
            this.panelContestant.Name = "panelContestant";
            this.panelContestant.Size = new System.Drawing.Size(800, 389);
            this.panelContestant.TabIndex = 1;
            // 
            // ContestantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContestant);
            this.Controls.Add(this.labelContestant);
            this.Name = "ContestantForm";
            this.Text = "ContestantForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelContestant;
        private System.Windows.Forms.Panel panelContestant;
    }
}