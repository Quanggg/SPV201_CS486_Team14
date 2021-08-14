
namespace IntroductionScreen
{
  partial class FormConnectDB
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnectDB));
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxConnectionString = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.connectBtn = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(52, 22);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 16, 16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(250, 44);
      this.label1.TabIndex = 1;
      this.label1.Text = "Connect Your";
      // 
      // textBoxConnectionString
      // 
      this.textBoxConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxConnectionString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
      this.textBoxConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxConnectionString.ForeColor = System.Drawing.Color.White;
      this.textBoxConnectionString.Location = new System.Drawing.Point(20, 87);
      this.textBoxConnectionString.Name = "textBoxConnectionString";
      this.textBoxConnectionString.Size = new System.Drawing.Size(494, 44);
      this.textBoxConnectionString.TabIndex = 3;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(300, 20);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 50);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // connectBtn
      // 
      this.connectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.connectBtn.AutoSize = true;
      this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
      this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectBtn.ForeColor = System.Drawing.Color.White;
      this.connectBtn.Image = global::SPV201_CS486_Team14.Properties.Resources.plug;
      this.connectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.connectBtn.Location = new System.Drawing.Point(155, 172);
      this.connectBtn.Name = "connectBtn";
      this.connectBtn.Padding = new System.Windows.Forms.Padding(16, 4, 16, 4);
      this.connectBtn.Size = new System.Drawing.Size(206, 74);
      this.connectBtn.TabIndex = 5;
      this.connectBtn.Text = "Connect";
      this.connectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.connectBtn.UseVisualStyleBackColor = false;
      this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(357, 24);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 16, 16, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 44);
      this.label2.TabIndex = 6;
      this.label2.Text = "Here";
      // 
      // FormConnectDB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
      this.ClientSize = new System.Drawing.Size(526, 286);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.connectBtn);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textBoxConnectionString);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(550, 350);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(550, 350);
      this.Name = "FormConnectDB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FormConnectDB";
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxConnectionString;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button connectBtn;
    private System.Windows.Forms.Label label2;
  }
}