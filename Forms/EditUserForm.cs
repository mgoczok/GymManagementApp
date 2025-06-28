using System;
using System.Windows.Forms;
using GymManagementApp.Models;
using GymManagementApp.Database;

namespace GymManagementApp.Forms
{
    public partial class EditUserForm : Form
    {
        private User user;

        public EditUserForm(User existingUser)
        {
            InitializeComponent();
            user = existingUser;

            // Wypełnianie pola danymi użytkownika
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aktualizacja danych z formsa
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            // Wywołujemy statyczną metodę aktualizacji
            DatabaseHelper.UpdateUser(user);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
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
