namespace All_Chapters
{
    partial class ExChapter2_3
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
            answerLabel = new Label();
            showbutton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 76);
            label1.Name = "label1";
            label1.Size = new Size(339, 80);
            label1.TabIndex = 0;
            label1.Text = "What former U.S. president is known for going on";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            answerLabel.BorderStyle = BorderStyle.Fixed3D;
            answerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answerLabel.Location = new Point(245, 203);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(289, 47);
            answerLabel.TabIndex = 1;
            answerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showbutton
            // 
            showbutton.BackColor = SystemColors.Highlight;
            showbutton.Cursor = Cursors.Hand;
            showbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showbutton.ForeColor = SystemColors.ButtonHighlight;
            showbutton.Location = new Point(257, 282);
            showbutton.Name = "showbutton";
            showbutton.Size = new Size(126, 68);
            showbutton.TabIndex = 2;
            showbutton.Text = "Show Answer";
            showbutton.UseVisualStyleBackColor = false;
            showbutton.Click += showbutton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(389, 282);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(134, 68);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(showbutton);
            Controls.Add(answerLabel);
            Controls.Add(label1);
            Name = "ExChapter2_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_3";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label answerLabel;
        private Button showbutton;
        private Button ExitButton;
    }
}