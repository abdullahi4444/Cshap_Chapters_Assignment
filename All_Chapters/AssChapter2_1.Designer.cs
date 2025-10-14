namespace All_Chapters
{
    partial class AssChapter2_1
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
            CloseButton = new Button();
            label2 = new Label();
            label1 = new Label();
            displayLabel = new Label();
            mediumButton = new Button();
            dexterButton = new Button();
            SinisterButton = new Button();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Crimson;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(178, 387);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(432, 65);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "E&xit";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(683, 9);
            label2.Name = "label2";
            label2.Size = new Size(112, 39);
            label2.TabIndex = 16;
            label2.Text = "ID: 767";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(420, 39);
            label1.TabIndex = 15;
            label1.Text = "Name: Abdullahi Abdiweli Adam";
            // 
            // displayLabel
            // 
            displayLabel.BorderStyle = BorderStyle.Fixed3D;
            displayLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayLabel.ForeColor = Color.Navy;
            displayLabel.Location = new Point(178, 238);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(432, 63);
            displayLabel.TabIndex = 14;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mediumButton
            // 
            mediumButton.BackColor = Color.DodgerBlue;
            mediumButton.Cursor = Cursors.Hand;
            mediumButton.FlatAppearance.BorderSize = 0;
            mediumButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            mediumButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            mediumButton.FlatStyle = FlatStyle.Flat;
            mediumButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            mediumButton.ForeColor = Color.White;
            mediumButton.Location = new Point(470, 152);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(140, 59);
            mediumButton.TabIndex = 2;
            mediumButton.Text = "Medium ";
            mediumButton.UseVisualStyleBackColor = false;
            mediumButton.Click += mediumButton_Click;
            // 
            // dexterButton
            // 
            dexterButton.BackColor = Color.DodgerBlue;
            dexterButton.Cursor = Cursors.Hand;
            dexterButton.FlatAppearance.BorderSize = 0;
            dexterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            dexterButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            dexterButton.FlatStyle = FlatStyle.Flat;
            dexterButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dexterButton.ForeColor = Color.White;
            dexterButton.Location = new Point(324, 152);
            dexterButton.Name = "dexterButton";
            dexterButton.Size = new Size(140, 59);
            dexterButton.TabIndex = 1;
            dexterButton.Text = "Dexter";
            dexterButton.UseVisualStyleBackColor = false;
            dexterButton.Click += dexterButton_Click;
            // 
            // SinisterButton
            // 
            SinisterButton.BackColor = Color.DodgerBlue;
            SinisterButton.Cursor = Cursors.Hand;
            SinisterButton.FlatAppearance.BorderSize = 0;
            SinisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            SinisterButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            SinisterButton.FlatStyle = FlatStyle.Flat;
            SinisterButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            SinisterButton.ForeColor = Color.White;
            SinisterButton.Location = new Point(178, 152);
            SinisterButton.Name = "SinisterButton";
            SinisterButton.Size = new Size(140, 59);
            SinisterButton.TabIndex = 0;
            SinisterButton.Text = "Sinister";
            SinisterButton.UseVisualStyleBackColor = false;
            SinisterButton.Click += SinisterButton_Click;
            // 
            // AssChapter2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 484);
            Controls.Add(CloseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(displayLabel);
            Controls.Add(mediumButton);
            Controls.Add(dexterButton);
            Controls.Add(SinisterButton);
            Name = "AssChapter2_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter2_1";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Label label2;
        private Label label1;
        private Label displayLabel;
        private Button mediumButton;
        private Button dexterButton;
        private Button SinisterButton;
    }
}