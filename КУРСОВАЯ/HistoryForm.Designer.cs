namespace КУРСОВАЯ
{
    partial class HistoryForm
    {
        private System.Windows.Forms.DataGridView dgvHistory;  // DataGridView для отображения истории
        private System.Windows.Forms.PictureBox pictureBoxBack; 

        private void InitializeComponent()
        {
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(660, 382);
            this.dgvHistory.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::КУРСОВАЯ.Properties.Resources.home_button;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 400);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 1;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseEnter += new System.EventHandler(this.pictureBoxBack_MouseEnter);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(552, 400);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 50);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "очистить историю";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // HistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(675, 462);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.dgvHistory);
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "История вычислений";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button clearButton;
    }
}
