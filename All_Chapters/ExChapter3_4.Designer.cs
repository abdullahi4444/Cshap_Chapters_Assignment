namespace All_Chapters
{
    partial class ExChapter3_4
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
            gallonsTextBox = new TextBox();
            label3 = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            mpgLabel = new Label();
            Labelmpg = new Label();
            mileTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // gallonsTextBox
            // 
            gallonsTextBox.ForeColor = Color.Navy;
            gallonsTextBox.Location = new Point(417, 142);
            gallonsTextBox.Name = "gallonsTextBox";
            gallonsTextBox.Size = new Size(234, 27);
            gallonsTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(136, 141);
            label3.Name = "label3";
            label3.Size = new Size(272, 25);
            label3.TabIndex = 20;
            label3.Text = "Enter the gallons of gas used:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(396, 301);
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
            calculateButton.Location = new Point(267, 301);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate MPG";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // mpgLabel
            // 
            mpgLabel.BorderStyle = BorderStyle.Fixed3D;
            mpgLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            mpgLabel.ForeColor = Color.Navy;
            mpgLabel.Location = new Point(417, 199);
            mpgLabel.Name = "mpgLabel";
            mpgLabel.Size = new Size(234, 34);
            mpgLabel.TabIndex = 17;
            mpgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labelmpg
            // 
            Labelmpg.AutoSize = true;
            Labelmpg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Labelmpg.ForeColor = Color.BlueViolet;
            Labelmpg.Location = new Point(254, 204);
            Labelmpg.Name = "Labelmpg";
            Labelmpg.Size = new Size(154, 25);
            Labelmpg.TabIndex = 16;
            Labelmpg.Text = "Your car’s MPG:";
            // 
            // mileTextBox
            // 
            mileTextBox.ForeColor = Color.Navy;
            mileTextBox.Location = new Point(417, 96);
            mileTextBox.Name = "mileTextBox";
            mileTextBox.Size = new Size(234, 27);
            mileTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(99, 96);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 14;
            label1.Text = "Enter the number of miles driven:";
            // 
            // ExChapter3_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gallonsTextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Controls.Add(mpgLabel);
            Controls.Add(Labelmpg);
            Controls.Add(mileTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_4";
            Load += ExChapter3_4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gallonsTextBox;
        private Label label3;
        private Button ExitButton;
        private Button calculateButton;
        private Label mpgLabel;
        private Label Labelmpg;
        private TextBox mileTextBox;
        private Label label1;
    }
}