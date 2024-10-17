using Microsoft.VisualStudio.TestTools.UnitTesting;
using КУРСОВАЯ;
using System.Windows.Forms;
using System;

namespace КУРСОВАЯ.Tests
{
    [TestClass()]
    public class RegisterFormTests
    {
        private RegisterForm form;

        [TestInitialize]
        public void Setup()
        {
            // Инициализация формы перед каждым тестом
            form = new RegisterForm();
        }

        [TestMethod()]
        public void btnRegister_Click_EmptyFields_ShouldShowErrorMessage()
        {
            // Arrange
            form.Username = ""; // Пустое имя пользователя
            form.Password = ""; // Пустой пароль
            form.ConfirmPassword = ""; // Пустое подтверждение пароля

            // Act
            form.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Все поля должны быть заполнены!", form.LastErrorMessage);
        }

        [TestMethod()]
        public void btnRegister_Click_PasswordsDoNotMatch_ShouldShowErrorMessage()
        {
            // Arrange
            form.Username = "testuser"; // Вводим корректное имя пользователя
            form.Password = "password123"; // Вводим пароль
            form.ConfirmPassword = "differentpassword"; // Вводим неподходящее подтверждение пароля

            // Act
            form.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Пароли не совпадают!", form.LastErrorMessage);
        }

        [TestMethod()]
        public void btnRegister_Click_ValidData_ShouldShowSuccessMessage()
        {
            // Arrange
            form.Username = "testuser"; // Вводим корректное имя пользователя
            form.Password = "password123"; // Вводим корректный пароль
            form.ConfirmPassword = "password123"; // Подтверждаем тот же пароль

            // Эмулируем успешный сценарий регистрации
            form.dbHelper = new FakeDbHelper(true); // Имитация успешной регистрации

            // Act
            form.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Регистрация прошла успешно!", form.LastSuccessMessage);
        }

        [TestMethod()]
        public void btnRegister_Click_UserAlreadyExists_ShouldShowErrorMessage()
        {
            // Arrange
            form.Username = "existinguser"; // Имя пользователя уже существует
            form.Password = "password123";
            form.ConfirmPassword = "password123";

            // Эмулируем сценарий, где пользователь уже существует
            form.dbHelper = new FakeDbHelper(false); // Имитация неуспешной регистрации

            // Act
            form.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Пользователь с таким именем уже существует!", form.LastErrorMessage);
        }

        // Имитация DatabaseHelper
        private class FakeDbHelper : DatabaseHelper
        {
            private readonly bool isSuccess;

            public FakeDbHelper(bool success)
            {
                isSuccess = success;
            }

            public override bool RegisterUser(string username, string password)
            {
                return isSuccess; // Эмулируем успешную или неуспешную регистрацию
            }
        }
    }
}
