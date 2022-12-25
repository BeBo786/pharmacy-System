namespace Test.AdminUC
{
    partial class Uc_Adduser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Adduser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhoneNo = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtDOB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone NO.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "DOB (Date Of Birth)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(629, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // comUserRole
            // 
            this.comUserRole.BackColor = System.Drawing.Color.Transparent;
            this.comUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comUserRole.FocusedState.Parent = this.comUserRole;
            this.comUserRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comUserRole.ForeColor = System.Drawing.Color.Black;
            this.comUserRole.HoverState.Parent = this.comUserRole;
            this.comUserRole.ItemHeight = 30;
            this.comUserRole.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist"});
            this.comUserRole.ItemsAppearance.Parent = this.comUserRole;
            this.comUserRole.Location = new System.Drawing.Point(85, 274);
            this.comUserRole.Name = "comUserRole";
            this.comUserRole.ShadowDecoration.Parent = this.comUserRole;
            this.comUserRole.Size = new System.Drawing.Size(340, 36);
            this.comUserRole.TabIndex = 8;
            this.comUserRole.SelectedIndexChanged += new System.EventHandler(this.comUserRole_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(85, 380);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(340, 36);
            this.txtName.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BaseColor = System.Drawing.Color.White;
            this.txtPhoneNo.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhoneNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNo.Location = new System.Drawing.Point(85, 594);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.Size = new System.Drawing.Size(340, 36);
            this.txtPhoneNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(633, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(340, 36);
            this.txtEmail.TabIndex = 11;
            // 
            // txtusername
            // 
            this.txtusername.BaseColor = System.Drawing.Color.White;
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(633, 380);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(340, 36);
            this.txtusername.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(633, 489);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(340, 36);
            this.txtPass.TabIndex = 13;
            // 
            // txtDOB
            // 
            this.txtDOB.BaseColor = System.Drawing.Color.White;
            this.txtDOB.BorderColor = System.Drawing.Color.Silver;
            this.txtDOB.CustomFormat = null;
            this.txtDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDOB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Location = new System.Drawing.Point(86, 489);
            this.txtDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtDOB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDOB.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDOB.OnPressedColor = System.Drawing.Color.Black;
            this.txtDOB.Size = new System.Drawing.Size(339, 36);
            this.txtDOB.TabIndex = 14;
            this.txtDOB.Text = "30 November, 2022";
            this.txtDOB.Value = new System.DateTime(2022, 11, 30, 21, 42, 5, 249);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel2.Location = new System.Drawing.Point(527, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 15;
            // 
            // btnSignin
            // 
            this.btnSignin.BorderRadius = 18;
            this.btnSignin.BorderThickness = 1;
            this.btnSignin.CheckedState.Parent = this.btnSignin;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.CustomImages.Parent = this.btnSignin;
            this.btnSignin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSignin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSignin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSignin.HoverState.Parent = this.btnSignin;
            this.btnSignin.Image = ((System.Drawing.Image)(resources.GetObject("btnSignin.Image")));
            this.btnSignin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignin.Location = new System.Drawing.Point(576, 692);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.ShadowDecoration.Parent = this.btnSignin;
            this.btnSignin.Size = new System.Drawing.Size(180, 45);
            this.btnSignin.TabIndex = 16;
            this.btnSignin.Text = "Sign Up";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 18;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(807, 692);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.btnExit.Location = new System.Drawing.Point(1007, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.White;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 45);
            this.btnExit.TabIndex = 18;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Uc_Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comUserRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Uc_Adduser";
            this.Size = new System.Drawing.Size(1110, 777);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comUserRole;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtPhoneNo;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private Guna.UI.WinForms.GunaDateTimePicker txtDOB;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}
