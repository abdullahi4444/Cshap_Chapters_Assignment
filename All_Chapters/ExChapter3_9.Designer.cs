namespace All_Chapters
{
    partial class ExChapter3_9
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
            addressTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            stateTextBox = new TextBox();
            label2 = new Label();
            cityTextBox = new TextBox();
            label4 = new Label();
            zipTextBox = new TextBox();
            label5 = new Label();
            ClearButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // addressTextBox
            // 
            addressTextBox.ForeColor = Color.Navy;
            addressTextBox.Location = new Point(331, 127);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(234, 27);
            addressTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(209, 127);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 32;
            label3.Text = "Address:";
            // 
            // nameTextBox
            // 
            nameTextBox.ForeColor = Color.Navy;
            nameTextBox.Location = new Point(331, 81);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(234, 27);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(228, 80);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 30;
            label1.Text = "Name:";
            // 
            // stateTextBox
            // 
            stateTextBox.ForeColor = Color.Navy;
            stateTextBox.Location = new Point(331, 220);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(234, 27);
            stateTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(228, 219);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 36;
            label2.Text = "State:";
            // 
            // cityTextBox
            // 
            cityTextBox.ForeColor = Color.Navy;
            cityTextBox.Location = new Point(331, 174);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(234, 27);
            cityTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(241, 176);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 34;
            label4.Text = "City: ";
            // 
            // zipTextBox
            // 
            zipTextBox.ForeColor = Color.Navy;
            zipTextBox.Location = new Point(331, 264);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(234, 27);
            zipTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(241, 266);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 38;
            label5.Text = "ZIP:";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DodgerBlue;
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearButton.ForeColor = SystemColors.ControlLightLight;
            ClearButton.Location = new Point(246, 347);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(146, 57);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(398, 347);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter3_9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(zipTextBox);
            Controls.Add(label5);
            Controls.Add(stateTextBox);
            Controls.Add(label2);
            Controls.Add(cityTextBox);
            Controls.Add(label4);
            Controls.Add(addressTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addressTextBox;
        private Label label3;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox stateTextBox;
        private Label label2;
        private TextBox cityTextBox;
        private Label label4;
        private TextBox zipTextBox;
        private Label label5;
        private Button ClearButton;
        private Button ExitButton;
    }
}