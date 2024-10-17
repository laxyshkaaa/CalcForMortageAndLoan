using System.Windows.Forms;
using System;

namespace КУРСОВАЯ
{
    public partial class RegisterForm : Form
    {
        public DatabaseHelper dbHelper;

        public RegisterForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string ConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }

        public string LastErrorMessage { get; private set; }
        public string LastSuccessMessage { get; private set; }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            string username = Username;
            string password = Password;
            string confirmPassword = ConfirmPassword;

            // Очистим предыдущие сообщения
            LastErrorMessage = string.Empty;
            LastSuccessMessage = string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                LastErrorMessage = "Все поля должны быть заполнены!";
                MessageBox.Show(LastErrorMessage, "Ошибка");
                return;
            }

            if (password != confirmPassword)
            {
                LastErrorMessage = "Пароли не совпадают!";
                MessageBox.Show(LastErrorMessage, "Ошибка");
                return;
            }

            bool success = dbHelper.RegisterUser(username, password);

            if (success)
            {
                LastSuccessMessage = "Регистрация прошла успешно!";
                MessageBox.Show(LastSuccessMessage, "Успех");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
            else
            {
                LastErrorMessage = "Пользователь с таким именем уже существует!";
                MessageBox.Show(LastErrorMessage, "Ошибка");
            }
        }
    }
}
