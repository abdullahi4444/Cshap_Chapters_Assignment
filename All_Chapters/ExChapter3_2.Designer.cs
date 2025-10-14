namespace All_Chapters
{
    partial class ExChapter3_2
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
            ExitButton = new Button();
            readInputButton = new Button();
            FullNameLabel = new Label();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            label1 = new Label();
            LastNameTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(400, 296);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // readInputButton
            // 
            readInputButton.BackColor = SystemColors.HotTrack;
            readInputButton.Cursor = Cursors.Hand;
            readInputButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            readInputButton.ForeColor = SystemColors.ControlLightLight;
            readInputButton.Location = new Point(232, 296);
            readInputButton.Name = "readInputButton";
            readInputButton.Size = new Size(146, 57);
            readInputButton.TabIndex = 2;
            readInputButton.Text = "Read Input";
            readInputButton.UseVisualStyleBackColor = false;
            readInputButton.Click += readInputButton_Click;
            // 
            // FullNameLabel
            // 
            FullNameLabel.BorderStyle = BorderStyle.Fixed3D;
            FullNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            FullNameLabel.ForeColor = Color.Navy;
            FullNameLabel.Location = new Point(376, 194);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(234, 34);
            FullNameLabel.TabIndex = 9;
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(154, 203);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 8;
            label2.Text = "Your Full Name: ";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.ForeColor = Color.Navy;
            FirstNameTextBox.Location = new Point(376, 91);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(234, 27);
            FirstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(154, 91);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 6;
            label1.Text = "Enter Your First Name: ";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.ForeColor = Color.Navy;
            LastNameTextBox.Location = new Point(376, 137);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(234, 27);
            LastNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(154, 136);
            label3.Name = "label3";
            label3.Size = new Size(213, 25);
            label3.TabIndex = 12;
            label3.Text = "Enter Your Last Name: ";
            // 
            // ExChapter3_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LastNameTextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(readInputButton);
            Controls.Add(FullNameLabel);
            Controls.Add(label2);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button readInputButton;
        private Label FullNameLabel;
        private Label label2;
        private TextBox FirstNameTextBox;
        private Label label1;
        private TextBox LastNameTextBox;
        private Label label3;
    }
}