using ��������;

namespace Tests
{
    [TestFixture] // �������, ����������� �� ����� � �������
    public class Tests
    {
        private RegisterForm registerForm;

        [SetUp] // ���� ����� ����������� ����� ������ ������
        public void Setup()
        {
            // ������������� ����� ����������� ����� ������ ������
            registerForm = new RegisterForm();
        }

        [Test] // ������� ��� ����������� ������ ��� �����
        public void Register_WithEmptyFields_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "";
            registerForm.txtPassword.Text = "";
            registerForm.txtConfirmPassword.Text = "";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("��� ���� ������ ���� ���������!", registerForm.LastErrorMessage);
        }

        [Test] // ������ ����
        public void Register_WithMismatchedPasswords_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "user123";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password2";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("������ �� ���������!", registerForm.LastErrorMessage);
        }

        [Test] // ������ ����
        public void Register_WithExistingUsername_ShouldShowErrorMessage()
        {
            // Arrange
            registerForm.txtUsername.Text = "existingUser";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password1";

            // ��������� ����������� ��� ������������� ������������
            registerForm.dbHelper.RegisterUser("existingUser", "Password1");

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("������������ � ����� ������ ��� ����������!", registerForm.LastErrorMessage);
        }

        [Test] // ��������� ����
        public void Register_WithValidData_ShouldRegisterUser()
        {
            // Arrange
            registerForm.txtUsername.Text = "newUser";
            registerForm.txtPassword.Text = "Password1";
            registerForm.txtConfirmPassword.Text = "Password1";

            // Act
            registerForm.btnRegister_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("����������� ������ �������!", registerForm.LastSuccessMessage);
        }
    }
}