namespace StudentManagement.UI.Authentication
{
    partial class frmLoginForm
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
            lnkRegister = new LinkLabel();
            pbPassword = new PictureBox();
            pbUsername = new PictureBox();
            pbLogin = new PictureBox();
            lblLogin = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            SuspendLayout();
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.LinkColor = Color.Blue;
            lnkRegister.Location = new Point(300, 374);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(63, 20);
            lnkRegister.TabIndex = 20;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register";
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password_icon;
            pbPassword.Location = new Point(227, 314);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(27, 23);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 19;
            pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            pbUsername.Image = Properties.Resources.username_icon;
            pbUsername.Location = new Point(227, 278);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(27, 23);
            pbUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbUsername.TabIndex = 18;
            pbUsername.TabStop = false;
            // 
            // pbLogin
            // 
            pbLogin.Image = Properties.Resources.login;
            pbLogin.Location = new Point(231, 88);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(342, 162);
            pbLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogin.TabIndex = 17;
            pbLogin.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(372, 23);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(75, 31);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Window;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(372, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 43);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(355, 314);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your Password";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(355, 274);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your Username";
            txtUsername.Size = new Size(218, 27);
            txtUsername.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(260, 317);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(260, 277);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username";
            // 
            // frmLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkRegister);
            Controls.Add(pbPassword);
            Controls.Add(pbUsername);
            Controls.Add(pbLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkRegister;
        private PictureBox pbPassword;
        private PictureBox pbUsername;
        private PictureBox pbLogin;
        private Label lblLogin;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
    }
}