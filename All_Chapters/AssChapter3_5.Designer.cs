namespace All_Chapters
{
    partial class AssChapter3_5
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
            ExitBtn = new Button();
            label2 = new Label();
            btnTocelcius = new Button();
            btnTofahrenheit = new Button();
            Resultlabel = new Label();
            TempTextBox = new TextBox();
            labelTemp = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Location = new Point(473, 268);
            ExitBtn.Margin = new Padding(2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(108, 76);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "E&xit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(310, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 40;
            label2.Text = "Result";
            // 
            // btnTocelcius
            // 
            btnTocelcius.BackColor = Color.DodgerBlue;
            btnTocelcius.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnTocelcius.ForeColor = Color.White;
            btnTocelcius.Location = new Point(338, 268);
            btnTocelcius.Margin = new Padding(2);
            btnTocelcius.Name = "btnTocelcius";
            btnTocelcius.Size = new Size(131, 76);
            btnTocelcius.TabIndex = 2;
            btnTocelcius.Text = "Convert to Celcius";
            btnTocelcius.UseVisualStyleBackColor = false;
            btnTocelcius.Click += btnTocelcius_Click;
            // 
            // btnTofahrenheit
            // 
            btnTofahrenheit.BackColor = Color.DodgerBlue;
            btnTofahrenheit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnTofahrenheit.ForeColor = Color.White;
            btnTofahrenheit.Location = new Point(198, 268);
            btnTofahrenheit.Margin = new Padding(2);
            btnTofahrenheit.Name = "btnTofahrenheit";
            btnTofahrenheit.Size = new Size(136, 76);
            btnTofahrenheit.TabIndex = 1;
            btnTofahrenheit.Text = "Convert to Fahrenheit";
            btnTofahrenheit.UseVisualStyleBackColor = false;
            btnTofahrenheit.Click += btnTofahrenheit_Click;
            // 
            // Resultlabel
            // 
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Resultlabel.ForeColor = Color.Navy;
            Resultlabel.Location = new Point(379, 188);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(155, 40);
            Resultlabel.TabIndex = 37;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TempTextBox
            // 
            TempTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            TempTextBox.ForeColor = Color.Navy;
            TempTextBox.Location = new Point(379, 127);
            TempTextBox.Margin = new Padding(2);
            TempTextBox.Name = "TempTextBox";
            TempTextBox.Size = new Size(155, 31);
            TempTextBox.TabIndex = 0;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            labelTemp.ForeColor = Color.Navy;
            labelTemp.Location = new Point(205, 130);
            labelTemp.Margin = new Padding(2, 0, 2, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(170, 25);
            labelTemp.TabIndex = 35;
            labelTemp.Text = "Enter Temperature";
            // 
            // AssChapter3_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(label2);
            Controls.Add(btnTocelcius);
            Controls.Add(btnTofahrenheit);
            Controls.Add(Resultlabel);
            Controls.Add(TempTextBox);
            Controls.Add(labelTemp);
            Name = "AssChapter3_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Label label2;
        private Button btnTocelcius;
        private Button btnTofahrenheit;
        private Label Resultlabel;
        private TextBox TempTextBox;
        private Label labelTemp;
    }
}