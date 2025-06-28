using System;
using System.Linq;
using System.Windows.Forms;
using GymManagementApp.Models;
using GymManagementApp.Database;

namespace GymManagementApp.Forms
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
            LoadClients();
            LoadPayments();
        }

        private void LoadClients()
        {
            var users = DatabaseHelper.GetUsers();
            cmbClient.DataSource = users;
            cmbClient.DisplayMember = "Name";
            cmbClient.ValueMember = "Id";
        }

        private void LoadPayments()
        {
            dgvPayments.DataSource = null;
            dgvPayments.DataSource = DatabaseHelper.GetAllPayments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var payment = new Payment
            {
                ClientId = (int)cmbClient.SelectedValue,
                Amount = decimal.TryParse(txtAmount.Text, out var amt) ? amt : 0m,
                Date = dtpDate.Value,
                PaymentType = cmbPaymentType.SelectedItem?.ToString() ?? string.Empty
            };
            DatabaseHelper.AddPayment(payment);
            LoadPayments();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow != null)
            {
                var payment = dgvPayments.CurrentRow.DataBoundItem as Payment;
                if (payment != null)
                {
                    DatabaseHelper.DeletePayment(payment.Id);
                    LoadPayments();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = Application.OpenForms.OfType<MainPanelForm>().FirstOrDefault() ?? new MainPanelForm();
            main.Show();
        }

        private void ClearInputs()
        {
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;
            if (cmbPaymentType.Items.Count > 0)
                cmbPaymentType.SelectedIndex = 0;
            if (cmbClient.Items.Count > 0)
                cmbClient.SelectedIndex = 0;
        }
    }
}
