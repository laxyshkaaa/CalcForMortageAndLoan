using System.Windows.Forms;
using System;
using КУРСОВАЯ;
public  static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Запускаем форму логина
        LoginForm loginForm = new LoginForm();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            // Если пользователь успешно вошел, получаем userId
            int userId = loginForm.UserId;

            // Запускаем основную форму с userId
            Application.Run(new MainForm(userId));
        }
        else
        {
            // Если вход не удался, можно завершить приложение или что-то другое
            Application.Exit();
        }
    }
}
