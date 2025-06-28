using GymManagementApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (login == "root" && password == "root")
            {
                this.Hide();
                MainPanelForm mpf = new MainPanelForm();
                mpf.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
        }

    }
}
