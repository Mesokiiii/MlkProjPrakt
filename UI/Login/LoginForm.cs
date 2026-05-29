using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mb.UI.Register;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;

namespace Mb.UI.Login
{
    public partial class LoginForm : Form
    {
        private readonly AuthService authService;
        private readonly IServiceProvider services;
        public LoginForm(AuthService authService, IServiceProvider services)
        {
            this.authService = authService;
            this.services = services;

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Пожалуйста, введите логин или пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool isSuccess = authService.Login(login, password);
                if (isSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при авторизации: {ex.Message}", "Критическая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    this.Close(); // Просто закрываем форму регистрации
}

       private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    RegisterForm registerForm = services.GetRequiredService<RegisterForm>();

    this.Hide(); // ЭТА СТРОЧКА СКРОЕТ ОКНО ВХОДА (оно полностью исчезнет с экрана)

    registerForm.ShowDialog(); // Открываем регистрацию

    this.Show(); // Когда пользователь закроет регистрацию, окно входа появится снова!
}
    }
    
}
