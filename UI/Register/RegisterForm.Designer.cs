namespace Mb.UI.Register
{
    partial class RegisterForm
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
            lnkLogin = new LinkLabel();
            btnRegister = new Button();
            btnHome = new Button();
            txtConfirm = new TextBox();
            lblConfirm = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
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
            pnlCard.Controls.Add(lnkLogin);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(btnHome);
            pnlCard.Controls.Add(txtConfirm);
            pnlCard.Controls.Add(lblConfirm);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(30, 45);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(360, 500);
            pnlCard.TabIndex = 0;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(33, 53, 77);
            lnkLogin.Font = new Font("Segoe UI", 9.75F);
            lnkLogin.LinkArea = new LinkArea(17, 6);
            lnkLogin.LinkColor = Color.FromArgb(46, 74, 107);
            lnkLogin.Location = new Point(18, 440);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(322, 24);
            lnkLogin.TabIndex = 9;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Уже есть аккаунт? Войти";
            lnkLogin.TextAlign = ContentAlignment.MiddleCenter;
            lnkLogin.UseCompatibleTextRendering = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(46, 74, 107);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11.25F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(36, 376);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(288, 44);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Font = new Font("Segoe UI", 11F);
            txtConfirm.Location = new Point(36, 310);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Повторите пароль";
            txtConfirm.Size = new Size(288, 32);
            txtConfirm.TabIndex = 7;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 9.75F);
            lblConfirm.ForeColor = Color.FromArgb(108, 117, 125);
            lblConfirm.Location = new Point(34, 286);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(173, 23);
            lblConfirm.TabIndex = 6;
            lblConfirm.Text = "Подтвердите пароль";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(36, 240);
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
            lblPassword.Location = new Point(34, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(36, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Введите email";
            txtEmail.Size = new Size(288, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F);
            lblEmail.ForeColor = Color.FromArgb(108, 117, 125);
            lblEmail.Location = new Point(34, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(150, 158, 172);
            lblSubtitle.Location = new Point(18, 78);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(322, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Создайте новую учётную запись";
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
            lblTitle.Text = "Регистрация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F);
            btnHome.ForeColor = Color.FromArgb(108, 117, 125);
            btnHome.Location = new Point(107, 470);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 36);
            btnHome.TabIndex = 10;
            btnHome.Text = "← На главную";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += (s, e) => this.Close();
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(420, 590);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnRegister;
        private Button btnHome;
        private LinkLabel lnkLogin;
    }
}
