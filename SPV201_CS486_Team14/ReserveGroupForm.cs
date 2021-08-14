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
    public partial class ReserveGroupForm : Form
    {
        public ReserveGroupForm(string[] reserveGroup, int[] reserveID)
        {
            InitializeComponent();
            for (int i = 0; i < reserveGroup.Length; i++)
            {
                Button btnMember = new Button();
                btnMember.Text = reserveGroup[i];
                btnMember.Dock = DockStyle.Fill;
                btnMember.Click += new EventHandler(this.btnMember_Click);
                btnMember.Tag = reserveID[i];

                Panel panelBtn = new Panel();
                panelBtn.Dock = DockStyle.Top;
                panelBtn.Padding = new Padding(20);
                panelBtn.Height = 80;

                panelBtn.Controls.Add(btnMember);
                panelReserveGroup.Controls.Add(panelBtn);
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            labelReserveGroup.Text = ((Button)sender).Text;

            panelReserveGroup.Controls.Clear();
            Form childForm = new InformationForm();
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            panelReserveGroup.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
