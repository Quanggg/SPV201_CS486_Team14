using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionScreen
{
  public partial class FormConnectDB : Form
  {
    public FormConnectDB()
    {
      InitializeComponent();
    }

    private void connectBtn_Click(object sender, EventArgs e)
    {
      connectBtn.Image = global::SPV201_CS486_Team14.Properties.Resources.loading;
    }
  }
}
