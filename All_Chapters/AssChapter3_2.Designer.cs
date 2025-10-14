namespace All_Chapters
{
    partial class AssChapter3_2
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
            foodChargeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            totallabel = new Label();
            taxlabel = new Label();
            tiplabel = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // foodChargeTextBox
            // 
            foodChargeTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            foodChargeTextBox.ForeColor = Color.Navy;
            foodChargeTextBox.Location = new Point(313, 75);
            foodChargeTextBox.Name = "foodChargeTextBox";
            foodChargeTextBox.Size = new Size(325, 27);
            foodChargeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(115, 74);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 38;
            label1.Text = "Enter a food charge:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(247, 235);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 45;
            label2.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(260, 190);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 44;
            label5.Text = "Tax:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(262, 143);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 43;
            label3.Text = "Tip:";
            // 
            // totallabel
            // 
            totallabel.BorderStyle = BorderStyle.Fixed3D;
            totallabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totallabel.ForeColor = Color.Navy;
            totallabel.Location = new Point(313, 235);
            totallabel.Name = "totallabel";
            totallabel.Size = new Size(325, 25);
            totallabel.TabIndex = 48;
            // 
            // taxlabel
            // 
            taxlabel.BorderStyle = BorderStyle.Fixed3D;
            taxlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            taxlabel.ForeColor = Color.Navy;
            taxlabel.Location = new Point(313, 190);
            taxlabel.Name = "taxlabel";
            taxlabel.Size = new Size(325, 25);
            taxlabel.TabIndex = 47;
            // 
            // tiplabel
            // 
            tiplabel.BorderStyle = BorderStyle.Fixed3D;
            tiplabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tiplabel.ForeColor = Color.Navy;
            tiplabel.Location = new Point(313, 143);
            tiplabel.Name = "tiplabel";
            tiplabel.Size = new Size(325, 25);
            tiplabel.TabIndex = 46;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(421, 370);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.DeepSkyBlue;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            calculateButton.ForeColor = SystemColors.ControlLightLight;
            calculateButton.Location = new Point(262, 370);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(155, 68);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // AssChapter3_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateButton);
            Controls.Add(ExitButton);
            Controls.Add(totallabel);
            Controls.Add(taxlabel);
            Controls.Add(tiplabel);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(foodChargeTextBox);
            Controls.Add(label1);
            Name = "AssChapter3_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox foodChargeTextBox;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label totallabel;
        private Label taxlabel;
        private Label tiplabel;
        private Button ExitButton;
        private Button calculateButton;
    }
}