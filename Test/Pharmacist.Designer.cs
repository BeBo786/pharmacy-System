namespace Test
{
    partial class Pharmacist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ocrbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMed = new Guna.UI2.WinForms.Guna2Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_p_OCR1 = new Test.PharmacistUC.UC_p_OCR();
            this.uC_P_SellMed1 = new Test.PharmacistUC.UC_P_SellMed();
            this.uC_P_UpdateMedicine1 = new Test.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_viewMedicine1 = new Test.PharmacistUC.UC_P_viewMedicine();
            this.uC_p_AddMed1 = new Test.PharmacistUC.UC_p_AddMed();
            this.uc_p_Dashbord1 = new Test.PharmacistUC.Uc_p_Dashbord();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.ocrbtn);
            this.panel1.Controls.Add(this.btnSellMed);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddMed);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 780);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ocrbtn
            // 
            this.ocrbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ocrbtn.CheckedState.Parent = this.ocrbtn;
            this.ocrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocrbtn.CustomImages.Parent = this.ocrbtn;
            this.ocrbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ocrbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ocrbtn.ForeColor = System.Drawing.Color.White;
            this.ocrbtn.HoverState.Parent = this.ocrbtn;
            this.ocrbtn.Image = global::Test.Properties.Resources.ocr_clipart_2;
            this.ocrbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ocrbtn.Location = new System.Drawing.Point(9, 576);
            this.ocrbtn.Name = "ocrbtn";
            this.ocrbtn.ShadowDecoration.Parent = this.ocrbtn;
            this.ocrbtn.Size = new System.Drawing.Size(251, 45);
            this.ocrbtn.TabIndex = 11;
            this.ocrbtn.Text = "OCR ";
            this.ocrbtn.Click += new System.EventHandler(this.ocrbtn_Click);
            // 
            // btnSellMed
            // 
            this.btnSellMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMed.CheckedState.Parent = this.btnSellMed;
            this.btnSellMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellMed.CustomImages.Parent = this.btnSellMed;
            this.btnSellMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSellMed.ForeColor = System.Drawing.Color.White;
            this.btnSellMed.HoverState.Parent = this.btnSellMed;
            this.btnSellMed.Image = global::Test.Properties.Resources.sellMedicine_64px;
            this.btnSellMed.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSellMed.Location = new System.Drawing.Point(6, 512);
            this.btnSellMed.Name = "btnSellMed";
            this.btnSellMed.ShadowDecoration.Parent = this.btnSellMed;
            this.btnSellMed.Size = new System.Drawing.Size(251, 45);
            this.btnSellMed.TabIndex = 9;
            this.btnSellMed.Text = "Sell Medicine";
            this.btnSellMed.Click += new System.EventHandler(this.btnSellMed_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(84, 707);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(102, 29);
            this.usernamelbl.TabIndex = 9;
            this.usernamelbl.Text = "Dr.Bahaa";
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = global::Test.Properties.Resources.modifyMedicine_32px;
            this.btnProfile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProfile.Location = new System.Drawing.Point(9, 450);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(251, 45);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Modify Medicine";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 765);
            this.panel2.TabIndex = 1;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMedicine.CustomImages.Parent = this.btnViewMedicine;
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Image = global::Test.Properties.Resources.view_64px;
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(9, 387);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.ShadowDecoration.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Size = new System.Drawing.Size(248, 45);
            this.btnViewMedicine.TabIndex = 6;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test.Properties.Resources.pharmacy_100px;
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddMed
            // 
            this.btnAddMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMed.CheckedState.Parent = this.btnAddMed;
            this.btnAddMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMed.CustomImages.Parent = this.btnAddMed;
            this.btnAddMed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddMed.ForeColor = System.Drawing.Color.White;
            this.btnAddMed.HoverState.Parent = this.btnAddMed;
            this.btnAddMed.Image = global::Test.Properties.Resources.addMedic_48px;
            this.btnAddMed.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMed.Location = new System.Drawing.Point(9, 319);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.ShadowDecoration.Parent = this.btnAddMed;
            this.btnAddMed.Size = new System.Drawing.Size(251, 45);
            this.btnAddMed.TabIndex = 5;
            this.btnAddMed.Text = "Add Medicine";
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::Test.Properties.Resources.dashbord;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(9, 251);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(251, 45);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashbord";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Image = global::Test.Properties.Resources.logout;
            this.btnlogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogout.Location = new System.Drawing.Point(9, 640);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(251, 45);
            this.btnlogout.TabIndex = 10;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_p_OCR1);
            this.panel3.Controls.Add(this.uC_P_SellMed1);
            this.panel3.Controls.Add(this.uC_P_UpdateMedicine1);
            this.panel3.Controls.Add(this.uC_P_viewMedicine1);
            this.panel3.Controls.Add(this.uC_p_AddMed1);
            this.panel3.Controls.Add(this.uc_p_Dashbord1);
            this.panel3.Location = new System.Drawing.Point(260, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 777);
            this.panel3.TabIndex = 2;
            // 
            // uC_p_OCR1
            // 
            this.uC_p_OCR1.BackColor = System.Drawing.Color.White;
            this.uC_p_OCR1.Location = new System.Drawing.Point(-3, -3);
            this.uC_p_OCR1.Name = "uC_p_OCR1";
            this.uC_p_OCR1.Size = new System.Drawing.Size(1110, 777);
            this.uC_p_OCR1.TabIndex = 5;
            // 
            // uC_P_SellMed1
            // 
            this.uC_P_SellMed1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMed1.Location = new System.Drawing.Point(0, -3);
            this.uC_P_SellMed1.Name = "uC_P_SellMed1";
            this.uC_P_SellMed1.Size = new System.Drawing.Size(1110, 777);
            this.uC_P_SellMed1.TabIndex = 4;
            this.uC_P_SellMed1.Load += new System.EventHandler(this.uC_P_SellMed1_Load);
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(-3, -3);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(1110, 777);
            this.uC_P_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_P_viewMedicine1
            // 
            this.uC_P_viewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_viewMedicine1.Location = new System.Drawing.Point(0, -3);
            this.uC_P_viewMedicine1.Name = "uC_P_viewMedicine1";
            this.uC_P_viewMedicine1.Size = new System.Drawing.Size(1110, 777);
            this.uC_P_viewMedicine1.TabIndex = 2;
            // 
            // uC_p_AddMed1
            // 
            this.uC_p_AddMed1.BackColor = System.Drawing.Color.White;
            this.uC_p_AddMed1.Location = new System.Drawing.Point(0, -3);
            this.uC_p_AddMed1.Name = "uC_p_AddMed1";
            this.uC_p_AddMed1.Size = new System.Drawing.Size(1110, 777);
            this.uC_p_AddMed1.TabIndex = 1;
            // 
            // uc_p_Dashbord1
            // 
            this.uc_p_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uc_p_Dashbord1.Location = new System.Drawing.Point(0, -3);
            this.uc_p_Dashbord1.Name = "uc_p_Dashbord1";
            this.uc_p_Dashbord1.Size = new System.Drawing.Size(1110, 777);
            this.uc_p_Dashbord1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel3;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernamelbl;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMed;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSellMed;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private PharmacistUC.Uc_p_Dashbord uc_p_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_p_AddMed uC_p_AddMed1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_viewMedicine uC_P_viewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_SellMed uC_P_SellMed1;
        private Guna.UI2.WinForms.Guna2Button ocrbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_p_OCR uC_p_OCR1;
    }
}