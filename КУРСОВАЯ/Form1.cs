using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    public partial class MainForm : Form
    {
        private DatabaseHelper dbHelper;
        private int userId; // Идентификатор текущего пользователя
        private ToolTip mortgageInfoToolTip;
        private ToolTip loanInfoToolTip;

        public MainForm(int currentUserId)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Инициализация базы данных
            dbHelper.InitializeDatabase(); // Создание таблицы, если её нет
            InitializeButtons();

            InitializeLoanTypes(); // Инициализация типов кредита в ComboBox
            InitializeToolTip();
            userId = currentUserId; // Установка userId для текущего пользователя
        }

        private void InitializeToolTip()
        {
            // Инициализация ToolTip для ипотеки
            mortgageInfoToolTip = new ToolTip();
            mortgageInfoToolTip.ToolTipTitle = "Информация о типах ипотеки";
            mortgageInfoToolTip.ToolTipIcon = ToolTipIcon.Info;
            mortgageInfoToolTip.IsBalloon = true;

            // Инициализация ToolTip для кредита
            loanInfoToolTip = new ToolTip();
            loanInfoToolTip.ToolTipTitle = "Информация о типах кредитов";
            loanInfoToolTip.ToolTipIcon = ToolTipIcon.Info;
            loanInfoToolTip.IsBalloon = true;
        }

        private void InitializeButtons()
        {
            // Стилизация кнопки "Расчет кредита"
            btnCalculateLoan.FlatStyle = FlatStyle.Flat;
            btnCalculateLoan.BackColor = Color.FromArgb(0, 122, 204);
            btnCalculateLoan.ForeColor = Color.White;
            btnCalculateLoan.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCalculateLoan.FlatAppearance.BorderSize = 0;

            // Добавление событий наведения
            btnCalculateLoan.MouseEnter += Button_MouseEnter;
            btnCalculateLoan.MouseLeave += Button_MouseLeave;
        }
        private string GetMortgageInfoText()
        {
            return "Военная ипотека: Предоставляется военнослужащим. Процентная ставка – 19.6%.\n\n" +
                   "IT-ипотека: Предоставляется работникам IT-компаний. Процентная ставка – 6.0%.\n\n" +
                   "Семейная ипотека: Предназначена для семей с детьми. Процентная ставка – 5.0%.\n\n " +
                   "P.S : Проценты по ипотечным кредитам зависят от многих условий, в первую очередь от \nинфляции и ключевой ставки Банка России. На данный момент ключевая ставка составляет 19 %";
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 150, 255); // Цвет при наведении
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(0, 122, 204); // Исходный цвет
        }

        // Инициализация типов кредитов в ComboBox
        private void InitializeLoanTypes()
        {
            cmbLoanType.Items.AddRange(new string[]
            {
                "Автокредит",
                "Кредит на образование",
                "Рефинансирование",
                "Кредит на газификацию"

            });

            cmbLoanType.SelectedIndex = -1; // Не устанавливаем элемент по умолчанию
        }

        // Метод для расчета ипотеки
        private void btnCalculateMortgage_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на пустые поля
                if (string.IsNullOrEmpty(txtLoanAmountMortgage.Text) || string.IsNullOrEmpty(txtTermMonthsMortgage.Text))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                    return;
                }

                // Преобразование введенных данных
                double loanAmount = Convert.ToDouble(txtLoanAmountMortgage.Text);
                int termMonths = Convert.ToInt32(txtTermMonthsMortgage.Text);

                // Проверка на отрицательные значения
                if (loanAmount < 0)
                {
                    MessageBox.Show("Сумма кредита не может быть отрицательной!", "Ошибка");
                    return;
                }

                if (termMonths < 0)
                {
                    MessageBox.Show("Срок кредита не может быть отрицательным!", "Ошибка");
                    return;
                }

                // Установка процентной ставки в зависимости от выбранного типа ипотеки
                double annualRate;
                if (cmbMortgageType.SelectedItem == null)
                {
                    annualRate = Convert.ToDouble(txtAnnualRateMortgage.Text);
                }
                else
                {
                    switch (cmbMortgageType.SelectedItem.ToString())
                    {
                        case "Военная ипотека":
                            annualRate = 19.6;
                            break;
                        case "IT-ипотека":
                            annualRate = 6.0;
                            break;
                        case "Семейная ипотека":
                            annualRate = 5.0;
                            break;

                        default:
                            annualRate = Convert.ToDouble(txtAnnualRateMortgage.Text);
                            break;
                    }
                }

                double monthlyRate = annualRate / 100 / 12;

                // Проверка на деление на ноль
                if (monthlyRate == 0)
                {
                    MessageBox.Show("Процентная ставка не может быть нулевой!", "Ошибка");
                    return;
                }

                double monthlyPayment = (loanAmount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -termMonths));
                double totalPayment = monthlyPayment * termMonths;
                double totalInterest = totalPayment - loanAmount;

                // Сохраняем данные с привязкой к userId
                dbHelper.AddCalculation(userId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), loanAmount, termMonths, annualRate, monthlyPayment, totalPayment);

                lblMonthlyPaymentMortgage.Text = $"Ежемесячный платеж: {monthlyPayment:F2} ₽";
                lblTotalPaymentMortgage.Text = $"Общая сумма выплат: {totalPayment:F2} ₽";
                lblTotalInterestMortgage.Text = $"Переплаченная сумма: {totalInterest:F2} ₽";
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат ввода данных! Пожалуйста, проверьте вводимые значения.", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message);
            }
        }


        // Метод для расчета кредита с выбором типа кредита или вводом процентной ставки вручную
        private void btnCalculateLoan_Click(object sender, EventArgs e)
        {
            try
            {
                double loanAmount = Convert.ToDouble(txtLoanAmountLoan.Text);
                int termMonths = Convert.ToInt32(txtTermMonthsLoan.Text);

                double annualRate;

                if (cmbLoanType.SelectedItem == null)
                {
                    annualRate = Convert.ToDouble(txtAnnualRateLoan.Text);
                }
                else
                {
                    switch (cmbLoanType.SelectedItem.ToString())
                    {
                        case "Автокредит":
                            annualRate = 22.0;
                            break;
                        case "Кредит на образование":
                            annualRate = 3.0;
                            break;
                        case "Рефинансирование":
                            annualRate = 21.0;
                            break;
                        case "Кредит на газификацию":
                            annualRate = 3.3;
                            break;
                        default:
                            annualRate = Convert.ToDouble(txtAnnualRateLoan.Text);
                            break;
                    }
                }

                double monthlyRate = annualRate / 100 / 12;
                double monthlyPayment = (loanAmount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -termMonths));
                double totalPayment = monthlyPayment * termMonths;
                double totalInterest = totalPayment - loanAmount;

                // Сохраняем данные с привязкой к userId
                dbHelper.AddCalculation(userId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), loanAmount, termMonths, annualRate, monthlyPayment, totalPayment);

                lblLoanMonthlyPayment.Text = $"Ежемесячный платеж: {monthlyPayment:F2} ₽";
                lblLoanTotalPayment.Text = $"Общая сумма выплат: {totalPayment:F2} ₽";
                lblLoanTotalInterest.Text = $"Переплаченная сумма: {totalInterest:F2} ₽";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message);
            }
        }

        // Показать историю расчетов
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(userId); // Передаем userId в форму истории
            historyForm.ShowDialog();
        }

        // Общий метод для копирования текста
        private void CopyLabelTextToClipboard(Label label, string textToRemove)
        {
            if (!string.IsNullOrEmpty(label.Text))
            {
                string cleanedText = label.Text.Replace(textToRemove, "");
                string pattern = @"[\d,.]+ ₽";
                Match match = Regex.Match(cleanedText, pattern);

                if (match.Success)
                {
                    Clipboard.SetText(match.Value);
                    MessageBox.Show("Сумма скопирована в буфер обмена!");
                }
                else
                {
                    MessageBox.Show("Не удалось скопировать сумму.");
                }
            }
        }

        // Общий обработчик события для PictureBox
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                if (clickedPictureBox == pictureBox1)
                {
                    CopyLabelTextToClipboard(lblMonthlyPaymentMortgage, "Ежемесячный платеж: ");
                }
                else if (clickedPictureBox == pictureBox2)
                {
                    CopyLabelTextToClipboard(lblTotalInterestMortgage, "Переплаченные проценты: ");
                }
                else if (clickedPictureBox == pictureBox3)
                {
                    CopyLabelTextToClipboard(lblTotalPaymentMortgage, "Общая сумма платежа: ");
                }
                else if (clickedPictureBox == pictureBox4)
                {
                    CopyLabelTextToClipboard(lblLoanMonthlyPayment, "Ежемесячный платеж: ");
                }
                else if (clickedPictureBox == pictureBox5)
                {
                    CopyLabelTextToClipboard(lblLoanTotalInterest, "Переплаченные проценты: ");
                }
                else if (clickedPictureBox == pictureBox6)
                {
                    CopyLabelTextToClipboard(lblLoanTotalPayment, "Общая сумма платежа: ");
                }
            }
        }

        private void pictureBoxinfo_Click(object sender, EventArgs e)
        {
            // Программный вызов отображения ToolTip при клике на PictureBox
            mortgageInfoToolTip.Show(GetMortgageInfoText(), pictureBoxinfo, pictureBoxinfo.Width / 2 - 20, pictureBoxinfo.Height -150 , 3000); // Время отображения ToolTip = 5 секунд
        }

        private void pictureBoxinfoLoan_Click(object sender, EventArgs e)
        {
            // Программный вызов отображения ToolTip при клике на PictureBox кредита
            loanInfoToolTip.Show(GetLoanInfoText(), pictureBoxinfoLoan, pictureBoxinfoLoan.Width / 2, pictureBoxinfoLoan.Height / 2, 5000);
        }
        private string GetLoanInfoText()
        {
            return "Автокредит: Выдается на покупку автомобиля. Процентная ставка – 22.0%.\n\n" +
                   "Кредит на образование: Предназначен для оплаты учебы. Процентная ставка – 3.0%.\n\n" +
                   "Рефинансирование: Объединение нескольких кредитов в один. Процентная ставка – 21.0%.\n\n" +
                   "Кредит на газификацию: Для оплаты установки газового оборудования. Процентная ставка – 3.3%.\n\n" +
                   "P.S : Проценты по потребительским кредитам зависят от многих условий, в первую очередь от \nинфляции и ключевой ставки Банка России. На данный момент ключевая ставка составляет 19 %";
        }
    }
}
