namespace All_Chapters
{
    partial class ExChapter3_5
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
            discountPercentageTextBox = new TextBox();
            label3 = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            salePriceLabel = new Label();
            Labelmpg = new Label();
            originalPriceTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // discountPercentageTextBox
            // 
            discountPercentageTextBox.ForeColor = Color.Navy;
            discountPercentageTextBox.Location = new Point(402, 156);
            discountPercentageTextBox.Name = "discountPercentageTextBox";
            discountPercentageTextBox.Size = new Size(234, 27);
            discountPercentageTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(109, 155);
            label3.Name = "label3";
            label3.Size = new Size(284, 25);
            label3.TabIndex = 28;
            label3.Text = "Enter the discount percentage:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(402, 315);
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
            calculateButton.Location = new Point(273, 315);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Sale Price";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // salePriceLabel
            // 
            salePriceLabel.BorderStyle = BorderStyle.Fixed3D;
            salePriceLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            salePriceLabel.ForeColor = Color.Navy;
            salePriceLabel.Location = new Point(402, 213);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new Size(234, 34);
            salePriceLabel.TabIndex = 25;
            salePriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labelmpg
            // 
            Labelmpg.AutoSize = true;
            Labelmpg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Labelmpg.ForeColor = Color.BlueViolet;
            Labelmpg.Location = new Point(291, 218);
            Labelmpg.Name = "Labelmpg";
            Labelmpg.Size = new Size(102, 25);
            Labelmpg.TabIndex = 24;
            Labelmpg.Text = "Sale Price:";
            // 
            // originalPriceTextBox
            // 
            originalPriceTextBox.ForeColor = Color.Navy;
            originalPriceTextBox.Location = new Point(402, 110);
            originalPriceTextBox.Name = "originalPriceTextBox";
            originalPriceTextBox.Size = new Size(234, 27);
            originalPriceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(115, 110);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 22;
            label1.Text = "Enter the item’s original price:";
            // 
            // ExChapter3_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(discountPercentageTextBox);
            Controls.Add(label3);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Controls.Add(salePriceLabel);
            Controls.Add(Labelmpg);
            Controls.Add(originalPriceTextBox);
            Controls.Add(label1);
            Name = "ExChapter3_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_5";
            Load += ExChapter3_5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox discountPercentageTextBox;
        private Label label3;
        private Button ExitButton;
        private Button calculateButton;
        private Label salePriceLabel;
        private Label Labelmpg;
        private TextBox originalPriceTextBox;
        private Label label1;
    }
}