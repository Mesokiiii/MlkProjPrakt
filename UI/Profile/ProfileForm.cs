namespace Mb.UI.Profile
{
    public partial class ProfileForm : Form
    {
        private readonly AuthService authService;

        public ProfileForm(AuthService authService)
        {
            this.authService = authService;
            InitializeComponent();
            this.Load += ProfileForm_Load;
            btnLogout.Click += btnLogout_Click;
            btnHome.Click += btnHome_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblEmailValue.Text = UserSession.CurrentUserName;
            lblRoleValue.Text = UserSession.CurrentRole;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Простая форма ввода через InputBox-подход (3 текстовых поля в отдельной форме)
            using var dialog = new Form();
            dialog.Text = "Смена пароля";
            dialog.Size = new Size(350, 250);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;

            var lblOld = new Label { Text = "Текущий пароль:", Location = new Point(20, 20), AutoSize = true };
            var txtOld = new TextBox { Location = new Point(20, 45), Size = new Size(290, 28), UseSystemPasswordChar = true };
            var lblNew = new Label { Text = "Новый пароль:", Location = new Point(20, 80), AutoSize = true };
            var txtNew = new TextBox { Location = new Point(20, 105), Size = new Size(290, 28), UseSystemPasswordChar = true };
            var btnOk = new Button { Text = "Сменить", Location = new Point(20, 150), Size = new Size(130, 36), DialogResult = DialogResult.OK };
            var btnCancel = new Button { Text = "Отмена", Location = new Point(180, 150), Size = new Size(130, 36), DialogResult = DialogResult.Cancel };

            dialog.Controls.AddRange(new Control[] { lblOld, txtOld, lblNew, txtNew, btnOk, btnCancel });
            dialog.AcceptButton = btnOk;
            dialog.CancelButton = btnCancel;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string oldPass = txtOld.Text.Trim();
                string newPass = txtNew.Text.Trim();

                if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
                {
                    MessageBox.Show("Заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPass.Length < 6)
                {
                    MessageBox.Show("Новый пароль должен быть не менее 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    bool success = authService.ChangePassword(oldPass, newPass);
                    if (success)
                    {
                        MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Неверный текущий пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы уверены, что хотите выйти из системы?",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.Logout();
                MessageBox.Show("Вы успешно вышли из системы.", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Просто закрываем форму профиля и возвращаемся в главное меню 
            }
        }

        private void btnHome_Click(object sender, EventArgs e) => this.Close();
    }
}
