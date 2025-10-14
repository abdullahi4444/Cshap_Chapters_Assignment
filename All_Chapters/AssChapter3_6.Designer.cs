namespace All_Chapters
{
    partial class AssChapter3_6
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
            ExitBtn = new Button();
            HeighttextBox = new TextBox();
            Heightlabel = new Label();
            calculateBMIbutton = new Button();
            Resultlabel = new Label();
            Resultlable = new Label();
            WeighttextBox = new TextBox();
            Weightlabel = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(375, 300);
            ExitBtn.Margin = new Padding(2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(122, 83);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "E&xit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // HeighttextBox
            // 
            HeighttextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            HeighttextBox.ForeColor = Color.Navy;
            HeighttextBox.Location = new Point(390, 165);
            HeighttextBox.Margin = new Padding(2);
            HeighttextBox.Name = "HeighttextBox";
            HeighttextBox.Size = new Size(172, 31);
            HeighttextBox.TabIndex = 1;
            // 
            // Heightlabel
            // 
            Heightlabel.AutoSize = true;
            Heightlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Heightlabel.ForeColor = Color.Navy;
            Heightlabel.Location = new Point(192, 168);
            Heightlabel.Margin = new Padding(2, 0, 2, 0);
            Heightlabel.Name = "Heightlabel";
            Heightlabel.Size = new Size(194, 25);
            Heightlabel.TabIndex = 40;
            Heightlabel.Text = "Enter Height (Inches)";
            // 
            // calculateBMIbutton
            // 
            calculateBMIbutton.BackColor = SystemColors.Highlight;
            calculateBMIbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            calculateBMIbutton.ForeColor = SystemColors.ButtonHighlight;
            calculateBMIbutton.Location = new Point(256, 300);
            calculateBMIbutton.Margin = new Padding(2);
            calculateBMIbutton.Name = "calculateBMIbutton";
            calculateBMIbutton.Size = new Size(115, 83);
            calculateBMIbutton.TabIndex = 2;
            calculateBMIbutton.Text = "Calculate BMI";
            calculateBMIbutton.UseVisualStyleBackColor = false;
            calculateBMIbutton.Click += calculateBMIbutton_Click;
            // 
            // Resultlabel
            // 
            Resultlabel.BorderStyle = BorderStyle.FixedSingle;
            Resultlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Resultlabel.ForeColor = Color.Navy;
            Resultlabel.Location = new Point(390, 216);
            Resultlabel.Margin = new Padding(2, 0, 2, 0);
            Resultlabel.Name = "Resultlabel";
            Resultlabel.Size = new Size(172, 36);
            Resultlabel.TabIndex = 38;
            Resultlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resultlable
            // 
            Resultlable.AutoSize = true;
            Resultlable.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Resultlable.ForeColor = Color.DeepSkyBlue;
            Resultlable.Location = new Point(308, 222);
            Resultlable.Margin = new Padding(2, 0, 2, 0);
            Resultlable.Name = "Resultlable";
            Resultlable.Size = new Size(65, 25);
            Resultlable.TabIndex = 37;
            Resultlable.Text = "Result";
            // 
            // WeighttextBox
            // 
            WeighttextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            WeighttextBox.ForeColor = Color.Navy;
            WeighttextBox.Location = new Point(390, 122);
            WeighttextBox.Margin = new Padding(2);
            WeighttextBox.Name = "WeighttextBox";
            WeighttextBox.Size = new Size(172, 31);
            WeighttextBox.TabIndex = 0;
            // 
            // Weightlabel
            // 
            Weightlabel.AutoSize = true;
            Weightlabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Weightlabel.ForeColor = Color.Navy;
            Weightlabel.Location = new Point(181, 122);
            Weightlabel.Margin = new Padding(2, 0, 2, 0);
            Weightlabel.Name = "Weightlabel";
            Weightlabel.Size = new Size(205, 25);
            Weightlabel.TabIndex = 35;
            Weightlabel.Text = "Enter Weight (Pounds)";
            // 
            // AssChapter3_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(HeighttextBox);
            Controls.Add(Heightlabel);
            Controls.Add(calculateBMIbutton);
            Controls.Add(Resultlabel);
            Controls.Add(Resultlable);
            Controls.Add(WeighttextBox);
            Controls.Add(Weightlabel);
            Name = "AssChapter3_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private TextBox HeighttextBox;
        private Label Heightlabel;
        private Button calculateBMIbutton;
        private Label Resultlabel;
        private Label Resultlable;
        private TextBox WeighttextBox;
        private Label Weightlabel;
    }
}