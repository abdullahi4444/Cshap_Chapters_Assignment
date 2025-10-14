namespace All_Chapters
{
    partial class ExChapter2_2
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
            FirstButton = new Button();
            SecondButton = new Button();
            ThirdButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // FirstButton
            // 
            FirstButton.Location = new Point(200, 196);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(110, 47);
            FirstButton.TabIndex = 0;
            FirstButton.Text = "First Button";
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.Click += FirstButton_Click;
            // 
            // SecondButton
            // 
            SecondButton.Location = new Point(316, 196);
            SecondButton.Name = "SecondButton";
            SecondButton.Size = new Size(134, 47);
            SecondButton.TabIndex = 1;
            SecondButton.Text = "Second Button";
            SecondButton.UseVisualStyleBackColor = true;
            SecondButton.Click += SecondButton_Click;
            // 
            // ThirdButton
            // 
            ThirdButton.Location = new Point(456, 196);
            ThirdButton.Name = "ThirdButton";
            ThirdButton.Size = new Size(110, 47);
            ThirdButton.TabIndex = 2;
            ThirdButton.Text = "Third Button";
            ThirdButton.UseVisualStyleBackColor = true;
            ThirdButton.Click += ThirdButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(306, 370);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ThirdButton);
            Controls.Add(SecondButton);
            Controls.Add(FirstButton);
            Name = "ExChapter2_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_2";
            ResumeLayout(false);
        }

        #endregion

        private Button FirstButton;
        private Button SecondButton;
        private Button ThirdButton;
        private Button ExitButton;
    }
}