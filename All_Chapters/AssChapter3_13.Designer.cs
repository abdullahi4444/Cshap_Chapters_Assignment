namespace All_Chapters
{
    partial class AssChapter3_13
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
            taxLabel = new Label();
            button1 = new Button();
            valueTextBox = new TextBox();
            label5 = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // taxLabel
            // 
            taxLabel.BorderStyle = BorderStyle.Fixed3D;
            taxLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            taxLabel.ForeColor = Color.Navy;
            taxLabel.Location = new Point(149, 182);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(495, 34);
            taxLabel.TabIndex = 64;
            taxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(349, 254);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 2;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // valueTextBox
            // 
            valueTextBox.ForeColor = Color.Navy;
            valueTextBox.Location = new Point(410, 131);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(234, 27);
            valueTextBox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(149, 133);
            label5.Name = "label5";
            label5.Size = new Size(233, 25);
            label5.TabIndex = 63;
            label5.Text = "Enter Property Value ($):";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(485, 254);
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
            calculateButton.Location = new Point(215, 254);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate Estimate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // AssChapter3_13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taxLabel);
            Controls.Add(button1);
            Controls.Add(valueTextBox);
            Controls.Add(label5);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Name = "AssChapter3_13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taxLabel;
        private Button button1;
        private TextBox valueTextBox;
        private Label label5;
        private Button ExitButton;
        private Button calculateButton;
    }
}