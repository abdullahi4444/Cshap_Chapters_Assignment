namespace All_Chapters
{
    partial class ExChapter3_10
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
            rateTextBox = new TextBox();
            label3 = new Label();
            hoursTextBox = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ExitButton = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rateTextBox
            // 
            rateTextBox.ForeColor = Color.Navy;
            rateTextBox.Location = new Point(181, 81);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(234, 27);
            rateTextBox.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(50, 80);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 40;
            label3.Text = "Last Name:";
            // 
            // hoursTextBox
            // 
            hoursTextBox.ForeColor = Color.Navy;
            hoursTextBox.Location = new Point(181, 35);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(234, 27);
            hoursTextBox.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 39;
            label1.Text = "First Name:";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(181, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(50, 124);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 42;
            label2.Text = "Telephone:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(340, 395);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(123, 57);
            ExitButton.TabIndex = 43;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rateTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(hoursTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(150, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 217);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // ExChapter3_10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 485);
            Controls.Add(groupBox1);
            Controls.Add(ExitButton);
            Name = "ExChapter3_10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox rateTextBox;
        private Label label3;
        private TextBox hoursTextBox;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button ExitButton;
        private GroupBox groupBox1;
    }
}