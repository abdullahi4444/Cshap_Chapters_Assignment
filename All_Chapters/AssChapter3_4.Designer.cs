namespace All_Chapters
{
    partial class AssChapter3_4
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
            calculatebutton = new Button();
            Totalsaleslabel = new Label();
            Countrylabel = new Label();
            Satelabel = new Label();
            label2 = new Label();
            tax = new Label();
            tip = new Label();
            amountpurchasetextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(381, 319);
            ExitBtn.Margin = new Padding(2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(105, 54);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "E&xit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // calculatebutton
            // 
            calculatebutton.BackColor = SystemColors.MenuHighlight;
            calculatebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            calculatebutton.ForeColor = SystemColors.ButtonHighlight;
            calculatebutton.Location = new Point(268, 320);
            calculatebutton.Margin = new Padding(2);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(105, 53);
            calculatebutton.TabIndex = 1;
            calculatebutton.Text = "Calculate";
            calculatebutton.UseVisualStyleBackColor = false;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // Totalsaleslabel
            // 
            Totalsaleslabel.BorderStyle = BorderStyle.FixedSingle;
            Totalsaleslabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Totalsaleslabel.ForeColor = Color.Navy;
            Totalsaleslabel.Location = new Point(381, 229);
            Totalsaleslabel.Margin = new Padding(2, 0, 2, 0);
            Totalsaleslabel.Name = "Totalsaleslabel";
            Totalsaleslabel.Size = new Size(197, 20);
            Totalsaleslabel.TabIndex = 42;
            // 
            // Countrylabel
            // 
            Countrylabel.BorderStyle = BorderStyle.FixedSingle;
            Countrylabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Countrylabel.ForeColor = Color.Navy;
            Countrylabel.Location = new Point(381, 197);
            Countrylabel.Margin = new Padding(2, 0, 2, 0);
            Countrylabel.Name = "Countrylabel";
            Countrylabel.Size = new Size(197, 20);
            Countrylabel.TabIndex = 41;
            // 
            // Satelabel
            // 
            Satelabel.BorderStyle = BorderStyle.FixedSingle;
            Satelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Satelabel.ForeColor = Color.Navy;
            Satelabel.Location = new Point(381, 165);
            Satelabel.Margin = new Padding(2, 0, 2, 0);
            Satelabel.Name = "Satelabel";
            Satelabel.Size = new Size(197, 20);
            Satelabel.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(276, 230);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 39;
            label2.Text = "Total sales";
            // 
            // tax
            // 
            tax.AutoSize = true;
            tax.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tax.ForeColor = Color.Navy;
            tax.Location = new Point(217, 197);
            tax.Margin = new Padding(2, 0, 2, 0);
            tax.Name = "tax";
            tax.Size = new Size(150, 23);
            tax.TabIndex = 38;
            tax.Text = "Country Sales tax";
            // 
            // tip
            // 
            tip.AutoSize = true;
            tip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tip.ForeColor = Color.Navy;
            tip.Location = new Point(245, 165);
            tip.Margin = new Padding(2, 0, 2, 0);
            tip.Name = "tip";
            tip.Size = new Size(124, 23);
            tip.TabIndex = 37;
            tip.Text = "State sales tax";
            // 
            // amountpurchasetextBox
            // 
            amountpurchasetextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            amountpurchasetextBox.ForeColor = Color.Navy;
            amountpurchasetextBox.Location = new Point(381, 119);
            amountpurchasetextBox.Margin = new Padding(2);
            amountpurchasetextBox.Name = "amountpurchasetextBox";
            amountpurchasetextBox.Size = new Size(197, 30);
            amountpurchasetextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(152, 122);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 23);
            label1.TabIndex = 35;
            label1.Text = "Enter amount of purchase";
            // 
            // AssChapter3_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(calculatebutton);
            Controls.Add(Totalsaleslabel);
            Controls.Add(Countrylabel);
            Controls.Add(Satelabel);
            Controls.Add(label2);
            Controls.Add(tax);
            Controls.Add(tip);
            Controls.Add(amountpurchasetextBox);
            Controls.Add(label1);
            Name = "AssChapter3_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter3_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBtn;
        private Button calculatebutton;
        private Label Totalsaleslabel;
        private Label Countrylabel;
        private Label Satelabel;
        private Label label2;
        private Label tax;
        private Label tip;
        private TextBox amountpurchasetextBox;
        private Label label1;
    }
}