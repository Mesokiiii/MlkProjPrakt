using System.Linq.Expressions;

namespace Mb.UI.Register
{
    public partial class RegisterForm : Form
    {

        private readonly AuthService authService;
        public RegisterForm(AuthService authService)
        {
            InitializeComponent();
            this.authService = authService;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text;

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (password != confirm)
            {
                MessageBox.Show("Ваши пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль не может быть меньше 6 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool isSuccess = authService.Register(login, password, Roles.Guest);
                
                if (isSuccess)
                {

                    MessageBox.Show("Регистрация прошла успешно. Теперь войдите в систему", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрировать Вас в систему", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
            } catch (Exception ex)

            {
                MessageBox.Show($"Не удалось зарегистрировать Вас в систему, возможно пользователь с таким логином уже существует. {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Просто закрываем эту форму, под ней уже открыта форма логина (мы ее скрыли через Hide())
            this.Close();
        }

    }
}
