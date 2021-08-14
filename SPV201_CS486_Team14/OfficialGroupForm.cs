using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV201_CS486_Team14
{
    public partial class OfficialGroupForm : Form
    {
        public OfficialGroupForm(string[] officialGroup, int[] officialID)
        {
            InitializeComponent();
            for (int i = 0; i < officialGroup.Length; i++)
            {
                Button btnMember = new Button();
                btnMember.Text = officialGroup[i];
                btnMember.Dock = DockStyle.Fill;
                btnMember.Click += new EventHandler(this.btnMember_Click);
                btnMember.Tag = officialID[i];

                Panel panelBtn = new Panel();
                panelBtn.Dock = DockStyle.Top;
                panelBtn.Padding = new Padding(20);
                panelBtn.Height = 80;

                panelBtn.Controls.Add(btnMember);
                panelOfficialGroup.Controls.Add(panelBtn);
            }
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
        }
    }
}
