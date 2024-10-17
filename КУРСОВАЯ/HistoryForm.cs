using System;
using System.Data;
using System.Drawing; // Для работы с Color
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public partial class HistoryForm : Form
    {
        private DatabaseHelper dbHelper;
        private int userId; // Идентификатор пользователя

        public HistoryForm(int currentUserId)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            userId = currentUserId; // Устанавливаем идентификатор пользователя
            LoadHistory(); // Загрузка истории при открытии формы
            InitializeButtonClear();
        }
        private void InitializeButtonClear()
        {
            // Стилизация кнопки "Расчет кредита"
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.BackColor = Color.FromArgb(0, 122, 204);
            clearButton.ForeColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            clearButton.FlatAppearance.BorderSize = 0;

       
        }

        // Метод для загрузки истории из базы данных
        private void LoadHistory()
        {
            DataTable historyTable = dbHelper.GetCalculationHistoryByUser(userId); // Получаем историю для конкретного пользователя

            dgvHistory.Columns.Clear();
            dgvHistory.DataSource = historyTable;

            if (dgvHistory.Columns.Count > 0)
            {
                dgvHistory.Columns["Date"].HeaderText = "Дата";
                dgvHistory.Columns["LoanAmount"].HeaderText = "Сумма кредита (₽)";
                dgvHistory.Columns["TermMonths"].HeaderText = "Срок (мес)";
                dgvHistory.Columns["InterestRate"].HeaderText = "Процентная ставка (%)";
                dgvHistory.Columns["MonthlyPayment"].HeaderText = "Ежемесячный платеж (₽)";
                dgvHistory.Columns["TotalPayment"].HeaderText = "Общая сумма выплат (₽)";
            }
        }

        // Обработчик события для нажатия на изображение "Назад"
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрыть форму истории
        }

        // Обработчик события для наведения курсора на изображение "Назад"
        private void pictureBoxBack_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBack.BackColor = Color.LightGray; // Изменение фона при наведении
        }

        // Обработчик события для выхода курсора с изображения "Назад"
        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.BackColor = Color.Transparent; // Возвращение фона к прозрачному
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Подтверждение действия от пользователя
            var result = MessageBox.Show("Вы уверены, что хотите очистить всю историю?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Удаляем историю пользователя
                dbHelper.DeleteUserHistory(userId);

                // Обновляем DataGridView
                LoadHistory();

                MessageBox.Show("История успешно очищена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
