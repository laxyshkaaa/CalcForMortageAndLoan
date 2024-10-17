using КУРСОВАЯ;

namespace Tests
{
    [TestFixture] // Атрибут, указывающий на класс с тестами
    public class Tests
    {
        private RegisterForm registerForm;

        [SetUp] // Этот метод выполняется перед каждым тестом
        public void Setup()
        {
            // Инициализация формы регистрации перед каждым тестом
            registerForm = new RegisterForm();
        }

        [Test] // Атрибут для определения метода как теста
        public void Register_WithEmptyFields_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "";
            registerForm.txtPassword.Text = "";
            registerForm.txtConfirmPassword.Text = "";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Все поля должны быть заполнены!", registerForm.LastErrorMessage);
        }

        [Test] // Второй тест
        public void Register_WithMismatchedPasswords_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "user123";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password2";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Пароли не совпадают!", registerForm.LastErrorMessage);
        }

        [Test] // Третий тест
        public void Register_WithExistingUsername_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "existingUser";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password1";

            // Симуляция регистрации уже существующего пользователя
            registerForm.dbHelper.RegisterUser("existingUser", "Password1");

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Пользователь с таким именем уже существует!", registerForm.LastErrorMessage);
        }

        [Test] // Четвертый тест
        public void Register_WithValidData_ShouldRegisterUser()
        {
            // Arrange
            registerForm.txtUsername.Text = "newUser";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password1";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("Регистрация прошла успешно!", registerForm.LastSuccessMessage);
        }
    }
}