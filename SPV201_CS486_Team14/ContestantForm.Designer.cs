
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
            this.labelContestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContestant.Location = new System.Drawing.Point(0, 0);
            this.labelContestant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContestant.Name = "labelContestant";
            this.labelContestant.Size = new System.Drawing.Size(1067, 75);
            this.labelContestant.TabIndex = 0;
            this.labelContestant.Text = "Contestants";
            this.labelContestant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContestant
            // 
            this.panelContestant.AutoScroll = true;
            this.panelContestant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContestant.Location = new System.Drawing.Point(0, 75);
            this.panelContestant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContestant.Name = "panelContestant";
            this.panelContestant.Size = new System.Drawing.Size(1067, 479);
            this.panelContestant.TabIndex = 1;
            // 
            // ContestantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContestant);
            this.Controls.Add(this.labelContestant);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContestantForm";
            this.Text = "ContestantForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelContestant;
        private System.Windows.Forms.Panel panelContestant;
    }
}