namespace All_Chapters
{
    partial class ExChapter3_1
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
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            OutputLabel = new Label();
            readInputButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(164, 123);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name: ";
            // 
            // NameTextBox
            // 
            NameTextBox.ForeColor = Color.Navy;
            NameTextBox.Location = new Point(360, 124);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(234, 27);
            NameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(164, 189);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "You Entered: ";
            // 
            // OutputLabel
            // 
            OutputLabel.BorderStyle = BorderStyle.Fixed3D;
            OutputLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            OutputLabel.ForeColor = Color.Navy;
            OutputLabel.Location = new Point(360, 184);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(234, 34);
            OutputLabel.TabIndex = 3;
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readInputButton
            // 
            readInputButton.BackColor = SystemColors.HotTrack;
            readInputButton.Cursor = Cursors.Hand;
            readInputButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            readInputButton.ForeColor = SystemColors.ControlLightLight;
            readInputButton.Location = new Point(229, 277);
            readInputButton.Name = "readInputButton";
            readInputButton.Size = new Size(146, 57);
            readInputButton.TabIndex = 1;
            readInputButton.Text = "Read Input";
            readInputButton.UseVisualStyleBackColor = false;
            readInputButton.Click += readInputButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(397, 277);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(readInputButton);
            Controls.Add(OutputLabel);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_1";
            Load += ExChapter3_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private Label OutputLabel;
        private Button readInputButton;
        private Button ExitButton;
    }
}