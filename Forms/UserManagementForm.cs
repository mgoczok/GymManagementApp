using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GymManagementApp.Database;
using GymManagementApp.Models;

namespace GymManagementApp.Forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            this.Load += UserManagementForm_Load; 
        }

        private void LoadUsers()
        {
            List<User> users = DatabaseHelper.GetUsers();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;

            // Ukryj kolumnę z hasłem jeśli istnieje
            if (dgvUsers.Columns["Password"] != null)
                dgvUsers.Columns["Password"].Visible = false;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                User selectedUser = (User)dgvUsers.CurrentRow.DataBoundItem;
                EditUserForm editForm = new EditUserForm(selectedUser);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(); // odśwież listę po edycji
                }
            }
            else
            {
                MessageBox.Show("Wybierz użytkownika do edycji.");
            }
        }


        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                User selectedUser = (User)dgvUsers.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show($"Czy na pewno chcesz usunąć użytkownika {selectedUser.Name}?",
                                              "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteUser(selectedUser.Id);
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Wybierz użytkownika do usunięcia.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainForm = new MainPanelForm();
            mainForm.Show();
        }
    }
}
