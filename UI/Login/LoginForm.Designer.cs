namespace Mb.UI.Login
{
    partial class LoginForm
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
            pnlCard = new Panel();
            lnkRegister = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.None;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lnkRegister);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtLogin);
            pnlCard.Controls.Add(lblLogin);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(30, 45);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(360, 420);
            pnlCard.TabIndex = 0;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(33, 53, 77);
            lnkRegister.Font = new Font("Segoe UI", 9.75F);
            lnkRegister.LinkArea = new LinkArea(14, 18);
            lnkRegister.LinkColor = Color.FromArgb(46, 74, 107);
            lnkRegister.Location = new Point(18, 360);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(322, 24);
            lnkRegister.TabIndex = 7;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Нет аккаунта? Зарегистрироваться";
            lnkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegister.UseCompatibleTextRendering = true;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 74, 107);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11.25F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(36, 296);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(288, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(36, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Введите пароль";
            txtPassword.Size = new Size(288, 32);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.ForeColor = Color.FromArgb(108, 117, 125);
            lblPassword.Location = new Point(34, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(36, 160);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Введите логин";
            txtLogin.Size = new Size(288, 32);
            txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.75F);
            lblLogin.ForeColor = Color.FromArgb(108, 117, 125);
            lblLogin.Location = new Point(34, 136);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 23);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Логин";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(150, 158, 172);
            lblSubtitle.Location = new Point(18, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(322, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Войдите в свою учётную запись";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Light", 22F);
            lblTitle.ForeColor = Color.FromArgb(46, 74, 107);
            lblTitle.Location = new Point(18, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Авторизация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(420, 510);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnkRegister;
    }
}
