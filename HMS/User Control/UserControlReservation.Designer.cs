namespace HMS.User_Control
{
    partial class UserControlReservation
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
            tabControlReservation = new TabControl();
            tabPageAddReservation = new TabPage();
            dateTimePickerOut = new DateTimePicker();
            label7 = new Label();
            dateTimePickerIn = new DateTimePicker();
            comboBoxNo = new ComboBox();
            comboBoxType = new ComboBox();
            label8 = new Label();
            textBoxClientID = new TextBox();
            label9 = new Label();
            buttonAdd = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tabPageSearchReservation = new TabPage();
            dataGridViewReservation = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBoxSearchClientID = new TextBox();
            label13 = new Label();
            label14 = new Label();
            tabPageUpdateAndCancelReservation = new TabPage();
            buttonCancel = new Button();
            dateTimePickerOut1 = new DateTimePicker();
            label6 = new Label();
            dateTimePickerIn1 = new DateTimePicker();
            comboBoxNo1 = new ComboBox();
            comboBoxType1 = new ComboBox();
            label5 = new Label();
            textBoxClientID1 = new TextBox();
            label4 = new Label();
            buttonUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControlReservation.SuspendLayout();
            tabPageAddReservation.SuspendLayout();
            tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
            tabPageUpdateAndCancelReservation.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReservation
            // 
            tabControlReservation.Alignment = TabAlignment.Bottom;
            tabControlReservation.Anchor = AnchorStyles.None;
            tabControlReservation.Controls.Add(tabPageAddReservation);
            tabControlReservation.Controls.Add(tabPageSearchReservation);
            tabControlReservation.Controls.Add(tabPageUpdateAndCancelReservation);
            tabControlReservation.Location = new Point(19, 42);
            tabControlReservation.Name = "tabControlReservation";
            tabControlReservation.SelectedIndex = 0;
            tabControlReservation.Size = new Size(1065, 399);
            tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            tabPageAddReservation.Controls.Add(dateTimePickerOut);
            tabPageAddReservation.Controls.Add(label7);
            tabPageAddReservation.Controls.Add(dateTimePickerIn);
            tabPageAddReservation.Controls.Add(comboBoxNo);
            tabPageAddReservation.Controls.Add(comboBoxType);
            tabPageAddReservation.Controls.Add(label8);
            tabPageAddReservation.Controls.Add(textBoxClientID);
            tabPageAddReservation.Controls.Add(label9);
            tabPageAddReservation.Controls.Add(buttonAdd);
            tabPageAddReservation.Controls.Add(label10);
            tabPageAddReservation.Controls.Add(label11);
            tabPageAddReservation.Controls.Add(label12);
            tabPageAddReservation.Location = new Point(4, 4);
            tabPageAddReservation.Name = "tabPageAddReservation";
            tabPageAddReservation.Padding = new Padding(3);
            tabPageAddReservation.Size = new Size(1057, 369);
            tabPageAddReservation.TabIndex = 0;
            tabPageAddReservation.Text = "Add Reservation";
            tabPageAddReservation.UseVisualStyleBackColor = true;
            tabPageAddReservation.Leave += tabPageAddReservation_Leave;
            // 
            // dateTimePickerOut
            // 
            dateTimePickerOut.Location = new Point(545, 195);
            dateTimePickerOut.Name = "dateTimePickerOut";
            dateTimePickerOut.Size = new Size(264, 23);
            dateTimePickerOut.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(545, 171);
            label7.Name = "label7";
            label7.Size = new Size(34, 16);
            label7.TabIndex = 0;
            label7.Text = "Out:";
            // 
            // dateTimePickerIn
            // 
            dateTimePickerIn.Location = new Point(165, 195);
            dateTimePickerIn.Name = "dateTimePickerIn";
            dateTimePickerIn.Size = new Size(264, 23);
            dateTimePickerIn.TabIndex = 4;
            // 
            // comboBoxNo
            // 
            comboBoxNo.Anchor = AnchorStyles.None;
            comboBoxNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNo.FlatStyle = FlatStyle.Flat;
            comboBoxNo.FormattingEnabled = true;
            comboBoxNo.Items.AddRange(new object[] { "Please Select" });
            comboBoxNo.Location = new Point(545, 68);
            comboBoxNo.Name = "comboBoxNo";
            comboBoxNo.Size = new Size(264, 25);
            comboBoxNo.TabIndex = 2;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.None;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Please Select", "Single", "Couple", "Family", "Suite" });
            comboBoxType.Location = new Point(165, 68);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(264, 25);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(165, 171);
            label8.Name = "label8";
            label8.Size = new Size(23, 16);
            label8.TabIndex = 0;
            label8.Text = "In:";
            // 
            // textBoxClientID
            // 
            textBoxClientID.Location = new Point(165, 130);
            textBoxClientID.Name = "textBoxClientID";
            textBoxClientID.Size = new Size(264, 23);
            textBoxClientID.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(165, 111);
            label9.Name = "label9";
            label9.Size = new Size(66, 16);
            label9.TabIndex = 0;
            label9.Text = "Client ID:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Black;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(165, 246);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 42);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(545, 44);
            label10.Name = "label10";
            label10.Size = new Size(73, 16);
            label10.TabIndex = 0;
            label10.Text = "Room No.:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(165, 44);
            label11.Name = "label11";
            label11.Size = new Size(82, 16);
            label11.TabIndex = 0;
            label11.Text = "Room Type:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(139, 19);
            label12.TabIndex = 0;
            label12.Text = "Add Reservation:";
            // 
            // tabPageSearchReservation
            // 
            tabPageSearchReservation.Controls.Add(dataGridViewReservation);
            tabPageSearchReservation.Controls.Add(textBoxSearchClientID);
            tabPageSearchReservation.Controls.Add(label13);
            tabPageSearchReservation.Controls.Add(label14);
            tabPageSearchReservation.Location = new Point(4, 4);
            tabPageSearchReservation.Name = "tabPageSearchReservation";
            tabPageSearchReservation.Padding = new Padding(3);
            tabPageSearchReservation.Size = new Size(1057, 369);
            tabPageSearchReservation.TabIndex = 1;
            tabPageSearchReservation.Text = "Search Reservation";
            tabPageSearchReservation.UseVisualStyleBackColor = true;
            tabPageSearchReservation.Enter += tabPageSearchReservation_Enter;
            tabPageSearchReservation.Leave += tabPageSearchReservation_Leave;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewReservation.Anchor = AnchorStyles.None;
            dataGridViewReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservation.BorderStyle = BorderStyle.None;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewReservation.Location = new Point(41, 90);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.Size = new Size(976, 226);
            dataGridViewReservation.TabIndex = 0;
            dataGridViewReservation.CellClick += dataGridViewReservation_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Reservation_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Reservation_Room_Type";
            Column2.HeaderText = "Room Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Reservation_Room_Number";
            Column3.HeaderText = "Room No.";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Reservation_Client_ID";
            Column4.HeaderText = "Client ID";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Reservation_In";
            Column5.HeaderText = "In";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Reservation_Out";
            Column6.HeaderText = "Out";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // textBoxSearchClientID
            // 
            textBoxSearchClientID.Location = new Point(166, 62);
            textBoxSearchClientID.Name = "textBoxSearchClientID";
            textBoxSearchClientID.Size = new Size(264, 23);
            textBoxSearchClientID.TabIndex = 1;
            textBoxSearchClientID.TextChanged += textBoxSearchClientID_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(166, 40);
            label13.Name = "label13";
            label13.Size = new Size(66, 16);
            label13.TabIndex = 0;
            label13.Text = "Client ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(3, 4);
            label14.Name = "label14";
            label14.Size = new Size(159, 19);
            label14.TabIndex = 0;
            label14.Text = "Search Reservation:";
            // 
            // tabPageUpdateAndCancelReservation
            // 
            tabPageUpdateAndCancelReservation.Controls.Add(buttonCancel);
            tabPageUpdateAndCancelReservation.Controls.Add(dateTimePickerOut1);
            tabPageUpdateAndCancelReservation.Controls.Add(label6);
            tabPageUpdateAndCancelReservation.Controls.Add(dateTimePickerIn1);
            tabPageUpdateAndCancelReservation.Controls.Add(comboBoxNo1);
            tabPageUpdateAndCancelReservation.Controls.Add(comboBoxType1);
            tabPageUpdateAndCancelReservation.Controls.Add(label5);
            tabPageUpdateAndCancelReservation.Controls.Add(textBoxClientID1);
            tabPageUpdateAndCancelReservation.Controls.Add(label4);
            tabPageUpdateAndCancelReservation.Controls.Add(buttonUpdate);
            tabPageUpdateAndCancelReservation.Controls.Add(label3);
            tabPageUpdateAndCancelReservation.Controls.Add(label2);
            tabPageUpdateAndCancelReservation.Controls.Add(label1);
            tabPageUpdateAndCancelReservation.Location = new Point(4, 4);
            tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            tabPageUpdateAndCancelReservation.Padding = new Padding(3);
            tabPageUpdateAndCancelReservation.Size = new Size(1057, 369);
            tabPageUpdateAndCancelReservation.TabIndex = 2;
            tabPageUpdateAndCancelReservation.Text = "Update and Cancel Reservation";
            tabPageUpdateAndCancelReservation.UseVisualStyleBackColor = true;
            tabPageUpdateAndCancelReservation.Leave += tabPageUpdateAndCancelReservation_Leave;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(305, 247);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 42);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerOut1
            // 
            dateTimePickerOut1.Location = new Point(545, 196);
            dateTimePickerOut1.Name = "dateTimePickerOut1";
            dateTimePickerOut1.Size = new Size(264, 23);
            dateTimePickerOut1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(545, 172);
            label6.Name = "label6";
            label6.Size = new Size(34, 16);
            label6.TabIndex = 0;
            label6.Text = "Out:";
            // 
            // dateTimePickerIn1
            // 
            dateTimePickerIn1.Location = new Point(165, 196);
            dateTimePickerIn1.Name = "dateTimePickerIn1";
            dateTimePickerIn1.Size = new Size(264, 23);
            dateTimePickerIn1.TabIndex = 4;
            // 
            // comboBoxNo1
            // 
            comboBoxNo1.Anchor = AnchorStyles.None;
            comboBoxNo1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNo1.FlatStyle = FlatStyle.Flat;
            comboBoxNo1.FormattingEnabled = true;
            comboBoxNo1.Items.AddRange(new object[] { "Please Select" });
            comboBoxNo1.Location = new Point(545, 57);
            comboBoxNo1.Name = "comboBoxNo1";
            comboBoxNo1.Size = new Size(264, 25);
            comboBoxNo1.TabIndex = 2;
            // 
            // comboBoxType1
            // 
            comboBoxType1.Anchor = AnchorStyles.None;
            comboBoxType1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType1.FlatStyle = FlatStyle.Flat;
            comboBoxType1.FormattingEnabled = true;
            comboBoxType1.Items.AddRange(new object[] { "Please Select", "Single", "Couple", "Family", "Suite" });
            comboBoxType1.Location = new Point(165, 57);
            comboBoxType1.Name = "comboBoxType1";
            comboBoxType1.Size = new Size(264, 25);
            comboBoxType1.TabIndex = 1;
            comboBoxType1.SelectedIndexChanged += comboBoxType1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(165, 172);
            label5.Name = "label5";
            label5.Size = new Size(23, 16);
            label5.TabIndex = 0;
            label5.Text = "In:";
            // 
            // textBoxClientID1
            // 
            textBoxClientID1.Location = new Point(165, 131);
            textBoxClientID1.Name = "textBoxClientID1";
            textBoxClientID1.Size = new Size(264, 23);
            textBoxClientID1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 112);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 0;
            label4.Text = "Client ID:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(165, 247);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(124, 42);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(545, 45);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 0;
            label3.Text = "Room No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 45);
            label2.Name = "label2";
            label2.Size = new Size(82, 16);
            label2.TabIndex = 0;
            label2.Text = "Room Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(259, 19);
            label1.TabIndex = 0;
            label1.Text = "Update and Cancel Reservation:";
            // 
            // UserControlReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlReservation);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlReservation";
            Size = new Size(1102, 462);
            Load += UserControlReservation_Load;
            tabControlReservation.ResumeLayout(false);
            tabPageAddReservation.ResumeLayout(false);
            tabPageAddReservation.PerformLayout();
            tabPageSearchReservation.ResumeLayout(false);
            tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            tabPageUpdateAndCancelReservation.ResumeLayout(false);
            tabPageUpdateAndCancelReservation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReservation;
        private TabPage tabPageAddReservation;
        private TabPage tabPageSearchReservation;
        private DateTimePicker dateTimePickerOut;
        private Label label7;
        private DateTimePicker dateTimePickerIn;
        private ComboBox comboBoxNo;
        private ComboBox comboBoxType;
        private Label label8;
        private TextBox textBoxClientID;
        private Label label9;
        private Button buttonAdd;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dataGridViewReservation;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBoxSearchClientID;
        private Label label13;
        private Label label14;
        private TabPage tabPageUpdateAndCancelReservation;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerOut1;
        private Label label6;
        private DateTimePicker dateTimePickerIn1;
        private ComboBox comboBoxNo1;
        private ComboBox comboBoxType1;
        private Label label5;
        private TextBox textBoxClientID1;
        private Label label4;
        private Button buttonUpdate;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
