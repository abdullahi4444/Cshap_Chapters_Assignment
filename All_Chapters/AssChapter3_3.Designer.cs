namespace All_Chapters
{
    partial class AssChapter3_3
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
            resultlabel = new Label();
            label3 = new Label();
            speedTextBox = new TextBox();
            label1 = new Label();
            c5Button = new Button();
            ExitButton = new Button();
            c8button = new Button();
            c12button = new Button();
            SuspendLayout();
            // 
            // resultlabel
            // 
            resultlabel.BorderStyle = BorderStyle.Fixed3D;
            resultlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            resultlabel.ForeColor = Color.Navy;
            resultlabel.Location = new Point(309, 170);
            resultlabel.Name = "resultlabel";
            resultlabel.Size = new Size(325, 25);
            resultlabel.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(232, 170);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 49;
            label3.Text = "Result:";
            // 
            // speedTextBox
            // 
            speedTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            speedTextBox.ForeColor = Color.Navy;
            speedTextBox.Location = new Point(309, 115);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(325, 27);
            speedTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(100, 114);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 48;
            label1.Text = "Enter speed in (M/H):";
            // 
            // c5Button
            // 
            c5Button.BackColor = Color.DeepSkyBlue;
            c5Button.Cursor = Cursors.Hand;
            c5Button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            c5Button.ForeColor = SystemColors.ControlLightLight;
            c5Button.Location = new Point(72, 309);
            c5Button.Name = "c5Button";
            c5Button.Size = new Size(155, 68);
            c5Button.TabIndex = 1;
            c5Button.Text = "Calculate 5 Hours";
            c5Button.UseVisualStyleBackColor = false;
            c5Button.Click += c5Button_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(551, 309);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // c8button
            // 
            c8button.BackColor = Color.DeepSkyBlue;
            c8button.Cursor = Cursors.Hand;
            c8button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            c8button.ForeColor = SystemColors.ControlLightLight;
            c8button.Location = new Point(233, 309);
            c8button.Name = "c8button";
            c8button.Size = new Size(155, 68);
            c8button.TabIndex = 2;
            c8button.Text = "Calculate 8 Hours";
            c8button.UseVisualStyleBackColor = false;
            c8button.Click += c8button_Click;
            // 
            // c12button
            // 
            c12button.BackColor = Color.DeepSkyBlue;
            c12button.Cursor = Cursors.Hand;
            c12button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            c12button.ForeColor = SystemColors.ControlLightLight;
            c12button.Location = new Point(390, 309);
            c12button.Name = "c12button";
            c12button.Size = new Size(155, 68);
            c12button.TabIndex = 3;
            c12button.Text = "Calculate 12 Hours";
            c12button.UseVisualStyleBackColor = false;
            c12button.Click += c12button_Click;
            // 
            // AssChapter3_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(c12button);
            Controls.Add(c8button);
            Controls.Add(c5Button);
            Controls.Add(ExitButton);
            Controls.Add(resultlabel);
            Controls.Add(label3);
            Controls.Add(speedTextBox);
            Controls.Add(label1);
            Name = "AssChapter3_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultlabel;
        private Label label3;
        private TextBox speedTextBox;
        private Label label1;
        private Button c5Button;
        private Button ExitButton;
        private Button c8button;
        private Button c12button;
    }
}