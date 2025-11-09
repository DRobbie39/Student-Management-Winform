namespace StudentManagement.UI.Authentication
{
    partial class frmRegisterForm
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
            pictureBox1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lnkLogin = new LinkLabel();
            pbPassword = new PictureBox();
            pbUsername = new PictureBox();
            pbRegister = new PictureBox();
            lblRegister = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRegister).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.password_confirm_icon;
            pictureBox1.Location = new Point(206, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(369, 364);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm your Password";
            txtConfirmPassword.Size = new Size(218, 27);
            txtConfirmPassword.TabIndex = 37;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(236, 367);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(127, 20);
            lblConfirmPassword.TabIndex = 36;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.LinkColor = Color.Blue;
            lnkLogin.Location = new Point(287, 439);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(46, 20);
            lnkLogin.TabIndex = 34;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password_icon;
            pbPassword.Location = new Point(203, 323);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(27, 23);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 33;
            pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            pbUsername.Image = Properties.Resources.username_icon;
            pbUsername.Location = new Point(203, 287);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(27, 23);
            pbUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbUsername.TabIndex = 32;
            pbUsername.TabStop = false;
            // 
            // pbRegister
            // 
            pbRegister.Image = Properties.Resources.register;
            pbRegister.Location = new Point(207, 95);
            pbRegister.Name = "pbRegister";
            pbRegister.Size = new Size(380, 162);
            pbRegister.SizeMode = PictureBoxSizeMode.Zoom;
            pbRegister.TabIndex = 31;
            pbRegister.TabStop = false;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(352, 29);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(101, 31);
            lblRegister.TabIndex = 30;
            lblRegister.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Window;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlText;
            btnRegister.Location = new Point(369, 427);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(108, 43);
            btnRegister.TabIndex = 29;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(369, 323);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your Password";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 28;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(369, 283);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your Username";
            txtUsername.Size = new Size(218, 27);
            txtUsername.TabIndex = 27;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(236, 326);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 26;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(236, 286);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 25;
            lblUsername.Text = "Username";
            // 
            // frmRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(pictureBox1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lnkLogin);
            Controls.Add(pbPassword);
            Controls.Add(pbUsername);
            Controls.Add(pbRegister);
            Controls.Add(lblRegister);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private LinkLabel lnkLogin;
        private PictureBox pbPassword;
        private PictureBox pbUsername;
        private PictureBox pbRegister;
        private Label lblRegister;
        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
    }
}