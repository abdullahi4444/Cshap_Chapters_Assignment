namespace All_Chapters
{
    partial class ExChapter2_8
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
            ExitButton = new Button();
            calculateButton = new Button();
            payTextBox = new Label();
            Labelmpg = new Label();
            hoursTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // rateTextBox
            // 
            rateTextBox.ForeColor = Color.Navy;
            rateTextBox.Location = new Point(400, 140);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(234, 27);
            rateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(243, 142);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 36;
            label3.Text = "Horly Pay Rate:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(400, 315);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(123, 57);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.HotTrack;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            calculateButton.ForeColor = SystemColors.ControlLightLight;
            calculateButton.Location = new Point(271, 315);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Cross Pay";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // payTextBox
            // 
            payTextBox.BorderStyle = BorderStyle.Fixed3D;
            payTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            payTextBox.ForeColor = Color.Navy;
            payTextBox.Location = new Point(400, 197);
            payTextBox.Name = "payTextBox";
            payTextBox.Size = new Size(234, 34);
            payTextBox.TabIndex = 35;
            payTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labelmpg
            // 
            Labelmpg.AutoSize = true;
            Labelmpg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Labelmpg.ForeColor = Color.BlueViolet;
            Labelmpg.Location = new Point(342, 202);
            Labelmpg.Name = "Labelmpg";
            Labelmpg.Size = new Size(49, 25);
            Labelmpg.TabIndex = 34;
            Labelmpg.Text = "Pay:";
            // 
            // hoursTextBox
            // 
            hoursTextBox.ForeColor = Color.Navy;
            hoursTextBox.Location = new Point(400, 94);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(234, 27);
            hoursTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(147, 94);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 33;
            label1.Text = "Number of hours worked:";
            // 
            // ExChapter2_8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rateTextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Controls.Add(payTextBox);
            Controls.Add(Labelmpg);
            Controls.Add(hoursTextBox);
            Controls.Add(label1);
            Name = "ExChapter2_8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rateTextBox;
        private Label label3;
        private Button ExitButton;
        private Button calculateButton;
        private Label payTextBox;
        private Label Labelmpg;
        private TextBox hoursTextBox;
        private Label label1;
    }
}