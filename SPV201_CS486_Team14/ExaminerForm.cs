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
    public partial class ExaminerForm : Form
    {
        public ExaminerForm(string[] examiners)
        {
            InitializeComponent();
            foreach (string examiner in examiners)
            {
                Label labelExam = new Label();
                labelExam.Width = 50;
                labelExam.Text = examiner;
                labelExam.AutoSize = false;
                labelExam.Dock = DockStyle.Top;
                labelExam.TextAlign = ContentAlignment.MiddleCenter;
                labelExam.Margin = new Padding(20);
                panelExaminer.Controls.Add(labelExam);                
            }
        }
    }
}
