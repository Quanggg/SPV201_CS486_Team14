
namespace SPV201_CS486_Team14
{
    partial class OfficialGroupForm
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
            this.labelOfficialGroup = new System.Windows.Forms.Label();
            this.panelOfficialGroup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelOfficialGroup
            // 
            this.labelOfficialGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOfficialGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficialGroup.Location = new System.Drawing.Point(0, 0);
            this.labelOfficialGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficialGroup.Name = "labelOfficialGroup";
            this.labelOfficialGroup.Size = new System.Drawing.Size(1067, 91);
            this.labelOfficialGroup.TabIndex = 0;
            this.labelOfficialGroup.Text = "Official Group";
            this.labelOfficialGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOfficialGroup
            // 
            this.panelOfficialGroup.AutoScroll = true;
            this.panelOfficialGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfficialGroup.Location = new System.Drawing.Point(0, 91);
            this.panelOfficialGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOfficialGroup.Name = "panelOfficialGroup";
            this.panelOfficialGroup.Size = new System.Drawing.Size(1067, 463);
            this.panelOfficialGroup.TabIndex = 1;
            // 
            // OfficialGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelOfficialGroup);
            this.Controls.Add(this.labelOfficialGroup);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OfficialGroupForm";
            this.Text = "OfficialGroupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOfficialGroup;
        private System.Windows.Forms.Panel panelOfficialGroup;
    }
}