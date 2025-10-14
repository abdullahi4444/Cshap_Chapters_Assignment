namespace All_Chapters
{
    partial class AssChapter3_9
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
            CookiestextBox = new TextBox();
            label6 = new Label();
            label4 = new Label();
            Resultlabel = new Label();
            button1 = new Button();
            ExitButton = new Button();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // CookiestextBox
            // 
            CookiestextBox.ForeColor = Color.Navy;
            CookiestextBox.Location = new Point(419, 157);
            CookiestextBox.Name = "CookiestextBox";
            CookiestextBox.Size = new Size(216, 27);
            CookiestextBox.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(334, 205);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 84;
            label6.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(128, 159);
            label4.Name = "label4";
            label4.Size = new Size(285, 25);
            label4.TabIndex = 86;
            label4.Text = "Enter number of cookies eaten";
            // 
            // Resultlabel
            // 
            Resultlabel.BorderStyle = BorderStyle.Fixed3D;
            Resultlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Resultlabel.ForeColor = Color.Navy;
            Resultlabel.Location = new Point(419, 200);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(216, 34);
            Resultlabel.TabIndex = 85;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(327, 296);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 2;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(463, 296);
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
            calculateButton.Location = new Point(193, 296);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "show colories";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // AssChapter3_9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CookiestextBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(Resultlabel);
            Controls.Add(button1);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Name = "AssChapter3_9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CookiestextBox;
        private Label label6;
        private Label label4;
        private Label Resultlabel;
        private Button button1;
        private Button ExitButton;
        private Button calculateButton;
    }
}