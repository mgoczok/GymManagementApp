namespace GymManagementApp.Forms
{
    partial class MainPanelForm
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
            btnUsers = new Button();
            btnGroups = new Button();
            btnSessions = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLogout = new Button();
            btnPayments = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(210, 418);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(98, 23);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Użytkownicy";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnGroups
            // 
            btnGroups.Location = new Point(355, 418);
            btnGroups.Name = "btnGroups";
            btnGroups.Size = new Size(88, 23);
            btnGroups.TabIndex = 1;
            btnGroups.Text = "Grupy";
            btnGroups.UseVisualStyleBackColor = true;
            btnGroups.Click += btnGroups_Click;
            // 
            // btnSessions
            // 
            btnSessions.Location = new Point(495, 418);
            btnSessions.Name = "btnSessions";
            btnSessions.Size = new Size(104, 23);
            btnSessions.TabIndex = 2;
            btnSessions.Text = "Treningi/Zajęcia";
            btnSessions.UseVisualStyleBackColor = true;
            btnSessions.Click += btnSessions_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Panel Główny";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 359);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Użytkownicy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 359);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Grupy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 359);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Treningi/Zajęcia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 40);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 7;
            label5.Text = "Wyloguj";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(672, 36);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(104, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Wyloguj";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(355, 520);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(104, 23);
            btnPayments.TabIndex = 9;
            btnPayments.Text = "Płatności";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 486);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Płatności";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(191, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 224);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MainPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnPayments);
            Controls.Add(btnLogout);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSessions);
            Controls.Add(btnGroups);
            Controls.Add(btnUsers);
            Name = "MainPanelForm";
            Text = "MainPanelForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsers;
        private Button btnGroups;
        private Button btnSessions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLogout;
        private Button btnPayments;
        private Label label6;
        private PictureBox pictureBox1;
    }
}