namespace All_Chapters
{
    partial class ExChapter3_6
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
            ClearButton = new Button();
            label4 = new Label();
            test3TextBox = new TextBox();
            label5 = new Label();
            test2TextBox = new TextBox();
            label3 = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            averageLabel = new Label();
            test1TextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.ForestGreen;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearButton.ForeColor = SystemColors.ControlLightLight;
            ClearButton.Location = new Point(320, 328);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(146, 57);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(167, 266);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 36;
            label4.Text = "Average Test Score:";
            // 
            // test3TextBox
            // 
            test3TextBox.ForeColor = Color.Navy;
            test3TextBox.Location = new Point(247, 194);
            test3TextBox.Name = "test3TextBox";
            test3TextBox.Size = new Size(369, 27);
            test3TextBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(174, 196);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 34;
            label5.Text = "Test 3:";
            // 
            // test2TextBox
            // 
            test2TextBox.ForeColor = Color.Navy;
            test2TextBox.Location = new Point(247, 145);
            test2TextBox.Name = "test2TextBox";
            test2TextBox.Size = new Size(369, 27);
            test2TextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(174, 147);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 32;
            label3.Text = "Test 2:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(472, 328);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 5;
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
            calculateButton.Location = new Point(168, 328);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(146, 57);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate Average";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            averageLabel.ForeColor = Color.Navy;
            averageLabel.Location = new Point(353, 263);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(263, 31);
            averageLabel.TabIndex = 29;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test1TextBox
            // 
            test1TextBox.ForeColor = Color.Navy;
            test1TextBox.Location = new Point(247, 99);
            test1TextBox.Name = "test1TextBox";
            test1TextBox.Size = new Size(369, 27);
            test1TextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(174, 98);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 27;
            label1.Text = "Test 1:";
            // 
            // ExChapter3_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(label4);
            Controls.Add(test3TextBox);
            Controls.Add(label5);
            Controls.Add(test2TextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Controls.Add(averageLabel);
            Controls.Add(test1TextBox);
            Controls.Add(label1);
            Name = "ExChapter3_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_6";
            Load += ExChapter3_6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label label4;
        private TextBox test3TextBox;
        private Label label5;
        private TextBox test2TextBox;
        private Label label3;
        private Button ExitButton;
        private Button calculateButton;
        private Label averageLabel;
        private TextBox test1TextBox;
        private Label label1;
    }
}