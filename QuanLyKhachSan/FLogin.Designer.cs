namespace QuanLyKhachSan
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResetpass = new System.Windows.Forms.LinkLabel();
            this.chekPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.Controls.Add(this.lblResetpass);
            this.PanelLogin.Controls.Add(this.chekPass);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.lblError);
            this.PanelLogin.Controls.Add(this.BtnLogin);
            this.PanelLogin.Controls.Add(this.txbPassword);
            this.PanelLogin.Controls.Add(this.txbUsername);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.guna2PictureBox1);
            this.PanelLogin.Controls.Add(this.BtnExit);
            this.PanelLogin.Location = new System.Drawing.Point(406, 228);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(1112, 550);
            this.PanelLogin.TabIndex = 0;
            // 
            // lblResetpass
            // 
            this.lblResetpass.AutoSize = true;
            this.lblResetpass.LinkColor = System.Drawing.Color.Red;
            this.lblResetpass.Location = new System.Drawing.Point(823, 362);
            this.lblResetpass.Name = "lblResetpass";
            this.lblResetpass.Size = new System.Drawing.Size(82, 13);
            this.lblResetpass.TabIndex = 9;
            this.lblResetpass.TabStop = true;
            this.lblResetpass.Text = "Quên Mật Khẩu";
            this.lblResetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblResetpass_LinkClicked);
            // 
            // chekPass
            // 
            this.chekPass.AutoSize = true;
            this.chekPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chekPass.CheckedState.BorderRadius = 0;
            this.chekPass.CheckedState.BorderThickness = 0;
            this.chekPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chekPass.Location = new System.Drawing.Point(655, 362);
            this.chekPass.Name = "chekPass";
            this.chekPass.Size = new System.Drawing.Size(121, 17);
            this.chekPass.TabIndex = 8;
            this.chekPass.Text = "Hiển Thị Mật Khẩu !";
            this.chekPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chekPass.UncheckedState.BorderRadius = 0;
            this.chekPass.UncheckedState.BorderThickness = 0;
            this.chekPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chekPass.CheckedChanged += new System.EventHandler(this.chekPass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(350, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Bạn sẽ chấp nhận điều khoản và điều kiện của chúng tôi !";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(716, 471);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(177, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Tên đăng nhập hoặc mật khẩu sai !";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 18;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(591, 399);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(404, 58);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "ĐĂNG NHẬP";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderRadius = 18;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPassword.ForeColor = System.Drawing.Color.Black;
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbPassword.IconLeft")));
            this.txbPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txbPassword.Location = new System.Drawing.Point(591, 277);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderText = "Nhập tên đăng nhập...";
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(415, 67);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbUsername
            // 
            this.txbUsername.BorderRadius = 18;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.DefaultText = "";
            this.txbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbUsername.ForeColor = System.Drawing.Color.Black;
            this.txbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbUsername.IconLeft")));
            this.txbUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txbUsername.Location = new System.Drawing.Point(591, 178);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '\0';
            this.txbUsername.PlaceholderText = "Nhập tên đăng nhập...";
            this.txbUsername.SelectedText = "";
            this.txbUsername.Size = new System.Drawing.Size(415, 67);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng Nhập";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(61, 104);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 353);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnExit.Location = new System.Drawing.Point(3, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(45, 38);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1850, 769);
            this.Controls.Add(this.PanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private Guna.UI2.WinForms.Guna2CircleButton BtnExit;
        private Guna.UI2.WinForms.Guna2TextBox txbUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblResetpass;
        private Guna.UI2.WinForms.Guna2CheckBox chekPass;
    }
}

