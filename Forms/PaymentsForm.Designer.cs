namespace GymManagementApp.Forms
{
    partial class PaymentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPayments = new DataGridView();
            cmbClient = new ComboBox();
            txtAmount = new TextBox();
            dtpDate = new DateTimePicker();
            cmbPaymentType = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Dock = DockStyle.Top;
            dgvPayments.Location = new Point(0, 0);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(800, 250);
            dgvPayments.TabIndex = 0;
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(20, 260);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(200, 23);
            cmbClient.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(240, 260);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(360, 260);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 23);
            dtpDate.TabIndex = 3;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Cash", "Card", "Online" });
            cmbPaymentType.Location = new Point(530, 260);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(120, 23);
            cmbPaymentType.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(670, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(670, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Usuń";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(20, 300);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 25);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(110, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 25);
            btnBack.TabIndex = 8;
            btnBack.Text = "Powrót";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbPaymentType);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(cmbClient);
            Controls.Add(dgvPayments);
            Name = "PaymentsForm";
            Text = "Płatności";
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
