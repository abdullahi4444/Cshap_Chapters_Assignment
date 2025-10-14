namespace All_Chapters
{
    partial class AssChapter3_12
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
            laborLabel = new Label();
            priceTextBox = new TextBox();
            label5 = new Label();
            squareFeetTextBox = new TextBox();
            label6 = new Label();
            ExitButton = new Button();
            calculateButton = new Button();
            paintCostLabel = new Label();
            hoursLabel = new Label();
            gallonsLabel = new Label();
            totalLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(350, 179);
            button1.Name = "button1";
            button1.Size = new Size(120, 57);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // laborLabel
            // 
            laborLabel.BorderStyle = BorderStyle.Fixed3D;
            laborLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            laborLabel.ForeColor = Color.Navy;
            laborLabel.Location = new Point(216, 408);
            laborLabel.Name = "laborLabel";
            laborLabel.Size = new Size(393, 34);
            laborLabel.TabIndex = 57;
            laborLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            priceTextBox.ForeColor = Color.Navy;
            priceTextBox.Location = new Point(408, 112);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(234, 27);
            priceTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(147, 114);
            label5.Name = "label5";
            label5.Size = new Size(234, 25);
            label5.TabIndex = 56;
            label5.Text = "Price of Paint per Gallon:";
            // 
            // squareFeetTextBox
            // 
            squareFeetTextBox.ForeColor = Color.Navy;
            squareFeetTextBox.Location = new Point(408, 79);
            squareFeetTextBox.Name = "squareFeetTextBox";
            squareFeetTextBox.Size = new Size(234, 27);
            squareFeetTextBox.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(135, 79);
            label6.Name = "label6";
            label6.Size = new Size(246, 25);
            label6.TabIndex = 55;
            label6.Text = "Square Feet of Wall Space:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(486, 179);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(123, 57);
            ExitButton.TabIndex = 4;
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
            calculateButton.Location = new Point(216, 179);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 57);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Estimate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // paintCostLabel
            // 
            paintCostLabel.BorderStyle = BorderStyle.Fixed3D;
            paintCostLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            paintCostLabel.ForeColor = Color.Navy;
            paintCostLabel.Location = new Point(216, 363);
            paintCostLabel.Name = "paintCostLabel";
            paintCostLabel.Size = new Size(393, 34);
            paintCostLabel.TabIndex = 54;
            paintCostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hoursLabel
            // 
            hoursLabel.BorderStyle = BorderStyle.Fixed3D;
            hoursLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            hoursLabel.ForeColor = Color.Navy;
            hoursLabel.Location = new Point(216, 310);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(393, 34);
            hoursLabel.TabIndex = 59;
            hoursLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gallonsLabel
            // 
            gallonsLabel.BorderStyle = BorderStyle.Fixed3D;
            gallonsLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gallonsLabel.ForeColor = Color.Navy;
            gallonsLabel.Location = new Point(216, 265);
            gallonsLabel.Name = "gallonsLabel";
            gallonsLabel.Size = new Size(393, 34);
            gallonsLabel.TabIndex = 58;
            gallonsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.Fixed3D;
            totalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalLabel.ForeColor = Color.Navy;
            totalLabel.Location = new Point(216, 455);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(393, 34);
            totalLabel.TabIndex = 60;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AssChapter3_12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 517);
            Controls.Add(totalLabel);
            Controls.Add(hoursLabel);
            Controls.Add(gallonsLabel);
            Controls.Add(button1);
            Controls.Add(laborLabel);
            Controls.Add(priceTextBox);
            Controls.Add(label5);
            Controls.Add(squareFeetTextBox);
            Controls.Add(label6);
            Controls.Add(ExitButton);
            Controls.Add(calculateButton);
            Controls.Add(paintCostLabel);
            Name = "AssChapter3_12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_12";
            Load += AssChapter3_12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label laborLabel;
        private TextBox priceTextBox;
        private Label label5;
        private TextBox squareFeetTextBox;
        private Label label6;
        private Button ExitButton;
        private Button calculateButton;
        private Label paintCostLabel;
        private Label hoursLabel;
        private Label gallonsLabel;
        private Label totalLabel;
    }
}