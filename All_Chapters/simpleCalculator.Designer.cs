namespace All_Chapters
{
    partial class simpleCalculator
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
            txtDisplay = new TextBox();
            btnAdd = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(171, 53);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(462, 27);
            txtDisplay.TabIndex = 37;
            txtDisplay.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(522, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 52);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Visible = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Bisque;
            btnEquals.Cursor = Cursors.Hand;
            btnEquals.FlatAppearance.BorderSize = 30;
            btnEquals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnEquals.Location = new Point(405, 278);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(111, 52);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Visible = false;
            btnEquals.Click += btnEquals_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.ForestGreen;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(288, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 52);
            btnClear.TabIndex = 34;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Bisque;
            btn0.Cursor = Cursors.Hand;
            btn0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn0.Location = new Point(171, 278);
            btn0.Name = "btn0";
            btn0.Size = new Size(111, 52);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Visible = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.LightBlue;
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSubtract.Location = new Point(522, 220);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(111, 52);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Visible = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Bisque;
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn3.Location = new Point(405, 220);
            btn3.Name = "btn3";
            btn3.Size = new Size(111, 52);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Visible = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Bisque;
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn2.Location = new Point(288, 220);
            btn2.Name = "btn2";
            btn2.Size = new Size(111, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Visible = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Bisque;
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn1.Location = new Point(171, 220);
            btn1.Name = "btn1";
            btn1.Size = new Size(111, 52);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Visible = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.LightBlue;
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnMultiply.Location = new Point(522, 162);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(111, 52);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Visible = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Bisque;
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn6.Location = new Point(405, 162);
            btn6.Name = "btn6";
            btn6.Size = new Size(111, 52);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Visible = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Bisque;
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn5.Location = new Point(288, 162);
            btn5.Name = "btn5";
            btn5.Size = new Size(111, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Visible = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Bisque;
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn4.Location = new Point(171, 162);
            btn4.Name = "btn4";
            btn4.Size = new Size(111, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Visible = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.LightBlue;
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDivide.Location = new Point(522, 104);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(111, 52);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Visible = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Bisque;
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn9.Location = new Point(405, 104);
            btn9.Name = "btn9";
            btn9.Size = new Size(111, 52);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Visible = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Bisque;
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn8.Location = new Point(288, 104);
            btn8.Name = "btn8";
            btn8.Size = new Size(111, 52);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Visible = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Bisque;
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn7.Location = new Point(171, 104);
            btn7.Name = "btn7";
            btn7.Size = new Size(111, 52);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(357, 386);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 38;
            button1.Text = "E&xit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // simpleCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Name = "simpleCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "simpleCalculator";
            Load += simpleCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnClear;
        private Button btn0;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button button1;
    }
}