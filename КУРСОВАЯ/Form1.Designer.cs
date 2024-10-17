using System.Drawing;
using System.Windows.Forms;

namespace КУРСОВАЯ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMortgage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoanAmountMortgage = new System.Windows.Forms.Label();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.lblTotalInterestMortgage = new System.Windows.Forms.Label();
            this.txtLoanAmountMortgage = new System.Windows.Forms.TextBox();
            this.lblAnnualRateMortgage = new System.Windows.Forms.Label();
            this.txtAnnualRateMortgage = new System.Windows.Forms.TextBox();
            this.lblTermMonthsMortgage = new System.Windows.Forms.Label();
            this.txtTermMonthsMortgage = new System.Windows.Forms.TextBox();
            this.btnCalculateMortgage = new System.Windows.Forms.Button();
            this.lblMonthlyPaymentMortgage = new System.Windows.Forms.Label();
            this.lblTotalPaymentMortgage = new System.Windows.Forms.Label();
            this.lblMortgageType = new System.Windows.Forms.Label();
            this.cmbMortgageType = new System.Windows.Forms.ComboBox();
            this.tabPageLoan = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblLoanAmountLoan = new System.Windows.Forms.Label();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.txtLoanAmountLoan = new System.Windows.Forms.TextBox();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.lblLoanMonthlyPayment = new System.Windows.Forms.Label();
            this.lblAnnualRateLoan = new System.Windows.Forms.Label();
            this.txtAnnualRateLoan = new System.Windows.Forms.TextBox();
            this.lblTermMonthsLoan = new System.Windows.Forms.Label();
            this.txtTermMonthsLoan = new System.Windows.Forms.TextBox();
            this.btnCalculateLoan = new System.Windows.Forms.Button();
            this.btnShowHistoryCredit = new System.Windows.Forms.Button();
            this.lblLoanTotalInterest = new System.Windows.Forms.Label();
            this.lblLoanTotalPayment = new System.Windows.Forms.Label();
            this.pictureBoxinfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxinfoLoan = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageMortgage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfoLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMortgage);
            this.tabControl1.Controls.Add(this.tabPageLoan);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMortgage
            // 
            this.tabPageMortgage.Controls.Add(this.pictureBoxinfo);
            this.tabPageMortgage.Controls.Add(this.pictureBox3);
            this.tabPageMortgage.Controls.Add(this.pictureBox2);
            this.tabPageMortgage.Controls.Add(this.pictureBox1);
            this.tabPageMortgage.Controls.Add(this.lblLoanAmountMortgage);
            this.tabPageMortgage.Controls.Add(this.btnShowHistory);
            this.tabPageMortgage.Controls.Add(this.lblTotalInterestMortgage);
            this.tabPageMortgage.Controls.Add(this.txtLoanAmountMortgage);
            this.tabPageMortgage.Controls.Add(this.lblAnnualRateMortgage);
            this.tabPageMortgage.Controls.Add(this.txtAnnualRateMortgage);
            this.tabPageMortgage.Controls.Add(this.lblTermMonthsMortgage);
            this.tabPageMortgage.Controls.Add(this.txtTermMonthsMortgage);
            this.tabPageMortgage.Controls.Add(this.btnCalculateMortgage);
            this.tabPageMortgage.Controls.Add(this.lblMonthlyPaymentMortgage);
            this.tabPageMortgage.Controls.Add(this.lblTotalPaymentMortgage);
            this.tabPageMortgage.Controls.Add(this.lblMortgageType);
            this.tabPageMortgage.Controls.Add(this.cmbMortgageType);
            this.tabPageMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageMortgage.Location = new System.Drawing.Point(4, 25);
            this.tabPageMortgage.Name = "tabPageMortgage";
            this.tabPageMortgage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMortgage.Size = new System.Drawing.Size(397, 417);
            this.tabPageMortgage.TabIndex = 0;
            this.tabPageMortgage.Text = "Ипотека";
            this.tabPageMortgage.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox3.Location = new System.Drawing.Point(322, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox2.Location = new System.Drawing.Point(322, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox1.Location = new System.Drawing.Point(322, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblLoanAmountMortgage
            // 
            this.lblLoanAmountMortgage.AutoSize = true;
            this.lblLoanAmountMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoanAmountMortgage.Location = new System.Drawing.Point(20, 20);
            this.lblLoanAmountMortgage.Name = "lblLoanAmountMortgage";
            this.lblLoanAmountMortgage.Size = new System.Drawing.Size(110, 16);
            this.lblLoanAmountMortgage.TabIndex = 0;
            this.lblLoanAmountMortgage.Text = "Сумма ипотеки";
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(23, 350);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(330, 30);
            this.btnShowHistory.TabIndex = 9;
            this.btnShowHistory.Text = "Показать историю";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // lblTotalInterestMortgage
            // 
            this.lblTotalInterestMortgage.AutoSize = true;
            this.lblTotalInterestMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalInterestMortgage.Location = new System.Drawing.Point(20, 229);
            this.lblTotalInterestMortgage.Name = "lblTotalInterestMortgage";
            this.lblTotalInterestMortgage.Size = new System.Drawing.Size(194, 16);
            this.lblTotalInterestMortgage.TabIndex = 10;
            this.lblTotalInterestMortgage.Text = "Переплаченные проценты: ";
            // 
            // txtLoanAmountMortgage
            // 
            this.txtLoanAmountMortgage.Location = new System.Drawing.Point(200, 20);
            this.txtLoanAmountMortgage.Name = "txtLoanAmountMortgage";
            this.txtLoanAmountMortgage.Size = new System.Drawing.Size(150, 23);
            this.txtLoanAmountMortgage.TabIndex = 1;
            // 
            // lblAnnualRateMortgage
            // 
            this.lblAnnualRateMortgage.AutoSize = true;
            this.lblAnnualRateMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnualRateMortgage.Location = new System.Drawing.Point(20, 60);
            this.lblAnnualRateMortgage.Name = "lblAnnualRateMortgage";
            this.lblAnnualRateMortgage.Size = new System.Drawing.Size(140, 16);
            this.lblAnnualRateMortgage.TabIndex = 2;
            this.lblAnnualRateMortgage.Text = "Процентная ставка";
            // 
            // txtAnnualRateMortgage
            // 
            this.txtAnnualRateMortgage.Location = new System.Drawing.Point(200, 60);
            this.txtAnnualRateMortgage.Name = "txtAnnualRateMortgage";
            this.txtAnnualRateMortgage.Size = new System.Drawing.Size(150, 23);
            this.txtAnnualRateMortgage.TabIndex = 3;
            // 
            // lblTermMonthsMortgage
            // 
            this.lblTermMonthsMortgage.AutoSize = true;
            this.lblTermMonthsMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTermMonthsMortgage.Location = new System.Drawing.Point(20, 100);
            this.lblTermMonthsMortgage.Name = "lblTermMonthsMortgage";
            this.lblTermMonthsMortgage.Size = new System.Drawing.Size(127, 16);
            this.lblTermMonthsMortgage.TabIndex = 4;
            this.lblTermMonthsMortgage.Text = "Срок (в месяцах)";
            // 
            // txtTermMonthsMortgage
            // 
            this.txtTermMonthsMortgage.Location = new System.Drawing.Point(200, 100);
            this.txtTermMonthsMortgage.Name = "txtTermMonthsMortgage";
            this.txtTermMonthsMortgage.Size = new System.Drawing.Size(150, 23);
            this.txtTermMonthsMortgage.TabIndex = 5;
            // 
            // btnCalculateMortgage
            // 
            this.btnCalculateMortgage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCalculateMortgage.FlatAppearance.BorderSize = 0;
            this.btnCalculateMortgage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMortgage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculateMortgage.ForeColor = System.Drawing.Color.White;
            this.btnCalculateMortgage.Location = new System.Drawing.Point(20, 297);
            this.btnCalculateMortgage.Name = "btnCalculateMortgage";
            this.btnCalculateMortgage.Size = new System.Drawing.Size(330, 30);
            this.btnCalculateMortgage.TabIndex = 6;
            this.btnCalculateMortgage.Text = "Рассчитать";
            this.btnCalculateMortgage.UseVisualStyleBackColor = false;
            this.btnCalculateMortgage.Click += new System.EventHandler(this.btnCalculateMortgage_Click);
            // 
            // lblMonthlyPaymentMortgage
            // 
            this.lblMonthlyPaymentMortgage.AutoSize = true;
            this.lblMonthlyPaymentMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonthlyPaymentMortgage.Location = new System.Drawing.Point(20, 199);
            this.lblMonthlyPaymentMortgage.Name = "lblMonthlyPaymentMortgage";
            this.lblMonthlyPaymentMortgage.Size = new System.Drawing.Size(166, 16);
            this.lblMonthlyPaymentMortgage.TabIndex = 7;
            this.lblMonthlyPaymentMortgage.Text = "Ежемесячный платёж: ";
            // 
            // lblTotalPaymentMortgage
            // 
            this.lblTotalPaymentMortgage.AutoSize = true;
            this.lblTotalPaymentMortgage.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalPaymentMortgage.Location = new System.Drawing.Point(20, 261);
            this.lblTotalPaymentMortgage.Name = "lblTotalPaymentMortgage";
            this.lblTotalPaymentMortgage.Size = new System.Drawing.Size(174, 16);
            this.lblTotalPaymentMortgage.TabIndex = 8;
            this.lblTotalPaymentMortgage.Text = "Общая сумма платежа: ";
            // 
            // lblMortgageType
            // 
            this.lblMortgageType.AutoSize = true;
            this.lblMortgageType.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMortgageType.Location = new System.Drawing.Point(20, 156);
            this.lblMortgageType.Name = "lblMortgageType";
            this.lblMortgageType.Size = new System.Drawing.Size(92, 16);
            this.lblMortgageType.TabIndex = 9;
            this.lblMortgageType.Text = "Тип ипотеки";
            // 
            // cmbMortgageType
            // 
            this.cmbMortgageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMortgageType.FormattingEnabled = true;
            this.cmbMortgageType.Items.AddRange(new object[] {
            "Военная ипотека",
            "IT-ипотека",
            "Семейная ипотека"});
            this.cmbMortgageType.Location = new System.Drawing.Point(200, 156);
            this.cmbMortgageType.Name = "cmbMortgageType";
            this.cmbMortgageType.Size = new System.Drawing.Size(150, 24);
            this.cmbMortgageType.TabIndex = 10;
            // 
            // tabPageLoan
            // 
            this.tabPageLoan.Controls.Add(this.pictureBoxinfoLoan);
            this.tabPageLoan.Controls.Add(this.pictureBox6);
            this.tabPageLoan.Controls.Add(this.pictureBox5);
            this.tabPageLoan.Controls.Add(this.pictureBox4);
            this.tabPageLoan.Controls.Add(this.lblLoanAmountLoan);
            this.tabPageLoan.Controls.Add(this.lblLoanType);
            this.tabPageLoan.Controls.Add(this.txtLoanAmountLoan);
            this.tabPageLoan.Controls.Add(this.cmbLoanType);
            this.tabPageLoan.Controls.Add(this.lblLoanMonthlyPayment);
            this.tabPageLoan.Controls.Add(this.lblAnnualRateLoan);
            this.tabPageLoan.Controls.Add(this.txtAnnualRateLoan);
            this.tabPageLoan.Controls.Add(this.lblTermMonthsLoan);
            this.tabPageLoan.Controls.Add(this.txtTermMonthsLoan);
            this.tabPageLoan.Controls.Add(this.btnCalculateLoan);
            this.tabPageLoan.Controls.Add(this.btnShowHistoryCredit);
            this.tabPageLoan.Controls.Add(this.lblLoanTotalInterest);
            this.tabPageLoan.Controls.Add(this.lblLoanTotalPayment);
            this.tabPageLoan.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoan.Name = "tabPageLoan";
            this.tabPageLoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoan.Size = new System.Drawing.Size(397, 417);
            this.tabPageLoan.TabIndex = 1;
            this.tabPageLoan.Text = "Кредит";
            this.tabPageLoan.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox6.Location = new System.Drawing.Point(319, 255);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox5.Location = new System.Drawing.Point(319, 219);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::КУРСОВАЯ.Properties.Resources.icons8_copy_90;
            this.pictureBox4.Location = new System.Drawing.Point(319, 183);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblLoanAmountLoan
            // 
            this.lblLoanAmountLoan.AutoSize = true;
            this.lblLoanAmountLoan.Location = new System.Drawing.Point(20, 20);
            this.lblLoanAmountLoan.Name = "lblLoanAmountLoan";
            this.lblLoanAmountLoan.Size = new System.Drawing.Size(110, 16);
            this.lblLoanAmountLoan.TabIndex = 0;
            this.lblLoanAmountLoan.Text = "Сумма кредита";
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Location = new System.Drawing.Point(20, 156);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(92, 16);
            this.lblLoanType.TabIndex = 0;
            this.lblLoanType.Text = "Тип кредита";
            // 
            // txtLoanAmountLoan
            // 
            this.txtLoanAmountLoan.Location = new System.Drawing.Point(200, 20);
            this.txtLoanAmountLoan.Name = "txtLoanAmountLoan";
            this.txtLoanAmountLoan.Size = new System.Drawing.Size(150, 23);
            this.txtLoanAmountLoan.TabIndex = 1;
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Location = new System.Drawing.Point(200, 153);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(150, 24);
            this.cmbLoanType.TabIndex = 1;
            // 
            // lblLoanMonthlyPayment
            // 
            this.lblLoanMonthlyPayment.AutoSize = true;
            this.lblLoanMonthlyPayment.Location = new System.Drawing.Point(20, 196);
            this.lblLoanMonthlyPayment.Name = "lblLoanMonthlyPayment";
            this.lblLoanMonthlyPayment.Size = new System.Drawing.Size(166, 16);
            this.lblLoanMonthlyPayment.TabIndex = 0;
            this.lblLoanMonthlyPayment.Text = "Ежемесячный платеж: ";
            // 
            // lblAnnualRateLoan
            // 
            this.lblAnnualRateLoan.AutoSize = true;
            this.lblAnnualRateLoan.Location = new System.Drawing.Point(20, 60);
            this.lblAnnualRateLoan.Name = "lblAnnualRateLoan";
            this.lblAnnualRateLoan.Size = new System.Drawing.Size(140, 16);
            this.lblAnnualRateLoan.TabIndex = 2;
            this.lblAnnualRateLoan.Text = "Процентная ставка";
            // 
            // txtAnnualRateLoan
            // 
            this.txtAnnualRateLoan.Location = new System.Drawing.Point(200, 60);
            this.txtAnnualRateLoan.Name = "txtAnnualRateLoan";
            this.txtAnnualRateLoan.Size = new System.Drawing.Size(150, 23);
            this.txtAnnualRateLoan.TabIndex = 3;
            // 
            // lblTermMonthsLoan
            // 
            this.lblTermMonthsLoan.AutoSize = true;
            this.lblTermMonthsLoan.Location = new System.Drawing.Point(20, 100);
            this.lblTermMonthsLoan.Name = "lblTermMonthsLoan";
            this.lblTermMonthsLoan.Size = new System.Drawing.Size(127, 16);
            this.lblTermMonthsLoan.TabIndex = 4;
            this.lblTermMonthsLoan.Text = "Срок (в месяцах)";
            // 
            // txtTermMonthsLoan
            // 
            this.txtTermMonthsLoan.Location = new System.Drawing.Point(200, 100);
            this.txtTermMonthsLoan.Name = "txtTermMonthsLoan";
            this.txtTermMonthsLoan.Size = new System.Drawing.Size(150, 23);
            this.txtTermMonthsLoan.TabIndex = 5;
            // 
            // btnCalculateLoan
            // 
            this.btnCalculateLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCalculateLoan.FlatAppearance.BorderSize = 0;
            this.btnCalculateLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculateLoan.ForeColor = System.Drawing.Color.White;
            this.btnCalculateLoan.Location = new System.Drawing.Point(20, 297);
            this.btnCalculateLoan.Name = "btnCalculateLoan";
            this.btnCalculateLoan.Size = new System.Drawing.Size(330, 30);
            this.btnCalculateLoan.TabIndex = 6;
            this.btnCalculateLoan.Text = "Рассчитать";
            this.btnCalculateLoan.UseVisualStyleBackColor = false;
            this.btnCalculateLoan.Click += new System.EventHandler(this.btnCalculateLoan_Click);
            // 
            // btnShowHistoryCredit
            // 
            this.btnShowHistoryCredit.Location = new System.Drawing.Point(20, 353);
            this.btnShowHistoryCredit.Name = "btnShowHistoryCredit";
            this.btnShowHistoryCredit.Size = new System.Drawing.Size(330, 30);
            this.btnShowHistoryCredit.TabIndex = 7;
            this.btnShowHistoryCredit.Text = "Показать историю";
            this.btnShowHistoryCredit.UseVisualStyleBackColor = true;
            this.btnShowHistoryCredit.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // lblLoanTotalInterest
            // 
            this.lblLoanTotalInterest.AutoSize = true;
            this.lblLoanTotalInterest.Location = new System.Drawing.Point(20, 228);
            this.lblLoanTotalInterest.Name = "lblLoanTotalInterest";
            this.lblLoanTotalInterest.Size = new System.Drawing.Size(194, 16);
            this.lblLoanTotalInterest.TabIndex = 7;
            this.lblLoanTotalInterest.Text = "Переплаченные проценты: ";
            // 
            // lblLoanTotalPayment
            // 
            this.lblLoanTotalPayment.AutoSize = true;
            this.lblLoanTotalPayment.Location = new System.Drawing.Point(20, 263);
            this.lblLoanTotalPayment.Name = "lblLoanTotalPayment";
            this.lblLoanTotalPayment.Size = new System.Drawing.Size(174, 16);
            this.lblLoanTotalPayment.TabIndex = 8;
            this.lblLoanTotalPayment.Text = "Общая сумма платежа: ";
            // 
            // pictureBoxinfo
            // 
            this.pictureBoxinfo.Image = global::КУРСОВАЯ.Properties.Resources.icons8_help_96;
            this.pictureBoxinfo.Location = new System.Drawing.Point(356, 147);
            this.pictureBoxinfo.Name = "pictureBoxinfo";
            this.pictureBoxinfo.Size = new System.Drawing.Size(32, 33);
            this.pictureBoxinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxinfo.TabIndex = 14;
            this.pictureBoxinfo.TabStop = false;
            this.pictureBoxinfo.Click += new System.EventHandler(this.pictureBoxinfo_Click);
            // 
            // pictureBoxinfoLoan
            // 
            this.pictureBoxinfoLoan.Image = global::КУРСОВАЯ.Properties.Resources.icons8_help_96;
            this.pictureBoxinfoLoan.Location = new System.Drawing.Point(356, 144);
            this.pictureBoxinfoLoan.Name = "pictureBoxinfoLoan";
            this.pictureBoxinfoLoan.Size = new System.Drawing.Size(32, 33);
            this.pictureBoxinfoLoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxinfoLoan.TabIndex = 18;
            this.pictureBoxinfoLoan.TabStop = false;
            this.pictureBoxinfoLoan.Click += new System.EventHandler(this.pictureBoxinfoLoan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 479);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Кредитный калькулятор";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMortgage.ResumeLayout(false);
            this.tabPageMortgage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageLoan.ResumeLayout(false);
            this.tabPageLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfoLoan)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Label lblTotalInterestMortgage;
        private System.Windows.Forms.Label lblLoanMonthlyPayment;
        private System.Windows.Forms.ComboBox cmbLoanType; 
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMortgage;
        private System.Windows.Forms.TabPage tabPageLoan;
        private System.Windows.Forms.Label lblLoanAmountMortgage;
        private System.Windows.Forms.TextBox txtLoanAmountMortgage;
        private System.Windows.Forms.Label lblAnnualRateMortgage;
        private System.Windows.Forms.TextBox txtAnnualRateMortgage;
        private System.Windows.Forms.Label lblTermMonthsMortgage;
        private System.Windows.Forms.TextBox txtTermMonthsMortgage;
        private System.Windows.Forms.Button btnCalculateMortgage;
        private System.Windows.Forms.Label lblMonthlyPaymentMortgage;
        private System.Windows.Forms.Label lblTotalPaymentMortgage;
        private System.Windows.Forms.ComboBox cmbMortgageType;
        private System.Windows.Forms.Label lblMortgageType;
        private System.Windows.Forms.Label lblLoanAmountLoan;
        private System.Windows.Forms.TextBox txtLoanAmountLoan;
        private System.Windows.Forms.Label lblAnnualRateLoan;
        private System.Windows.Forms.TextBox txtAnnualRateLoan;
        private System.Windows.Forms.Label lblTermMonthsLoan;
        private System.Windows.Forms.TextBox txtTermMonthsLoan;
        private System.Windows.Forms.Button btnCalculateLoan;
        private System.Windows.Forms.Label lblLoanTotalInterest;
        private System.Windows.Forms.Label lblLoanTotalPayment;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Button btnShowHistoryCredit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private PictureBox pictureBoxinfo;
        private PictureBox pictureBoxinfoLoan;
    }
}
