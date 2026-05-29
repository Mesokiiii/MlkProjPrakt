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
using Microsoft.VisualBasic;

namespace Mb.UI.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
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

                bool isSuccess = AuthService.Login(login, password);
                if (isSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                } else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } 
            }  catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при авторизации: {ex.Message}", "Критическая ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
