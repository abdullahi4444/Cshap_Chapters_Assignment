namespace All_Chapters
{
    partial class ExChapter3_3
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
            monthTextBox = new TextBox();
            label3 = new Label();
            ExitButton = new Button();
            ShowDateButton = new Button();
            dateOutputLabel = new Label();
            dayOfWeekTextBox = new TextBox();
            label1 = new Label();
            YearTextBox = new TextBox();
            label4 = new Label();
            dayOfMonthTextBox = new TextBox();
            label5 = new Label();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // monthTextBox
            // 
            monthTextBox.ForeColor = Color.Navy;
            monthTextBox.Location = new Point(428, 102);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(263, 27);
            monthTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(142, 101);
            label3.Name = "label3";
            label3.Size = new Size(277, 25);
            label3.TabIndex = 20;
            label3.Text = "Enter the name of the month: ";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(475, 369);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShowDateButton
            // 
            ShowDateButton.BackColor = SystemColors.HotTrack;
            ShowDateButton.Cursor = Cursors.Hand;
            ShowDateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ShowDateButton.ForeColor = SystemColors.ControlLightLight;
            ShowDateButton.Location = new Point(171, 369);
            ShowDateButton.Name = "ShowDateButton";
            ShowDateButton.Size = new Size(146, 57);
            ShowDateButton.TabIndex = 4;
            ShowDateButton.Text = "Shaw Date";
            ShowDateButton.UseVisualStyleBackColor = false;
            ShowDateButton.Click += ShowDateButton_Click;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.Fixed3D;
            dateOutputLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dateOutputLabel.ForeColor = Color.Navy;
            dateOutputLabel.Location = new Point(99, 270);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(581, 53);
            dateOutputLabel.TabIndex = 17;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.ForeColor = Color.Navy;
            dayOfWeekTextBox.Location = new Point(428, 56);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(263, 27);
            dayOfWeekTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(171, 55);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 14;
            label1.Text = "Enter the day of the week: ";
            // 
            // YearTextBox
            // 
            YearTextBox.ForeColor = Color.Navy;
            YearTextBox.Location = new Point(428, 197);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(263, 27);
            YearTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(273, 196);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 24;
            label4.Text = "Enter the year: ";
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.ForeColor = Color.Navy;
            dayOfMonthTextBox.Location = new Point(428, 151);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(263, 27);
            dayOfMonthTextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(81, 151);
            label5.Name = "label5";
            label5.Size = new Size(338, 25);
            label5.TabIndex = 22;
            label5.Text = "Enter the numeric day of the month: ";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.ForestGreen;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearButton.ForeColor = SystemColors.ControlLightLight;
            ClearButton.Location = new Point(323, 369);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(146, 57);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExChapter3_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(YearTextBox);
            Controls.Add(label4);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(label5);
            Controls.Add(monthTextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(ShowDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox monthTextBox;
        private Label label3;
        private Button ExitButton;
        private Button ShowDateButton;
        private Label dateOutputLabel;
        private TextBox dayOfWeekTextBox;
        private Label label1;
        private TextBox YearTextBox;
        private Label label4;
        private TextBox dayOfMonthTextBox;
        private Label label5;
        private Button ClearButton;
    }
}