using System;
using System.Linq;
using System.Windows.Forms;
using GymManagementApp.Models;
using GymManagementApp.Database;

namespace GymManagementApp.Forms
{
    public partial class TrainingManagementForm : Form
    {
        public TrainingManagementForm()
        {
            InitializeComponent();
            LoadGroups();
            LoadTrainings();
        }

        private void LoadGroups()
        {
            var groups = DatabaseHelper.GetTrainingGroups();
            cmbGroup.DataSource = groups;
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Id";
        }

        private void LoadTrainings()
        {
            dgvTrainings.DataSource = null;
            dgvTrainings.DataSource = DatabaseHelper.GetAllTrainings();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Training training;
            switch (cmbType.SelectedItem?.ToString())
            {
                case "Cardio":
                    training = new CardioTraining();
                    break;
                case "Strength":
                    training = new StrengthTraining();
                    break;
                default:
                    training = new GeneralTraining();
                    break;
            }
            training.Name = txtName.Text;
            training.Description = txtDescription.Text;
            training.GroupId = (int)cmbGroup.SelectedValue;

            DatabaseHelper.AddTraining(training);
            LoadTrainings();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDescription.Clear();
            cmbType.SelectedIndex = 0;
            if (cmbGroup.Items.Count > 0) cmbGroup.SelectedIndex = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Zamyka ten formularz i otwiera ponownie główny panel
            this.Hide();
            Form mainForm = Application.OpenForms.OfType<MainPanelForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new MainPanelForm();
            }
            mainForm.Show();
        }
    }
}
