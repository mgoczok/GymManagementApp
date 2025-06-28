using System;
using System.Windows.Forms;
using GymManagementApp.Models;
using GymManagementApp.Database;

namespace GymManagementApp.Forms
{
    public partial class AddUserForm : Form
    {
        private User user;

        public AddUserForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            // Wywołanie metody statycznej 
            DatabaseHelper.AddUser(user);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainForm = new MainPanelForm();
            mainForm.Show();
        }
    }
}
