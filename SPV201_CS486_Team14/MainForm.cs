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
    public partial class MainForm : Form
    {
        string[] examiners, contestants, officialGroup, reserveGroup;
        int[] contestantID, officialID, reserveID;
        public MainForm()
        {
            InitializeComponent();
            examiners = new string []{ "abc", "xyz", "jqk"};
            contestants = new string []{ "abc", "xyz", "jqk"};
            officialGroup = new string []{ "abc", "xyz", "jqk"};
            reserveGroup = new string []{ "abc", "xyz", "jqk"};
            contestantID = new int[] { 1, 2, 3 };
            officialID = new int[] { 1, 2, 3 };
            reserveID = new int[] { 1, 2, 3 };
        }

        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            panelMain.Controls.Add(childForm);
            childForm.Show();
        }
        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            openChildForm(null);
        }

        private void btnContestant_Click(object sender, EventArgs e)
        {
            openChildForm(new ContestantForm(contestants, contestantID));
        }

        private void btnExaminer_Click(object sender, EventArgs e)
        {
            openChildForm(new ExaminerForm(examiners));
        }

        private void btnOfficialGroup_Click(object sender, EventArgs e)
        {
            openChildForm(new OfficialGroupForm(officialGroup, officialID));
        }

        private void btnReserveGroup_Click(object sender, EventArgs e)
        {
            openChildForm(new ReserveGroupForm(reserveGroup, reserveID));
        }
    }
}
