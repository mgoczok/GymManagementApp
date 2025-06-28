using GymManagementApp.Database;
using GymManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymManagementApp.Forms
{
    public partial class GroupManagementForm : Form
    {
        public GroupManagementForm()
        {
            InitializeComponent();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            var group = new TrainingGroup
            {
                Name = textBoxGroupName.Text,
                Description = textBoxGroupDescription.Text
            };

            DatabaseHelper.AddTrainingGroup(group);
            LoadGroups();

            //czyszczenie po dodaniu
            textBoxGroupName.Text = "";
            textBoxGroupDescription.Text = "";
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            // Pobieranie wierszy w DataGridView
            if (dataGridViewGroups.CurrentRow != null)
            {
                var selectedGroup = dataGridViewGroups.CurrentRow.DataBoundItem as TrainingGroup;
                if (selectedGroup != null)
                {
                    DatabaseHelper.DeleteTrainingGroup(selectedGroup.Id);
                    LoadGroups();
                }
                else
                {
                    MessageBox.Show("Nie można pobrać wybranej grupy.");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej grupy do usunięcia.");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void GroupManagementForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void LoadGroups()
        {
            var groups = DatabaseHelper.GetTrainingGroups();
            dataGridViewGroups.DataSource = groups;

            if (dataGridViewGroups.Columns["Id"] != null)
                dataGridViewGroups.Columns["Id"].Visible = false; // ukryj kolumnę Id

            if (dataGridViewGroups.Columns["Name"] != null)
                dataGridViewGroups.Columns["Name"].HeaderText = "Nazwa grupy";

            if (dataGridViewGroups.Columns["Description"] != null)
                dataGridViewGroups.Columns["Description"].HeaderText = "Opis grupy";


        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainForm = new MainPanelForm();
            mainForm.Show();
        }
    }
}
