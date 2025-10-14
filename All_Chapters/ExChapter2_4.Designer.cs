namespace All_Chapters
{
    partial class ExChapter2_4
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
            clearButton = new Button();
            somaliButton = new Button();
            arabicButton = new Button();
            italianButton = new Button();
            translationLabel = new Label();
            instructionLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(192, 192, 0);
            clearButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(180, 359);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(294, 60);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // somaliButton
            // 
            somaliButton.BackColor = Color.FromArgb(192, 255, 255);
            somaliButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            somaliButton.Location = new Point(180, 267);
            somaliButton.Name = "somaliButton";
            somaliButton.Size = new Size(144, 62);
            somaliButton.TabIndex = 0;
            somaliButton.Text = "Somali";
            somaliButton.UseVisualStyleBackColor = false;
            somaliButton.Click += somaliButton_Click_1;
            // 
            // arabicButton
            // 
            arabicButton.BackColor = Color.FromArgb(192, 255, 192);
            arabicButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            arabicButton.Location = new Point(480, 267);
            arabicButton.Name = "arabicButton";
            arabicButton.Size = new Size(144, 62);
            arabicButton.TabIndex = 2;
            arabicButton.Text = "Arabic";
            arabicButton.UseVisualStyleBackColor = false;
            arabicButton.Click += arabicButton_Click_1;
            // 
            // italianButton
            // 
            italianButton.BackColor = Color.FromArgb(255, 192, 192);
            italianButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            italianButton.Location = new Point(330, 267);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(144, 62);
            italianButton.TabIndex = 1;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = false;
            italianButton.Click += italianButton_Click_1;
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.Fixed3D;
            translationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            translationLabel.Location = new Point(164, 162);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(473, 83);
            translationLabel.TabIndex = 7;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            instructionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionLabel.Location = new Point(164, 56);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(473, 83);
            instructionLabel.TabIndex = 6;
            instructionLabel.Text = "Select a language and i will say Good Morning welcome";
            instructionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(480, 359);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(144, 60);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(clearButton);
            Controls.Add(somaliButton);
            Controls.Add(arabicButton);
            Controls.Add(italianButton);
            Controls.Add(translationLabel);
            Controls.Add(instructionLabel);
            Name = "ExChapter2_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_4";
            ResumeLayout(false);
        }

        #endregion

        private Button clearButton;
        private Button somaliButton;
        private Button arabicButton;
        private Button italianButton;
        private Label translationLabel;
        private Label instructionLabel;
        private Button ExitButton;
    }
}