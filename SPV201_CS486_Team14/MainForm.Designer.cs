
namespace SPV201_CS486_Team14
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnContestant = new System.Windows.Forms.Button();
            this.btnOfficialGroup = new System.Windows.Forms.Button();
            this.btnReserveGroup = new System.Windows.Forms.Button();
            this.btnExaminer = new System.Windows.Forms.Button();
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.panelPadding = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnReserveGroup);
            this.panelMenu.Controls.Add(this.btnOfficialGroup);
            this.panelMenu.Controls.Add(this.btnContestant);
            this.panelMenu.Controls.Add(this.btnExaminer);
            this.panelMenu.Controls.Add(this.btnIntroduction);
            this.panelMenu.Controls.Add(this.panelPadding);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 633);
            this.panelMenu.TabIndex = 0;
            // 
            // btnContestant
            // 
            this.btnContestant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContestant.Location = new System.Drawing.Point(0, 299);
            this.btnContestant.Name = "btnContestant";
            this.btnContestant.Size = new System.Drawing.Size(200, 101);
            this.btnContestant.TabIndex = 2;
            this.btnContestant.Text = "Contestants";
            this.btnContestant.UseVisualStyleBackColor = true;
            this.btnContestant.Click += new System.EventHandler(this.btnContestant_Click);
            // 
            // btnOfficialGroup
            // 
            this.btnOfficialGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfficialGroup.Location = new System.Drawing.Point(0, 400);
            this.btnOfficialGroup.Name = "btnOfficialGroup";
            this.btnOfficialGroup.Size = new System.Drawing.Size(200, 101);
            this.btnOfficialGroup.TabIndex = 4;
            this.btnOfficialGroup.Text = "Official Group";
            this.btnOfficialGroup.UseVisualStyleBackColor = true;
            this.btnOfficialGroup.Click += new System.EventHandler(this.btnOfficialGroup_Click);
            // 
            // btnReserveGroup
            // 
            this.btnReserveGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserveGroup.Location = new System.Drawing.Point(0, 501);
            this.btnReserveGroup.Name = "btnReserveGroup";
            this.btnReserveGroup.Size = new System.Drawing.Size(200, 101);
            this.btnReserveGroup.TabIndex = 5;
            this.btnReserveGroup.Text = "Reserve Group";
            this.btnReserveGroup.UseVisualStyleBackColor = true;
            this.btnReserveGroup.Click += new System.EventHandler(this.btnReserveGroup_Click);
            // 
            // btnExaminer
            // 
            this.btnExaminer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExaminer.Location = new System.Drawing.Point(0, 198);
            this.btnExaminer.Name = "btnExaminer";
            this.btnExaminer.Size = new System.Drawing.Size(200, 101);
            this.btnExaminer.TabIndex = 3;
            this.btnExaminer.Text = "Examiners";
            this.btnExaminer.UseVisualStyleBackColor = true;
            this.btnExaminer.Click += new System.EventHandler(this.btnExaminer_Click);
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntroduction.Location = new System.Drawing.Point(0, 97);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(200, 101);
            this.btnIntroduction.TabIndex = 1;
            this.btnIntroduction.Text = "Introduction";
            this.btnIntroduction.UseVisualStyleBackColor = true;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // panelPadding
            // 
            this.panelPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPadding.Location = new System.Drawing.Point(0, 0);
            this.panelPadding.Name = "panelPadding";
            this.panelPadding.Size = new System.Drawing.Size(200, 97);
            this.panelPadding.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1022, 633);
            this.panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "SP201 CS486 Team14";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnIntroduction;
        private System.Windows.Forms.Panel panelPadding;
        private System.Windows.Forms.Button btnReserveGroup;
        private System.Windows.Forms.Button btnOfficialGroup;
        private System.Windows.Forms.Button btnExaminer;
        private System.Windows.Forms.Button btnContestant;
        private System.Windows.Forms.Panel panelMain;
    }
}