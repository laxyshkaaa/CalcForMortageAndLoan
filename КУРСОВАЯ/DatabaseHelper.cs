using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=calculations.db;Version=3;";
        public DatabaseHelper()
        {
            // Вызываем инициализацию базы данных при создании экземпляра DatabaseHelper
            InitializeDatabase();
        }

        // Метод для инициализации базы данных (создание таблиц)
        public void InitializeDatabase()
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // Создание таблицы пользователей
                string createUsersTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Username TEXT NOT NULL UNIQUE, 
                    Password TEXT NOT NULL
                );";

                // Создание таблицы истории вычислений
                string createCalculationHistoryTableQuery = @"
                CREATE TABLE IF NOT EXISTS CalculationHistory (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    UserId INTEGER,  
                    Date TEXT, 
                    LoanAmount REAL, 
                    TermMonths INTEGER, 
                    InterestRate REAL, 
                    MonthlyPayment REAL, 
                    TotalPayment REAL,
                    FOREIGN KEY (UserId) REFERENCES Users(Id)
                );";

                using (var command1 = new SQLiteCommand(createUsersTableQuery, connection))
                using (var command2 = new SQLiteCommand(createCalculationHistoryTableQuery, connection))
                {
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
            }
        }


        // Метод для хеширования пароля
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Метод для регистрации нового пользователя
        public virtual bool RegisterUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Проверяем, существует ли пользователь с таким же именем
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SQLiteCommand checkUserCommand = new SQLiteCommand(checkUserQuery, connection))
                {
                    checkUserCommand.Parameters.AddWithValue("@username", username);
                    object result = checkUserCommand.ExecuteScalar();
                    if (result != null && Convert.ToInt64(result) > 0)
                    {
                        return false; // Пользователь с таким именем уже существует
                    }
                }

                // Вставка нового пользователя
                string insertUserQuery = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                using (SQLiteCommand insertUserCommand = new SQLiteCommand(insertUserQuery, connection))
                {
                    insertUserCommand.Parameters.AddWithValue("@username", username);
                    insertUserCommand.Parameters.AddWithValue("@password", HashPassword(password)); // Хешируем пароль
                    insertUserCommand.ExecuteNonQuery();
                }

                return true; // Регистрация успешна
            }
        }

        // Метод для проверки логина
        public bool CheckLogin(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Поиск пользователя с совпадающими логином и паролем
                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", HashPassword(password)); // Хешируем пароль

                    object result = command.ExecuteScalar();
                    return result != null && Convert.ToInt64(result) > 0; // Вернёт true, если пользователь найден
                }
            }
        }

        // Метод для получения ID пользователя по имени
        public int GetUserId(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Id FROM Users WHERE Username = @username";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        // Метод для добавления новой записи в историю вычислений
        public void AddCalculation(int userId, string date, double loanAmount, int termMonths, double interestRate, double monthlyPayment, double totalPayment)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"
        INSERT INTO CalculationHistory (UserId, Date, LoanAmount, TermMonths, InterestRate, MonthlyPayment, TotalPayment) 
        VALUES (@userId, @date, @loanAmount, @termMonths, @interestRate, @monthlyPayment, @totalPayment)";

                SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@loanAmount", loanAmount);
                command.Parameters.AddWithValue("@termMonths", termMonths);
                command.Parameters.AddWithValue("@interestRate", interestRate);
                command.Parameters.AddWithValue("@monthlyPayment", monthlyPayment);
                command.Parameters.AddWithValue("@totalPayment", totalPayment);

                command.ExecuteNonQuery();
            }
        }

        // Метод для получения всех записей для конкретного пользователя
        public DataTable GetCalculationHistoryByUser(int userId)
        {
            DataTable historyTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Date, LoanAmount, TermMonths, InterestRate, MonthlyPayment, TotalPayment FROM CalculationHistory WHERE UserId = @userId";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Заполняем DataTable данными из базы данных
                        historyTable.Load(reader);
                    }
                }
            }
            return historyTable;
        }

        public void DeleteUserHistory(int userId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM CalculationHistory WHERE UserId = @UserId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Обычный метод для получения всех записей
        public DataTable GetCalculationHistory()
        {
            DataTable historyTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, Date, LoanAmount, TermMonths, InterestRate, MonthlyPayment, TotalPayment FROM CalculationHistory";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Заполняем DataTable данными из базы данных
                        historyTable.Load(reader);
                    }
                }
            }
            return historyTable;
        }
    }
}
