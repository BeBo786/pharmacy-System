namespace Test.PharmacistUC
{
    partial class UC_p_OCR
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
            this.Dashbord = new System.Windows.Forms.Label();
            this.btnAddPic = new Guna.UI2.WinForms.Guna2Button();
            this.btnConvert = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_Data = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ImageLoc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashbord
            // 
            this.Dashbord.AutoSize = true;
            this.Dashbord.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashbord.Location = new System.Drawing.Point(49, 27);
            this.Dashbord.Name = "Dashbord";
            this.Dashbord.Size = new System.Drawing.Size(90, 36);
            this.Dashbord.TabIndex = 3;
            this.Dashbord.Text = "OCR ";
            // 
            // btnAddPic
            // 
            this.btnAddPic.BorderRadius = 19;
            this.btnAddPic.BorderThickness = 1;
            this.btnAddPic.CheckedState.Parent = this.btnAddPic;
            this.btnAddPic.CustomImages.Parent = this.btnAddPic;
            this.btnAddPic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddPic.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnAddPic.HoverState.Parent = this.btnAddPic;
            this.btnAddPic.Location = new System.Drawing.Point(211, 538);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.ShadowDecoration.Parent = this.btnAddPic;
            this.btnAddPic.Size = new System.Drawing.Size(164, 45);
            this.btnAddPic.TabIndex = 18;
            this.btnAddPic.Text = "Upload Pictuer";
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BorderRadius = 19;
            this.btnConvert.BorderThickness = 1;
            this.btnConvert.CheckedState.Parent = this.btnConvert;
            this.btnConvert.CustomImages.Parent = this.btnConvert;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnConvert.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnConvert.HoverState.Parent = this.btnConvert;
            this.btnConvert.Location = new System.Drawing.Point(774, 538);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.ShadowDecoration.Parent = this.btnConvert;
            this.btnConvert.Size = new System.Drawing.Size(164, 45);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Txt_Data
            // 
            this.Txt_Data.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Txt_Data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Data.DefaultText = "";
            this.Txt_Data.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Data.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Data.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Data.DisabledState.Parent = this.Txt_Data;
            this.Txt_Data.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Data.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Data.FocusedState.Parent = this.Txt_Data;
            this.Txt_Data.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Data.ForeColor = System.Drawing.Color.Black;
            this.Txt_Data.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Data.HoverState.Parent = this.Txt_Data;
            this.Txt_Data.Location = new System.Drawing.Point(639, 94);
            this.Txt_Data.Multiline = true;
            this.Txt_Data.Name = "Txt_Data";
            this.Txt_Data.PasswordChar = '\0';
            this.Txt_Data.PlaceholderText = "";
            this.Txt_Data.ReadOnly = true;
            this.Txt_Data.SelectedText = "";
            this.Txt_Data.ShadowDecoration.Parent = this.Txt_Data;
            this.Txt_Data.Size = new System.Drawing.Size(389, 353);
            this.Txt_Data.TabIndex = 21;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ImageLoc
            // 
            this.ImageLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageLoc.Location = new System.Drawing.Point(55, 94);
            this.ImageLoc.Name = "ImageLoc";
            this.ImageLoc.Size = new System.Drawing.Size(469, 353);
            this.ImageLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageLoc.TabIndex = 20;
            this.ImageLoc.TabStop = false;
            // 
            // UC_p_OCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Txt_Data);
            this.Controls.Add(this.ImageLoc);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.Dashbord);
            this.Name = "UC_p_OCR";
            this.Size = new System.Drawing.Size(1110, 777);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashbord;
        private Guna.UI2.WinForms.Guna2Button btnAddPic;
        private Guna.UI2.WinForms.Guna2Button btnConvert;
        private System.Windows.Forms.PictureBox ImageLoc;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Data;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
