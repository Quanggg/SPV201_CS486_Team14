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
        SQLHelper sqlHelper;
        public MainForm(string connectionString)
        {
            InitializeComponent();
            sqlHelper = new SQLHelper();
            examiners = new string []{ "abc", "xyz", "jqk"};
            //examiners = sqlHelper.GetExaminersName();

            contestants = new string []{ "abc", "xyz", "jqk"}; 
            contestantID = new int[] { 1, 2, 3 };
            //contestants = sqlHelper.GetContestantsName();
            //contestantID = sqlHelper.GetContestantsID();

            officialGroup = new string []{ "abc", "xyz", "jqk"};
            officialID = new int[] { 1, 2, 3 };
            //officialGroup = sqlHelper.GetOfficialMembersName();
            //officialID = sqlHelper.GetOfficialMembersID();

            reserveGroup = new string []{ "abc", "xyz", "jqk"};
            reserveID = new int[] { 1, 2, 3 };
            //reserveGroup = sqlHelper.GetReserveMembersName();
            //reserveID = sqlHelper.GetReserveMembersID();
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
