namespace All_Chapters
{
    partial class ExChapter2_1
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
            button1 = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 184);
            button1.Name = "button1";
            button1.Size = new Size(114, 50);
            button1.TabIndex = 0;
            button1.Text = "Click me!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(299, 370);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(button1);
            Name = "ExChapter2_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button ExitButton;
    }
}