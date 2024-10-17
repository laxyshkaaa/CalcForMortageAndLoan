using System;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper dbHelper;
        private int userId; // Храним userId

        public LoginForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        public int UserId // Свойство для получения userId
        {
            get { return userId; }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка логина
            bool isValid = dbHelper.CheckLogin(username, password);

            if (isValid)
            {
                // Получение ID пользователя
                userId = dbHelper.GetUserId(username); // Сохраняем userId в поле

                if (userId != -1)
                {
                    MessageBox.Show("Вход успешен!", "Успех");
                    this.Hide(); // Закрываем форму логина после открытия основной

                    // Создаем и открываем основную форму
                    MainForm mainForm = new MainForm(userId);
                    mainForm.ShowDialog();

                   
                    
                }
                else
                {
                    MessageBox.Show("Ошибка получения данных пользователя!", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!", "Ошибка");
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
    {

            // Создаем и открываем форму регистрации
    this.Hide();
    RegisterForm registerForm = new RegisterForm();
    registerForm.ShowDialog(); // Открываем как модальную форму

    // После закрытия формы регистрации возвращаемся к форме логина
    this.Show(); // Показываем форму логина снова
}

    }
}
