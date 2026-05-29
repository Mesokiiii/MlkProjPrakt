namespace Mb.UI.Profile
{
    partial class ProfileForm
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
            btnHome = new Button();
            btnLogout = new Button();
            btnChangePassword = new Button();
            lblRoleValue = new Label();
            lblRoleCaption = new Label();
            lblEmailValue = new Label();
            lblEmailCaption = new Label();
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
            pnlCard.Controls.Add(btnHome);
            pnlCard.Controls.Add(btnLogout);
            pnlCard.Controls.Add(btnChangePassword);
            pnlCard.Controls.Add(lblRoleValue);
            pnlCard.Controls.Add(lblRoleCaption);
            pnlCard.Controls.Add(lblEmailValue);
            pnlCard.Controls.Add(lblEmailCaption);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Location = new Point(412, 130);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(460, 520);
            pnlCard.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9.75F);
            btnHome.ForeColor = Color.FromArgb(46, 74, 107);
            btnHome.Location = new Point(46, 466);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(368, 32);
            btnHome.TabIndex = 8;
            btnHome.Text = "← На главную";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(206, 212, 218);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11.25F);
            btnLogout.ForeColor = Color.FromArgb(108, 117, 125);
            btnLogout.Location = new Point(46, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(368, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Выйти из аккаунта";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(46, 74, 107);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 11.25F);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(46, 344);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(368, 46);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Сменить пароль";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // lblRoleValue
            // 
            lblRoleValue.Font = new Font("Segoe UI", 13F);
            lblRoleValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblRoleValue.Location = new Point(44, 250);
            lblRoleValue.Name = "lblRoleValue";
            lblRoleValue.Size = new Size(372, 30);
            lblRoleValue.TabIndex = 5;
            lblRoleValue.Text = "—";
            // 
            // lblRoleCaption
            // 
            lblRoleCaption.AutoSize = true;
            lblRoleCaption.Font = new Font("Segoe UI", 9.75F);
            lblRoleCaption.ForeColor = Color.FromArgb(150, 158, 172);
            lblRoleCaption.Location = new Point(44, 226);
            lblRoleCaption.Name = "lblRoleCaption";
            lblRoleCaption.Size = new Size(38, 20);
            lblRoleCaption.TabIndex = 4;
            lblRoleCaption.Text = "Роль";
            // 
            // lblEmailValue
            // 
            lblEmailValue.Font = new Font("Segoe UI", 13F);
            lblEmailValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmailValue.Location = new Point(44, 166);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(372, 30);
            lblEmailValue.TabIndex = 3;
            lblEmailValue.Text = "—";
            // 
            // lblEmailCaption
            // 
            lblEmailCaption.AutoSize = true;
            lblEmailCaption.Font = new Font("Segoe UI", 9.75F);
            lblEmailCaption.ForeColor = Color.FromArgb(150, 158, 172);
            lblEmailCaption.Location = new Point(44, 142);
            lblEmailCaption.Name = "lblEmailCaption";
            lblEmailCaption.Size = new Size(46, 20);
            lblEmailCaption.TabIndex = 2;
            lblEmailCaption.Text = "Email";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(150, 158, 172);
            lblSubtitle.Location = new Point(20, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Информация о вашей учётной записи";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Light", 24F);
            lblTitle.ForeColor = Color.FromArgb(46, 74, 107);
            lblTitle.Location = new Point(20, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Личный кабинет";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1284, 770);
            Controls.Add(pnlCard);
            MinimumSize = new Size(640, 620);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Личный кабинет";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmailCaption;
        private Label lblEmailValue;
        private Label lblRoleCaption;
        private Label lblRoleValue;
        private Button btnChangePassword;
        private Button btnLogout;
        private Button btnHome;
    }
}
