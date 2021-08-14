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
using SPV201_CS486_Team14;

namespace IntroductionScreen
{
    public partial class FormConnectDB : Form
    {
        public FormConnectDB()
        {
            InitializeComponent();
        }
        bool connecting = false;
        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!connecting)
                testDBconnection();
            connectBtn.Image = global::SPV201_CS486_Team14.Properties.Resources.loading;
        }
        private async void testDBconnection()
        {
            connecting = true;
            string connectionString = textBoxConnectionString.Text;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                connection.Close();
                MainForm f = new MainForm(connectionString);
                f.Closed += (sender, args) => this.Close();
                this.Hide();
                f.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot connect to database. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Cannot connect to database. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot connect to database. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connecting = false;
        }
    }
}
