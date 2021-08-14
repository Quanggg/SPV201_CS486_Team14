
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
            this.labelOfficialGroup.Location = new System.Drawing.Point(0, 0);
            this.labelOfficialGroup.Name = "labelOfficialGroup";
            this.labelOfficialGroup.Size = new System.Drawing.Size(800, 74);
            this.labelOfficialGroup.TabIndex = 0;
            this.labelOfficialGroup.Text = "Official Group";
            // 
            // panelOfficialGroup
            // 
            this.panelOfficialGroup.AutoScroll = true;
            this.panelOfficialGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfficialGroup.Location = new System.Drawing.Point(0, 74);
            this.panelOfficialGroup.Name = "panelOfficialGroup";
            this.panelOfficialGroup.Size = new System.Drawing.Size(800, 376);
            this.panelOfficialGroup.TabIndex = 1;
            // 
            // OfficialGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOfficialGroup);
            this.Controls.Add(this.labelOfficialGroup);
            this.Name = "OfficialGroupForm";
            this.Text = "OfficialGroupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOfficialGroup;
        private System.Windows.Forms.Panel panelOfficialGroup;
    }
}