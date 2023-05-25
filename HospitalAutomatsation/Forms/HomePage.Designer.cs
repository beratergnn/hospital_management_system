namespace HospitalAutomatsation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAboutScreen = new System.Windows.Forms.Button();
            this.btnSecretaryLoginScreen = new System.Windows.Forms.Button();
            this.btnDoctorLoginScreen = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Creater = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.newBtnLoginSecretary = new HospitalAutomatsation.Components.NewButton();
            this.txtId = new HospitalAutomatsation.Components.NewTextBox();
            this.txtPassword = new HospitalAutomatsation.Components.NewTextBox();
            this.newBtnLoginDoctor = new HospitalAutomatsation.Components.NewButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIdentityNo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAboutScreen);
            this.panelMenu.Controls.Add(this.btnSecretaryLoginScreen);
            this.panelMenu.Controls.Add(this.btnDoctorLoginScreen);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 477);
            this.panelMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 302);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(253, 74);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "    LOG OUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // btnAboutScreen
            // 
            this.btnAboutScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAboutScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAboutScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAboutScreen.Image = global::HospitalAutomatsation.Properties.Resources.medical_team64;
            this.btnAboutScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutScreen.Location = new System.Drawing.Point(0, 228);
            this.btnAboutScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutScreen.Name = "btnAboutScreen";
            this.btnAboutScreen.Size = new System.Drawing.Size(253, 74);
            this.btnAboutScreen.TabIndex = 3;
            this.btnAboutScreen.Text = "    CHARTS";
            this.btnAboutScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutScreen.UseVisualStyleBackColor = true;
            this.btnAboutScreen.Click += new System.EventHandler(this.btnAboutScreen_Click);
            this.btnAboutScreen.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAboutScreen.MouseHover += new System.EventHandler(this.btnAbout_MouseHover);
            // 
            // btnSecretaryLoginScreen
            // 
            this.btnSecretaryLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSecretaryLoginScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecretaryLoginScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSecretaryLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecretaryLoginScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSecretaryLoginScreen.Image = global::HospitalAutomatsation.Properties.Resources.secretary64green;
            this.btnSecretaryLoginScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecretaryLoginScreen.Location = new System.Drawing.Point(0, 154);
            this.btnSecretaryLoginScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecretaryLoginScreen.Name = "btnSecretaryLoginScreen";
            this.btnSecretaryLoginScreen.Size = new System.Drawing.Size(253, 74);
            this.btnSecretaryLoginScreen.TabIndex = 2;
            this.btnSecretaryLoginScreen.Text = "    SECRETARY LOGIN";
            this.btnSecretaryLoginScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecretaryLoginScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecretaryLoginScreen.UseVisualStyleBackColor = true;
            this.btnSecretaryLoginScreen.Click += new System.EventHandler(this.btnSecretaryLoginScreen_Click);
            this.btnSecretaryLoginScreen.MouseLeave += new System.EventHandler(this.btnSecretaryLogin_MouseLeave);
            this.btnSecretaryLoginScreen.MouseHover += new System.EventHandler(this.btnSecretaryLogin_MouseHover);
            // 
            // btnDoctorLoginScreen
            // 
            this.btnDoctorLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoctorLoginScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorLoginScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoctorLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorLoginScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoctorLoginScreen.Image = global::HospitalAutomatsation.Properties.Resources.doctor64green;
            this.btnDoctorLoginScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorLoginScreen.Location = new System.Drawing.Point(0, 80);
            this.btnDoctorLoginScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctorLoginScreen.Name = "btnDoctorLoginScreen";
            this.btnDoctorLoginScreen.Size = new System.Drawing.Size(253, 74);
            this.btnDoctorLoginScreen.TabIndex = 1;
            this.btnDoctorLoginScreen.Text = "    DOCTOR LOGIN       ";
            this.btnDoctorLoginScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctorLoginScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorLoginScreen.UseVisualStyleBackColor = true;
            this.btnDoctorLoginScreen.Click += new System.EventHandler(this.btnDoctorLoginScreen_Click);
            this.btnDoctorLoginScreen.MouseLeave += new System.EventHandler(this.btnDoctorLogin_MouseLeave);
            this.btnDoctorLoginScreen.MouseHover += new System.EventHandler(this.btnDoctorLogin_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.Creater);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(253, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // Creater
            // 
            this.Creater.AutoSize = true;
            this.Creater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Creater.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creater.ForeColor = System.Drawing.Color.LightGray;
            this.Creater.Location = new System.Drawing.Point(28, 28);
            this.Creater.Name = "Creater";
            this.Creater.Size = new System.Drawing.Size(187, 26);
            this.Creater.TabIndex = 0;
            this.Creater.Text = "BARIŞ && BERHAT";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(253, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(513, 80);
            this.panelTitleBar.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(77, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME TO HOSPITAL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBoxPassword);
            this.panelDesktopPanel.Controls.Add(this.pictureBox);
            this.panelDesktopPanel.Controls.Add(this.newBtnLoginSecretary);
            this.panelDesktopPanel.Controls.Add(this.txtId);
            this.panelDesktopPanel.Controls.Add(this.txtPassword);
            this.panelDesktopPanel.Controls.Add(this.newBtnLoginDoctor);
            this.panelDesktopPanel.Controls.Add(this.lblPassword);
            this.panelDesktopPanel.Controls.Add(this.lblIdentityNo);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(253, 80);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(513, 397);
            this.panelDesktopPanel.TabIndex = 8;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPassword.Image = global::HospitalAutomatsation.Properties.Resources.eye0_24;
            this.pictureBoxPassword.Location = new System.Drawing.Point(452, 279);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPassword.TabIndex = 10;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Visible = false;
            this.pictureBoxPassword.Click += new System.EventHandler(this.pictureBoxPassword_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::HospitalAutomatsation.Properties.Resources.doctor128green;
            this.pictureBox.Location = new System.Drawing.Point(272, 21);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(171, 158);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // newBtnLoginSecretary
            // 
            this.newBtnLoginSecretary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.newBtnLoginSecretary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.newBtnLoginSecretary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.newBtnLoginSecretary.BorderRadius = 10;
            this.newBtnLoginSecretary.BorderSize = 3;
            this.newBtnLoginSecretary.FlatAppearance.BorderSize = 0;
            this.newBtnLoginSecretary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtnLoginSecretary.ForeColor = System.Drawing.Color.White;
            this.newBtnLoginSecretary.Image = global::HospitalAutomatsation.Properties.Resources.secretary24green;
            this.newBtnLoginSecretary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtnLoginSecretary.Location = new System.Drawing.Point(329, 329);
            this.newBtnLoginSecretary.Margin = new System.Windows.Forms.Padding(4);
            this.newBtnLoginSecretary.Name = "newBtnLoginSecretary";
            this.newBtnLoginSecretary.Size = new System.Drawing.Size(113, 49);
            this.newBtnLoginSecretary.TabIndex = 3;
            this.newBtnLoginSecretary.TabStop = false;
            this.newBtnLoginSecretary.Text = "LOG IN";
            this.newBtnLoginSecretary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtnLoginSecretary.TextColor = System.Drawing.Color.White;
            this.newBtnLoginSecretary.UseVisualStyleBackColor = false;
            this.newBtnLoginSecretary.Visible = false;
            this.newBtnLoginSecretary.Click += new System.EventHandler(this.newBtnLoginSecretary_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtId.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtId.BorderRadius = 10;
            this.txtId.BorderSize = 3;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(272, 204);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtId.PasswordChar = false;
            this.txtId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtId.PlaceholderText = "";
            this.txtId.Size = new System.Drawing.Size(171, 39);
            this.txtId.TabIndex = 1;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = false;
            this.txtId.Visible = false;
            this.txtId._TextChanged += new System.EventHandler(this.txtId__TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(272, 271);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(171, 39);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.Visible = false;
            // 
            // newBtnLoginDoctor
            // 
            this.newBtnLoginDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.newBtnLoginDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.newBtnLoginDoctor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.newBtnLoginDoctor.BorderRadius = 10;
            this.newBtnLoginDoctor.BorderSize = 3;
            this.newBtnLoginDoctor.FlatAppearance.BorderSize = 0;
            this.newBtnLoginDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtnLoginDoctor.ForeColor = System.Drawing.Color.White;
            this.newBtnLoginDoctor.Image = global::HospitalAutomatsation.Properties.Resources.doctor24green;
            this.newBtnLoginDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtnLoginDoctor.Location = new System.Drawing.Point(329, 329);
            this.newBtnLoginDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.newBtnLoginDoctor.Name = "newBtnLoginDoctor";
            this.newBtnLoginDoctor.Size = new System.Drawing.Size(113, 49);
            this.newBtnLoginDoctor.TabIndex = 5;
            this.newBtnLoginDoctor.TabStop = false;
            this.newBtnLoginDoctor.Text = "LOG IN";
            this.newBtnLoginDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtnLoginDoctor.TextColor = System.Drawing.Color.White;
            this.newBtnLoginDoctor.UseVisualStyleBackColor = false;
            this.newBtnLoginDoctor.Visible = false;
            this.newBtnLoginDoctor.Click += new System.EventHandler(this.newBtnLoginDoctor_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(89, 279);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(142, 29);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            this.lblPassword.Visible = false;
            // 
            // lblIdentityNo
            // 
            this.lblIdentityNo.AutoSize = true;
            this.lblIdentityNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentityNo.Location = new System.Drawing.Point(77, 213);
            this.lblIdentityNo.Name = "lblIdentityNo";
            this.lblIdentityNo.Size = new System.Drawing.Size(152, 29);
            this.lblIdentityNo.TabIndex = 0;
            this.lblIdentityNo.Text = "Identity No :";
            this.lblIdentityNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIdentityNo.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 477);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HomePage_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSecretaryLoginScreen;
        private System.Windows.Forms.Button btnDoctorLoginScreen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label Creater;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox;
        private Components.NewButton newBtnLoginSecretary;
        private Components.NewTextBox txtId;
        private Components.NewTextBox txtPassword;
        private Components.NewButton newBtnLoginDoctor;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIdentityNo;
        private System.Windows.Forms.Button btnAboutScreen;
    }
}