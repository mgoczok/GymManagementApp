namespace GymManagementApp.Forms
{
    partial class GroupManagementForm
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
            buttonAddGroup = new Button();
            textBoxGroupDescription = new TextBox();
            textBoxGroupName = new TextBox();
            GroupName = new Label();
            GroupDescription = new Label();
            buttonDeleteGroup = new Button();
            buttonRefresh = new Button();
            dataGridViewGroups = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).BeginInit();
            SuspendLayout();
            // 
            // buttonAddGroup
            // 
            buttonAddGroup.Location = new Point(130, 184);
            buttonAddGroup.Name = "buttonAddGroup";
            buttonAddGroup.Size = new Size(115, 49);
            buttonAddGroup.TabIndex = 0;
            buttonAddGroup.Text = "Dodaj";
            buttonAddGroup.UseVisualStyleBackColor = true;
            buttonAddGroup.Click += buttonAddGroup_Click;
            // 
            // textBoxGroupDescription
            // 
            textBoxGroupDescription.Location = new Point(260, 104);
            textBoxGroupDescription.Name = "textBoxGroupDescription";
            textBoxGroupDescription.Size = new Size(100, 23);
            textBoxGroupDescription.TabIndex = 2;
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Location = new Point(130, 104);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(100, 23);
            textBoxGroupName.TabIndex = 7;
            // 
            // GroupName
            // 
            GroupName.AutoSize = true;
            GroupName.Location = new Point(142, 86);
            GroupName.Name = "GroupName";
            GroupName.Size = new Size(79, 15);
            GroupName.TabIndex = 8;
            GroupName.Text = "Nazwa grupy:";
            // 
            // GroupDescription
            // 
            GroupDescription.AutoSize = true;
            GroupDescription.Location = new Point(273, 86);
            GroupDescription.Name = "GroupDescription";
            GroupDescription.Size = new Size(34, 15);
            GroupDescription.TabIndex = 9;
            GroupDescription.Text = "Opis:";
            // 
            // buttonDeleteGroup
            // 
            buttonDeleteGroup.Location = new Point(130, 258);
            buttonDeleteGroup.Name = "buttonDeleteGroup";
            buttonDeleteGroup.Size = new Size(115, 49);
            buttonDeleteGroup.TabIndex = 10;
            buttonDeleteGroup.Text = "Usuń";
            buttonDeleteGroup.UseVisualStyleBackColor = true;
            buttonDeleteGroup.Click += buttonDeleteGroup_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(130, 331);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(115, 49);
            buttonRefresh.TabIndex = 11;
            buttonRefresh.Text = "Odśwież";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroups.Location = new Point(336, 184);
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.Size = new Size(424, 150);
            dataGridViewGroups.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 14;
            label1.Text = "Grupy ";
            // 
            // button2
            // 
            button2.Location = new Point(669, 37);
            button2.Name = "button2";
            button2.Size = new Size(91, 38);
            button2.TabIndex = 15;
            button2.Text = "Powrót";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GroupManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridViewGroups);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDeleteGroup);
            Controls.Add(GroupDescription);
            Controls.Add(GroupName);
            Controls.Add(textBoxGroupName);
            Controls.Add(textBoxGroupDescription);
            Controls.Add(buttonAddGroup);
            Name = "GroupManagementForm";
            Text = "KFIT - Grupy";
            Load += GroupManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddGroup;
        private TextBox textBoxGroupDescription;
        private TextBox textBoxGroupName;
        private Label GroupName;
        private Label GroupDescription;
        private Button buttonDeleteGroup;
        private Button buttonRefresh;
        private DataGridView dataGridViewGroups;
        private Label label1;
        private Button button2;
    }
}