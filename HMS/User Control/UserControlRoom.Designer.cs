namespace HMS.User_Control
{
    partial class UserControlRoom
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
            tabControlRoom = new TabControl();
            tabPageAddRoom = new TabPage();
            radioButtonNo = new RadioButton();
            radioButtonYes = new RadioButton();
            label4 = new Label();
            comboBoxType = new ComboBox();
            buttonAdd = new Button();
            textBoxPhoneNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchRoom = new TabPage();
            dataGridViewRoom = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBoxSearchRoomNo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPageUpdateAndDeleteRoom = new TabPage();
            buttonDelete = new Button();
            radioButtonNo1 = new RadioButton();
            radioButtonYes1 = new RadioButton();
            label5 = new Label();
            comboBoxType1 = new ComboBox();
            buttonUpdate = new Button();
            textBoxPhoneNo1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabControlRoom.SuspendLayout();
            tabPageAddRoom.SuspendLayout();
            tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            tabPageUpdateAndDeleteRoom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRoom
            // 
            tabControlRoom.Alignment = TabAlignment.Bottom;
            tabControlRoom.Anchor = AnchorStyles.None;
            tabControlRoom.Controls.Add(tabPageAddRoom);
            tabControlRoom.Controls.Add(tabPageSearchRoom);
            tabControlRoom.Controls.Add(tabPageUpdateAndDeleteRoom);
            tabControlRoom.Location = new Point(19, 42);
            tabControlRoom.Name = "tabControlRoom";
            tabControlRoom.SelectedIndex = 0;
            tabControlRoom.Size = new Size(1065, 399);
            tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            tabPageAddRoom.Controls.Add(radioButtonNo);
            tabPageAddRoom.Controls.Add(radioButtonYes);
            tabPageAddRoom.Controls.Add(label4);
            tabPageAddRoom.Controls.Add(comboBoxType);
            tabPageAddRoom.Controls.Add(buttonAdd);
            tabPageAddRoom.Controls.Add(textBoxPhoneNo);
            tabPageAddRoom.Controls.Add(label3);
            tabPageAddRoom.Controls.Add(label2);
            tabPageAddRoom.Controls.Add(label1);
            tabPageAddRoom.Location = new Point(4, 4);
            tabPageAddRoom.Name = "tabPageAddRoom";
            tabPageAddRoom.Padding = new Padding(3);
            tabPageAddRoom.Size = new Size(1057, 369);
            tabPageAddRoom.TabIndex = 0;
            tabPageAddRoom.Text = "Add Room";
            tabPageAddRoom.UseVisualStyleBackColor = true;
            tabPageAddRoom.Leave += tabPageAddRoom_Leave;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(220, 184);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(45, 21);
            radioButtonNo.TabIndex = 4;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(220, 157);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(46, 21);
            radioButtonYes.TabIndex = 3;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 172);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 0;
            label4.Text = "Free:";
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.None;
            comboBoxType.Cursor = Cursors.Hand;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Please Select", "Single", "Couple", "Family", "Suite" });
            comboBoxType.Location = new Point(166, 110);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(275, 25);
            comboBoxType.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Black;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(166, 239);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 42);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.Location = new Point(546, 110);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new Size(264, 23);
            textBoxPhoneNo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(546, 86);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 0;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 86);
            label2.Name = "label2";
            label2.Size = new Size(42, 16);
            label2.TabIndex = 0;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 6;
            label1.Text = "Add Room:";
            // 
            // tabPageSearchRoom
            // 
            tabPageSearchRoom.Controls.Add(dataGridViewRoom);
            tabPageSearchRoom.Controls.Add(textBoxSearchRoomNo);
            tabPageSearchRoom.Controls.Add(label6);
            tabPageSearchRoom.Controls.Add(label7);
            tabPageSearchRoom.Location = new Point(4, 4);
            tabPageSearchRoom.Name = "tabPageSearchRoom";
            tabPageSearchRoom.Padding = new Padding(3);
            tabPageSearchRoom.Size = new Size(1057, 371);
            tabPageSearchRoom.TabIndex = 1;
            tabPageSearchRoom.Text = "Search Room";
            tabPageSearchRoom.UseVisualStyleBackColor = true;
            tabPageSearchRoom.TextChanged += tabPageSearchRoom_TextChanged;
            tabPageSearchRoom.Enter += tabPageSearchRoom_Enter;
            tabPageSearchRoom.Leave += tabPageSearchRoom_Leave;
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.AllowUserToAddRows = false;
            dataGridViewRoom.AllowUserToDeleteRows = false;
            dataGridViewRoom.Anchor = AnchorStyles.None;
            dataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoom.BorderStyle = BorderStyle.None;
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewRoom.Location = new Point(42, 89);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.ReadOnly = true;
            dataGridViewRoom.Size = new Size(976, 226);
            dataGridViewRoom.TabIndex = 2;
            dataGridViewRoom.CellClick += dataGridViewRoom_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Room_Number";
            Column1.HeaderText = "No.";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Room_Type";
            Column2.HeaderText = "Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Room_Phone";
            Column3.HeaderText = "Phone";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Room_Free";
            Column4.HeaderText = "Is Free?";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // textBoxSearchRoomNo
            // 
            textBoxSearchRoomNo.Location = new Point(167, 62);
            textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            textBoxSearchRoomNo.Size = new Size(264, 23);
            textBoxSearchRoomNo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(167, 40);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 3;
            label6.Text = "Room No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(4, 4);
            label7.Name = "label7";
            label7.Size = new Size(116, 19);
            label7.TabIndex = 4;
            label7.Text = "Search Room:";
            // 
            // tabPageUpdateAndDeleteRoom
            // 
            tabPageUpdateAndDeleteRoom.Controls.Add(buttonDelete);
            tabPageUpdateAndDeleteRoom.Controls.Add(radioButtonNo1);
            tabPageUpdateAndDeleteRoom.Controls.Add(radioButtonYes1);
            tabPageUpdateAndDeleteRoom.Controls.Add(label5);
            tabPageUpdateAndDeleteRoom.Controls.Add(comboBoxType1);
            tabPageUpdateAndDeleteRoom.Controls.Add(buttonUpdate);
            tabPageUpdateAndDeleteRoom.Controls.Add(textBoxPhoneNo1);
            tabPageUpdateAndDeleteRoom.Controls.Add(label8);
            tabPageUpdateAndDeleteRoom.Controls.Add(label9);
            tabPageUpdateAndDeleteRoom.Controls.Add(label10);
            tabPageUpdateAndDeleteRoom.Location = new Point(4, 4);
            tabPageUpdateAndDeleteRoom.Name = "tabPageUpdateAndDeleteRoom";
            tabPageUpdateAndDeleteRoom.Padding = new Padding(3);
            tabPageUpdateAndDeleteRoom.Size = new Size(1057, 369);
            tabPageUpdateAndDeleteRoom.TabIndex = 2;
            tabPageUpdateAndDeleteRoom.Text = "Update and Delete Room";
            tabPageUpdateAndDeleteRoom.UseVisualStyleBackColor = true;
            tabPageUpdateAndDeleteRoom.Leave += tabPageUpdateAndDeleteRoom_Leave;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(304, 238);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(124, 42);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // radioButtonNo1
            // 
            radioButtonNo1.AutoSize = true;
            radioButtonNo1.Location = new Point(220, 183);
            radioButtonNo1.Name = "radioButtonNo1";
            radioButtonNo1.Size = new Size(45, 21);
            radioButtonNo1.TabIndex = 4;
            radioButtonNo1.TabStop = true;
            radioButtonNo1.Text = "No";
            radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            radioButtonYes1.AutoSize = true;
            radioButtonYes1.Location = new Point(220, 156);
            radioButtonYes1.Name = "radioButtonYes1";
            radioButtonYes1.Size = new Size(46, 21);
            radioButtonYes1.TabIndex = 3;
            radioButtonYes1.TabStop = true;
            radioButtonYes1.Text = "Yes";
            radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 171);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 0;
            label5.Text = "Free:";
            // 
            // comboBoxType1
            // 
            comboBoxType1.Anchor = AnchorStyles.None;
            comboBoxType1.Cursor = Cursors.Hand;
            comboBoxType1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType1.FlatStyle = FlatStyle.Flat;
            comboBoxType1.FormattingEnabled = true;
            comboBoxType1.Items.AddRange(new object[] { "Please Select", "Single", "Couple", "Family", "Suite" });
            comboBoxType1.Location = new Point(166, 99);
            comboBoxType1.Name = "comboBoxType1";
            comboBoxType1.Size = new Size(275, 25);
            comboBoxType1.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(166, 238);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(124, 42);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxPhoneNo1
            // 
            textBoxPhoneNo1.Location = new Point(546, 109);
            textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            textBoxPhoneNo1.Size = new Size(264, 23);
            textBoxPhoneNo1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(546, 85);
            label8.Name = "label8";
            label8.Size = new Size(50, 16);
            label8.TabIndex = 0;
            label8.Text = "Phone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(166, 85);
            label9.Name = "label9";
            label9.Size = new Size(42, 16);
            label9.TabIndex = 0;
            label9.Text = "Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(4, 4);
            label10.Name = "label10";
            label10.Size = new Size(208, 19);
            label10.TabIndex = 0;
            label10.Text = "Update and Delete Room:";
            // 
            // UserControlRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlRoom);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlRoom";
            Size = new Size(1102, 462);
            Load += UserControlRoom_Load;
            tabControlRoom.ResumeLayout(false);
            tabPageAddRoom.ResumeLayout(false);
            tabPageAddRoom.PerformLayout();
            tabPageSearchRoom.ResumeLayout(false);
            tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            tabPageUpdateAndDeleteRoom.ResumeLayout(false);
            tabPageUpdateAndDeleteRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRoom;
        private TabPage tabPageAddRoom;
        private TabPage tabPageSearchRoom;
        private TabPage tabPageUpdateAndDeleteRoom;
        private Button buttonAdd;
        private TextBox textBoxPhoneNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxType;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonYes;
        private Label label4;
        private DataGridView dataGridViewRoom;
        private TextBox textBoxSearchRoomNo;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button buttonDelete;
        private RadioButton radioButtonNo1;
        private RadioButton radioButtonYes1;
        private Label label5;
        private ComboBox comboBoxType1;
        private Button buttonUpdate;
        private TextBox textBoxPhoneNo1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
