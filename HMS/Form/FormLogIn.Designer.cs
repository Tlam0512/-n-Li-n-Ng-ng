namespace HMS
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            pictureBoxShow = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            buttonLogIn = new Button();
            textBoxUserName = new TextBox();
            label2 = new Label();
            pictureBoxHide = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.computer_icons_window_button_png_favpng_LjLhAeNZCVR48dFC83Epwz5ye;
            pictureBoxClose.Location = new Point(1326, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(28, 28);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1292, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(28, 28);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 623);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "NHOM 3";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonLogIn);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(222, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(71, 192);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(260, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Image = Properties.Resources.icon_eye_3;
            pictureBoxShow.Location = new Point(331, 192);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(26, 27);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 6;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(177, 244);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 5;
            label4.Text = "Forgot Password ?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(71, 163);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.Black;
            buttonLogIn.FlatAppearance.BorderColor = Color.Black;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(71, 262);
            buttonLogIn.Margin = new Padding(0);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(314, 45);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += button1_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.None;
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Location = new Point(71, 122);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(286, 27);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(71, 92);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Image = Properties.Resources.th__1_;
            pictureBoxHide.Location = new Point(331, 192);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(26, 27);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 7;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(816, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 512);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.unnamed;
            pictureBox2.Location = new Point(895, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(388, 271);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(956, 417);
            label5.Name = "label5";
            label5.Size = new Size(265, 32);
            label5.TabIndex = 10;
            label5.Text = "Hotel Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1030, 449);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 11;
            label6.Text = "System";
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 720);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_System | Login";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private ToolTip toolTip1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonLogIn;
        private TextBox textBoxUserName;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
    }
}
