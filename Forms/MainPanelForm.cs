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
    public partial class MainPanelForm : Form
    {
        public MainPanelForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var userForm = new UserManagementForm();
            userForm.Show();
            this.Close();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            var groupForm = new GroupManagementForm();
            groupForm.Show();
            this.Close();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            var sessionsForm = new TrainingManagementForm();
            sessionsForm.Show();
            this.Close();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            var PaymentsForm = new PaymentsForm();
            PaymentsForm.Show();
            this.Close();
        }
    }
}
