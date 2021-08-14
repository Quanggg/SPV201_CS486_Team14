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
    public partial class ContestantForm : Form
    {
        public ContestantForm(string[] contestants, int[] contestantID)
        {
            InitializeComponent();
            for (int i = 0; i < contestants.Length; i++)
            {
                Button btnContestant = new Button();
                btnContestant.Text = contestants[i];
                btnContestant.Dock = DockStyle.Fill;
                btnContestant.Click += new EventHandler(this.btnContestant_Click);
                btnContestant.Tag = contestantID[i];

                Panel panelBtn = new Panel();
                panelBtn.Dock = DockStyle.Top;
                panelBtn.Padding = new Padding(20);
                panelBtn.Height = 80;

                panelBtn.Controls.Add(btnContestant);
                panelContestant.Controls.Add(panelBtn);
            }
        }

        private void btnContestant_Click(object sender, EventArgs e)
        {
            labelContestant.Text = ((Button)sender).Text;

            panelContestant.Controls.Clear();
            Form childForm = new InformationForm();
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            panelContestant.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
