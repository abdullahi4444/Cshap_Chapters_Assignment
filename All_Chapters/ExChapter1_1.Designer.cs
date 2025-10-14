namespace All_Chapters
{
    partial class ExChapter1_1
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
            rateTextBox.Location = new Point(410, 145);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(234, 27);
            rateTextBox.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(253, 147);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 44;
            label3.Text = "Horly Pay Rate:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(410, 320);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(123, 57);
            ExitButton.TabIndex = 40;
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
            calculateButton.Location = new Point(281, 320);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 39;
            calculateButton.Text = "Calculate Cross Pay";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // payTextBox
            // 
            payTextBox.BorderStyle = BorderStyle.Fixed3D;
            payTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            payTextBox.ForeColor = Color.Navy;
            payTextBox.Location = new Point(410, 202);
            payTextBox.Name = "payTextBox";
            payTextBox.Size = new Size(234, 34);
            payTextBox.TabIndex = 43;
            payTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labelmpg
            // 
            Labelmpg.AutoSize = true;
            Labelmpg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Labelmpg.ForeColor = Color.BlueViolet;
            Labelmpg.Location = new Point(352, 207);
            Labelmpg.Name = "Labelmpg";
            Labelmpg.Size = new Size(49, 25);
            Labelmpg.TabIndex = 42;
            Labelmpg.Text = "Pay:";
            // 
            // hoursTextBox
            // 
            hoursTextBox.ForeColor = Color.Navy;
            hoursTextBox.Location = new Point(410, 99);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(234, 27);
            hoursTextBox.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(157, 99);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 41;
            label1.Text = "Number of hours worked:";
            // 
            // ExChapter1_1
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
            Name = "ExChapter1_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter1_1";
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