namespace GymManagementApp.Forms
{
    partial class UserManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEditUser = new Button();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            dgvUsers = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(314, 340);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(124, 45);
            btnEditUser.TabIndex = 0;
            btnEditUser.Text = "Edytuj użytkownika";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(165, 340);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(124, 45);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Dodaj użytkownika";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(465, 340);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(117, 45);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Usuń użytkownika";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click_1;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(165, 54);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(417, 195);
            dgvUsers.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(668, 38);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 16;
            button2.Text = "Powrót";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dgvUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnEditUser);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditUser;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private DataGridView dgvUsers;
        private Button button2;
    }
}