
namespace SPV201_CS486_Team14
{
    partial class ReserveGroupForm
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
            this.labelReserveGroup = new System.Windows.Forms.Label();
            this.panelReserveGroup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelReserveGroup
            // 
            this.labelReserveGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReserveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserveGroup.Location = new System.Drawing.Point(0, 0);
            this.labelReserveGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReserveGroup.Name = "labelReserveGroup";
            this.labelReserveGroup.Size = new System.Drawing.Size(855, 91);
            this.labelReserveGroup.TabIndex = 1;
            this.labelReserveGroup.Text = "Reserve Group";
            this.labelReserveGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReserveGroup
            // 
            this.panelReserveGroup.AutoScroll = true;
            this.panelReserveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReserveGroup.Location = new System.Drawing.Point(0, 91);
            this.panelReserveGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReserveGroup.Name = "panelReserveGroup";
            this.panelReserveGroup.Size = new System.Drawing.Size(855, 378);
            this.panelReserveGroup.TabIndex = 2;
            // 
            // ReserveGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.panelReserveGroup);
            this.Controls.Add(this.labelReserveGroup);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReserveGroupForm";
            this.Text = "ReserveGroupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelReserveGroup;
        private System.Windows.Forms.Panel panelReserveGroup;
    }
}