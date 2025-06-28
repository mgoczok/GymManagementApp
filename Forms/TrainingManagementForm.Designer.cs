namespace GymManagementApp.Forms
{
    partial class TrainingManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button buttonBack;

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
            dgvTrainings = new DataGridView();
            labelName = new Label();
            txtName = new TextBox();
            labelDescription = new Label();
            txtDescription = new TextBox();
            labelType = new Label();
            cmbType = new ComboBox();
            labelGroup = new Label();
            cmbGroup = new ComboBox();
            btnAdd = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrainings).BeginInit();
            SuspendLayout();
            // 
            // dgvTrainings
            // 
            dgvTrainings.AllowUserToAddRows = false;
            dgvTrainings.AllowUserToDeleteRows = false;
            dgvTrainings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainings.Dock = DockStyle.Top;
            dgvTrainings.Location = new Point(0, 0);
            dgvTrainings.Name = "dgvTrainings";
            dgvTrainings.ReadOnly = true;
            dgvTrainings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainings.Size = new Size(800, 200);
            dgvTrainings.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 210);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Nazwa";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 207);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 240);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(31, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Opis";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 237);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 4;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 270);
            labelType.Name = "labelType";
            labelType.Size = new Size(25, 15);
            labelType.TabIndex = 5;
            labelType.Text = "Typ";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "General", "Cardio", "Strength" });
            cmbType.Location = new Point(80, 267);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(150, 23);
            cmbType.TabIndex = 6;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(12, 300);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(39, 15);
            labelGroup.TabIndex = 7;
            labelGroup.Text = "Grupa";
            // 
            // cmbGroup
            // 
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.FormattingEnabled = true;
            cmbGroup.Location = new Point(80, 297);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(150, 23);
            cmbGroup.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 267);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(687, 400);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(91, 38);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Powrót";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // TrainingManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(cmbGroup);
            Controls.Add(labelGroup);
            Controls.Add(cmbType);
            Controls.Add(labelType);
            Controls.Add(txtDescription);
            Controls.Add(labelDescription);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(buttonBack);
            Controls.Add(dgvTrainings);
            Name = "TrainingManagementForm";
            Text = "Zarządzanie Treningami";
            ((System.ComponentModel.ISupportInitialize)dgvTrainings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
