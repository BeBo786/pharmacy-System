namespace Test
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdduser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Profile1 = new Test.AdminUC.UC_Profile();
            this.uC_ViewUser1 = new Test.AdminUC.UC_ViewUser();
            this.uc_Adduser1 = new Test.AdminUC.Uc_Adduser();
            this.uC_Dashbord1 = new Test.AdminUC.UC_Dashbord();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 780);
            this.panel1.TabIndex = 0;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(89, 671);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(102, 29);
            this.usernamelbl.TabIndex = 9;
            this.usernamelbl.Text = "Dr.Bahaa";
            this.usernamelbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Location = new System.Drawing.Point(12, 559);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(263, 45);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(12, 490);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(263, 45);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 777);
            this.panel2.TabIndex = 1;
            // 
            // btnViewUser
            // 
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.Parent = this.btnViewUser;
            this.btnViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUser.CustomImages.Parent = this.btnViewUser;
            this.btnViewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.HoverState.Parent = this.btnViewUser;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(12, 418);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.ShadowDecoration.Parent = this.btnViewUser;
            this.btnViewUser.Size = new System.Drawing.Size(263, 45);
            this.btnViewUser.TabIndex = 6;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdduser.CheckedState.Parent = this.btnAdduser;
            this.btnAdduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdduser.CustomImages.Parent = this.btnAdduser;
            this.btnAdduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdduser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.HoverState.Parent = this.btnAdduser;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdduser.Location = new System.Drawing.Point(12, 345);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.ShadowDecoration.Parent = this.btnAdduser;
            this.btnAdduser.Size = new System.Drawing.Size(263, 45);
            this.btnAdduser.TabIndex = 5;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(12, 272);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(263, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashbord";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1320, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.White;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Profile1.Location = new System.Drawing.Point(260, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1110, 777);
            this.uC_Profile1.TabIndex = 5;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_ViewUser1.Location = new System.Drawing.Point(260, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1110, 777);
            this.uC_ViewUser1.TabIndex = 4;
            // 
            // uc_Adduser1
            // 
            this.uc_Adduser1.BackColor = System.Drawing.Color.White;
            this.uc_Adduser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uc_Adduser1.Location = new System.Drawing.Point(260, 0);
            this.uc_Adduser1.Name = "uc_Adduser1";
            this.uc_Adduser1.Size = new System.Drawing.Size(1110, 777);
            this.uc_Adduser1.TabIndex = 2;
            this.uc_Adduser1.Load += new System.EventHandler(this.uc_Adduser1_Load);
            // 
            // uC_Dashbord1
            // 
            this.uC_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dashbord1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Dashbord1.Location = new System.Drawing.Point(260, 0);
            this.uC_Dashbord1.Name = "uC_Dashbord1";
            this.uC_Dashbord1.Size = new System.Drawing.Size(1110, 777);
            this.uC_Dashbord1.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.uC_Profile1);
            this.Controls.Add(this.uC_ViewUser1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.uc_Adduser1);
            this.Controls.Add(this.uC_Dashbord1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAdduser;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernamelbl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdminUC.UC_Dashbord uC_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdminUC.Uc_Adduser uc_Adduser1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdminUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdminUC.UC_Profile uC_Profile1;
    }
}