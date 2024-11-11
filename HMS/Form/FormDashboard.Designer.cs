namespace HMS
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            panelSlide = new Panel();
            buttonSetting = new Button();
            buttonReservation = new Button();
            buttonRoom = new Button();
            buttonClient = new Button();
            buttonDashboard = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            labelUsername = new Label();
            label5 = new Label();
            panel4 = new Panel();
            labelDateTime = new Label();
            linkLabelLogOut = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            userControlSetting1 = new User_Control.UserControlSetting();
            userControlClient1 = new User_Control.UserControlClient();
            userControlRoom1 = new User_Control.UserControlRoom();
            userControlReservation1 = new User_Control.UserControlReservation();
            userControlDashboard1 = new User_Control.UserControlDashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 15, 43);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(buttonSetting);
            panel1.Controls.Add(buttonReservation);
            panel1.Controls.Add(buttonRoom);
            panel1.Controls.Add(buttonClient);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 681);
            panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(19, 226);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(6, 50);
            panelSlide.TabIndex = 0;
            // 
            // buttonSetting
            // 
            buttonSetting.Cursor = Cursors.Hand;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSetting.ForeColor = Color.White;
            buttonSetting.Image = (Image)resources.GetObject("buttonSetting.Image");
            buttonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSetting.Location = new Point(39, 512);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(252, 50);
            buttonSetting.TabIndex = 5;
            buttonSetting.Text = "            Setting";
            buttonSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReservation
            // 
            buttonReservation.Cursor = Cursors.Hand;
            buttonReservation.FlatAppearance.BorderSize = 0;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReservation.ForeColor = Color.White;
            buttonReservation.Image = (Image)resources.GetObject("buttonReservation.Image");
            buttonReservation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReservation.Location = new Point(39, 441);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(252, 50);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "            Reservation";
            buttonReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.Cursor = Cursors.Hand;
            buttonRoom.FlatAppearance.BorderSize = 0;
            buttonRoom.FlatStyle = FlatStyle.Flat;
            buttonRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRoom.ForeColor = Color.White;
            buttonRoom.Image = (Image)resources.GetObject("buttonRoom.Image");
            buttonRoom.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRoom.Location = new Point(39, 366);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(252, 50);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "            Room";
            buttonRoom.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonClient
            // 
            buttonClient.Cursor = Cursors.Hand;
            buttonClient.FlatAppearance.BorderSize = 0;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClient.ForeColor = Color.White;
            buttonClient.Image = (Image)resources.GetObject("buttonClient.Image");
            buttonClient.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClient.Location = new Point(39, 295);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(252, 50);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "            Client";
            buttonClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = Properties.Resources.monitor1;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(39, 226);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(252, 50);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "            Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 15, 43);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 200);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(96, 148);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 120);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 0;
            label2.Text = "Hotel Management";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Untitled;
            pictureBox2.Location = new Point(26, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(7, 15, 43);
            panel3.Controls.Add(labelUsername);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(291, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1059, 200);
            panel3.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(138, 133);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(21, 23);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 133);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 0;
            label5.Text = "Welcome: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(labelDateTime);
            panel4.Controls.Add(linkLabelLogOut);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1059, 86);
            panel4.TabIndex = 0;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTime.ForeColor = Color.Black;
            labelDateTime.Location = new Point(6, 60);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(21, 23);
            labelDateTime.TabIndex = 1;
            labelDateTime.Text = "?";
            // 
            // linkLabelLogOut
            // 
            linkLabelLogOut.AutoSize = true;
            linkLabelLogOut.Cursor = Cursors.Hand;
            linkLabelLogOut.DisabledLinkColor = Color.Red;
            linkLabelLogOut.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogOut.LinkColor = Color.Red;
            linkLabelLogOut.Location = new Point(966, 53);
            linkLabelLogOut.Name = "linkLabelLogOut";
            linkLabelLogOut.Size = new Size(54, 16);
            linkLabelLogOut.TabIndex = 0;
            linkLabelLogOut.TabStop = true;
            linkLabelLogOut.Text = "Log out";
            linkLabelLogOut.VisitedLinkColor = Color.Red;
            linkLabelLogOut.LinkClicked += linkLabelLogOut_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources._128_1280406_view_user_icon_png_user_circle_icon_png;
            pictureBox1.Location = new Point(915, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(291, 626);
            panel5.Name = "panel5";
            panel5.Size = new Size(1059, 55);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "NHOM 3";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlSetting1
            // 
            userControlSetting1.BackColor = Color.White;
            userControlSetting1.Dock = DockStyle.Fill;
            userControlSetting1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlSetting1.Location = new Point(291, 200);
            userControlSetting1.Name = "userControlSetting1";
            userControlSetting1.Size = new Size(1059, 426);
            userControlSetting1.TabIndex = 1;
            userControlSetting1.Visible = false;
            // 
            // userControlClient1
            // 
            userControlClient1.BackColor = Color.White;
            userControlClient1.Dock = DockStyle.Fill;
            userControlClient1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlClient1.Location = new Point(291, 200);
            userControlClient1.Name = "userControlClient1";
            userControlClient1.Size = new Size(1059, 426);
            userControlClient1.TabIndex = 0;
            userControlClient1.Visible = false;
            // 
            // userControlRoom1
            // 
            userControlRoom1.BackColor = Color.White;
            userControlRoom1.Dock = DockStyle.Fill;
            userControlRoom1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlRoom1.Location = new Point(291, 200);
            userControlRoom1.Name = "userControlRoom1";
            userControlRoom1.Size = new Size(1059, 426);
            userControlRoom1.TabIndex = 0;
            userControlRoom1.Visible = false;
            // 
            // userControlReservation1
            // 
            userControlReservation1.BackColor = Color.White;
            userControlReservation1.Dock = DockStyle.Fill;
            userControlReservation1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlReservation1.Location = new Point(291, 200);
            userControlReservation1.Name = "userControlReservation1";
            userControlReservation1.Size = new Size(1059, 426);
            userControlReservation1.TabIndex = 0;
            userControlReservation1.Visible = false;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.BackColor = Color.White;
            userControlDashboard1.Dock = DockStyle.Fill;
            userControlDashboard1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlDashboard1.Location = new Point(291, 200);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1059, 426);
            userControlDashboard1.TabIndex = 0;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 681);
            Controls.Add(userControlDashboard1);
            Controls.Add(userControlReservation1);
            Controls.Add(userControlRoom1);
            Controls.Add(userControlClient1);
            Controls.Add(userControlSetting1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_System | Dashboard";
            WindowState = FormWindowState.Minimized;
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private LinkLabel linkLabelLogOut;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label labelDateTime;
        private Label labelUsername;
        private Label label5;
        private Button buttonDashboard;
        private Button buttonSetting;
        private Button buttonReservation;
        private Button buttonRoom;
        private Button buttonClient;
        private Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlDashboard userControlDashboard1;
    }
}