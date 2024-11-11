namespace HMS.User_Control
{
    partial class UserControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            buttonAdd = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            dataGridViewUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBoxSearchUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPageUADU = new TabPage();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            textBoxPassword1 = new TextBox();
            label6 = new Label();
            textBoxUsername1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabPageUADU.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSearchUser);
            tabControlUser.Controls.Add(tabPageUADU);
            tabControlUser.Location = new Point(19, 42);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(1065, 399);
            tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(buttonAdd);
            tabPageAddUser.Controls.Add(textBoxPassword);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(textBoxUsername);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(1057, 369);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add User";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Leave += tabPageAddUser_Leave;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Black;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(168, 153);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 42);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(548, 111);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(264, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(548, 87);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(168, 111);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(264, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 0;
            label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(dataGridViewUser);
            tabPageSearchUser.Controls.Add(textBoxSearchUserName);
            tabPageSearchUser.Controls.Add(label5);
            tabPageSearchUser.Controls.Add(label4);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(1057, 369);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Search User";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            tabPageSearchUser.Enter += tabPageSearchUser_Enter;
            tabPageSearchUser.Leave += tabPageSearchUser_Leave;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewUser.Location = new Point(42, 109);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.Size = new Size(976, 226);
            dataGridViewUser.TabIndex = 4;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "User_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "User_Name";
            Column2.HeaderText = "Username";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "User_Password";
            Column3.HeaderText = "Password";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // textBoxSearchUserName
            // 
            textBoxSearchUserName.Location = new Point(171, 65);
            textBoxSearchUserName.Name = "textBoxSearchUserName";
            textBoxSearchUserName.Size = new Size(264, 23);
            textBoxSearchUserName.TabIndex = 3;
            textBoxSearchUserName.TextChanged += textBoxSearchUserName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(171, 43);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(102, 19);
            label4.TabIndex = 0;
            label4.Text = "Search User:";
            // 
            // tabPageUADU
            // 
            tabPageUADU.Controls.Add(buttonDelete);
            tabPageUADU.Controls.Add(buttonUpdate);
            tabPageUADU.Controls.Add(textBoxPassword1);
            tabPageUADU.Controls.Add(label6);
            tabPageUADU.Controls.Add(textBoxUsername1);
            tabPageUADU.Controls.Add(label7);
            tabPageUADU.Controls.Add(label8);
            tabPageUADU.Cursor = Cursors.Hand;
            tabPageUADU.Location = new Point(4, 4);
            tabPageUADU.Name = "tabPageUADU";
            tabPageUADU.Padding = new Padding(3);
            tabPageUADU.Size = new Size(1057, 371);
            tabPageUADU.TabIndex = 2;
            tabPageUADU.Text = "Update and Delete User";
            tabPageUADU.UseVisualStyleBackColor = true;
            tabPageUADU.Leave += tabPageUADU_Leave;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(300, 152);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 45);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(166, 152);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(121, 45);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.Location = new Point(546, 110);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.Size = new Size(264, 23);
            textBoxPassword1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(546, 86);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 4;
            label6.Text = "Password:";
            // 
            // textBoxUsername1
            // 
            textBoxUsername1.Location = new Point(166, 110);
            textBoxUsername1.Name = "textBoxUsername1";
            textBoxUsername1.Size = new Size(264, 23);
            textBoxUsername1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(166, 86);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 5;
            label7.Text = "Username:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(4, 5);
            label8.Name = "label8";
            label8.Size = new Size(194, 19);
            label8.TabIndex = 6;
            label8.Text = "Update and Delete User:";
            // 
            // UserControlSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlUser);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlSetting";
            Size = new Size(1102, 462);
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabPageUADU.ResumeLayout(false);
            tabPageUADU.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private TabPage tabPageSearchUser;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label1;
        private Button buttonAdd;
        private TextBox textBoxPassword;
        private Label label3;
        private DataGridView dataGridViewUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBoxSearchUserName;
        private Label label5;
        private Label label4;
        private TabPage tabPageUADU;
        private Button buttonUpdate;
        private TextBox textBoxPassword1;
        private Label label6;
        private TextBox textBoxUsername1;
        private Label label7;
        private Label label8;
        private Button buttonDelete;
    }
}
