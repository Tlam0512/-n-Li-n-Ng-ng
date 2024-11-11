namespace HMS.User_Control
{
    partial class UserControlClient
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
            tabControlClient = new TabControl();
            tabPageAddClient = new TabPage();
            textBoxAddress = new TextBox();
            label5 = new Label();
            textBoxPhoneNo = new TextBox();
            label4 = new Label();
            buttonAdd = new Button();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchClient = new TabPage();
            dataGridViewClient = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBoxSearchPhoneNumber = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPageUpdateAndDeleteClient = new TabPage();
            buttonDelete = new Button();
            textBoxAddress1 = new TextBox();
            label8 = new Label();
            textBoxPhoneNo1 = new TextBox();
            label9 = new Label();
            buttonUpdate = new Button();
            textBoxLastName1 = new TextBox();
            label10 = new Label();
            textBoxFirstName1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tabControlClient.SuspendLayout();
            tabPageAddClient.SuspendLayout();
            tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            tabPageUpdateAndDeleteClient.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Alignment = TabAlignment.Bottom;
            tabControlClient.Anchor = AnchorStyles.None;
            tabControlClient.Controls.Add(tabPageAddClient);
            tabControlClient.Controls.Add(tabPageSearchClient);
            tabControlClient.Controls.Add(tabPageUpdateAndDeleteClient);
            tabControlClient.Location = new Point(19, 42);
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(1065, 399);
            tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            tabPageAddClient.Controls.Add(textBoxAddress);
            tabPageAddClient.Controls.Add(label5);
            tabPageAddClient.Controls.Add(textBoxPhoneNo);
            tabPageAddClient.Controls.Add(label4);
            tabPageAddClient.Controls.Add(buttonAdd);
            tabPageAddClient.Controls.Add(textBoxLastName);
            tabPageAddClient.Controls.Add(label3);
            tabPageAddClient.Controls.Add(textBoxFirstName);
            tabPageAddClient.Controls.Add(label2);
            tabPageAddClient.Controls.Add(label1);
            tabPageAddClient.Location = new Point(4, 4);
            tabPageAddClient.Name = "tabPageAddClient";
            tabPageAddClient.Padding = new Padding(3);
            tabPageAddClient.Size = new Size(1057, 369);
            tabPageAddClient.TabIndex = 0;
            tabPageAddClient.Text = "Add Client";
            tabPageAddClient.UseVisualStyleBackColor = true;
            tabPageAddClient.Leave += tabPageAddClient_Leave;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(169, 199);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(644, 71);
            textBoxAddress.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(169, 175);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 0;
            label5.Text = "Address:";
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Location = new Point(169, 134);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(264, 23);
            textBoxPhoneNo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 115);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 0;
            label4.Text = "Phone No.:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Black;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(169, 276);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 42);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(549, 72);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(264, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(549, 48);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(169, 72);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(264, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 48);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 0;
            label1.Text = "Add Client:";
            // 
            // tabPageSearchClient
            // 
            tabPageSearchClient.Controls.Add(dataGridViewClient);
            tabPageSearchClient.Controls.Add(textBoxSearchPhoneNumber);
            tabPageSearchClient.Controls.Add(label6);
            tabPageSearchClient.Controls.Add(label7);
            tabPageSearchClient.Location = new Point(4, 4);
            tabPageSearchClient.Name = "tabPageSearchClient";
            tabPageSearchClient.Padding = new Padding(3);
            tabPageSearchClient.Size = new Size(1057, 369);
            tabPageSearchClient.TabIndex = 1;
            tabPageSearchClient.Text = "Search Client";
            tabPageSearchClient.UseVisualStyleBackColor = true;
            tabPageSearchClient.Enter += tabPageSearchClient_Enter;
            tabPageSearchClient.Leave += tabPageSearchClient_Leave;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.AllowUserToAddRows = false;
            dataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewClient.Anchor = AnchorStyles.None;
            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClient.BorderStyle = BorderStyle.None;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewClient.Location = new Point(46, 92);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.Size = new Size(976, 226);
            dataGridViewClient.TabIndex = 0;
            dataGridViewClient.CellClick += dataGridViewClient_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Client_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Client_FirstName";
            Column2.HeaderText = "First Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Client_LastName";
            Column3.HeaderText = "Last Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Client_Phone";
            Column4.HeaderText = "Phone No.";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Client_Address";
            Column5.HeaderText = "Address";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // textBoxSearchPhoneNumber
            // 
            textBoxSearchPhoneNumber.Location = new Point(171, 64);
            textBoxSearchPhoneNumber.Name = "textBoxSearchPhoneNumber";
            textBoxSearchPhoneNumber.Size = new Size(264, 23);
            textBoxSearchPhoneNumber.TabIndex = 1;
            textBoxSearchPhoneNumber.TextChanged += textBoxSearchPhoneNumber_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(171, 42);
            label6.Name = "label6";
            label6.Size = new Size(76, 16);
            label6.TabIndex = 0;
            label6.Text = "Phone No.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(8, 6);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 0;
            label7.Text = "Search Client:";
            // 
            // tabPageUpdateAndDeleteClient
            // 
            tabPageUpdateAndDeleteClient.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxAddress1);
            tabPageUpdateAndDeleteClient.Controls.Add(label8);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxPhoneNo1);
            tabPageUpdateAndDeleteClient.Controls.Add(label9);
            tabPageUpdateAndDeleteClient.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxLastName1);
            tabPageUpdateAndDeleteClient.Controls.Add(label10);
            tabPageUpdateAndDeleteClient.Controls.Add(textBoxFirstName1);
            tabPageUpdateAndDeleteClient.Controls.Add(label11);
            tabPageUpdateAndDeleteClient.Controls.Add(label12);
            tabPageUpdateAndDeleteClient.Location = new Point(4, 4);
            tabPageUpdateAndDeleteClient.Name = "tabPageUpdateAndDeleteClient";
            tabPageUpdateAndDeleteClient.Padding = new Padding(3);
            tabPageUpdateAndDeleteClient.Size = new Size(1057, 371);
            tabPageUpdateAndDeleteClient.TabIndex = 2;
            tabPageUpdateAndDeleteClient.Text = "Update and Delete Client";
            tabPageUpdateAndDeleteClient.UseVisualStyleBackColor = true;
            tabPageUpdateAndDeleteClient.Leave += tabPageUpdateAndDeleteClient_Leave;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(308, 283);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(124, 42);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxAddress1
            // 
            textBoxAddress1.Location = new Point(168, 200);
            textBoxAddress1.Multiline = true;
            textBoxAddress1.Name = "textBoxAddress1";
            textBoxAddress1.Size = new Size(644, 71);
            textBoxAddress1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(168, 176);
            label8.Name = "label8";
            label8.Size = new Size(64, 16);
            label8.TabIndex = 0;
            label8.Text = "Address:";
            // 
            // textBoxPhoneNo1
            // 
            textBoxPhoneNo1.Location = new Point(168, 135);
            textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            textBoxPhoneNo1.Size = new Size(264, 23);
            textBoxPhoneNo1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(168, 116);
            label9.Name = "label9";
            label9.Size = new Size(76, 16);
            label9.TabIndex = 10;
            label9.Text = "Phone No.:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(168, 283);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(124, 42);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxLastName1
            // 
            textBoxLastName1.Location = new Point(548, 73);
            textBoxLastName1.Name = "textBoxLastName1";
            textBoxLastName1.Size = new Size(264, 23);
            textBoxLastName1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(548, 49);
            label10.Name = "label10";
            label10.Size = new Size(79, 16);
            label10.TabIndex = 0;
            label10.Text = "Last Name:";
            // 
            // textBoxFirstName1
            // 
            textBoxFirstName1.Location = new Point(168, 73);
            textBoxFirstName1.Name = "textBoxFirstName1";
            textBoxFirstName1.Size = new Size(264, 23);
            textBoxFirstName1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(168, 49);
            label11.Name = "label11";
            label11.Size = new Size(79, 16);
            label11.TabIndex = 10;
            label11.Text = "First Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(6, 8);
            label12.Name = "label12";
            label12.Size = new Size(207, 19);
            label12.TabIndex = 0;
            label12.Text = "Update and Delete Client:";
            // 
            // UserControlClient
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlClient";
            Size = new Size(1102, 462);
            tabControlClient.ResumeLayout(false);
            tabPageAddClient.ResumeLayout(false);
            tabPageAddClient.PerformLayout();
            tabPageSearchClient.ResumeLayout(false);
            tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            tabPageUpdateAndDeleteClient.ResumeLayout(false);
            tabPageUpdateAndDeleteClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlClient;
        private TabPage tabPageAddClient;
        private TabPage tabPageSearchClient;
        private Button buttonAdd;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label2;
        private Label label1;
        private TextBox textBoxAddress;
        private Label label5;
        private TextBox textBoxPhoneNo;
        private Label label4;
        private TabPage tabPageUpdateAndDeleteClient;
        private DataGridView dataGridViewClient;
        private TextBox textBoxSearchPhoneNumber;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button buttonDelete;
        private TextBox textBoxAddress1;
        private Label label8;
        private TextBox textBoxPhoneNo1;
        private Label label9;
        private Button buttonUpdate;
        private TextBox textBoxLastName1;
        private Label label10;
        private TextBox textBoxFirstName1;
        private Label label11;
        private Label label12;
    }
}
