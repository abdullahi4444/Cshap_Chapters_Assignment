namespace All_Chapters
{
    partial class AssChapter2_4
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
            Jokelabel = new Label();
            instructionLabel = new Label();
            btnSetup_ = new Button();
            btnPunchLine = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // Jokelabel
            // 
            Jokelabel.BackColor = Color.White;
            Jokelabel.BorderStyle = BorderStyle.Fixed3D;
            Jokelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Jokelabel.ForeColor = Color.Navy;
            Jokelabel.Location = new Point(208, 191);
            Jokelabel.Margin = new Padding(2, 0, 2, 0);
            Jokelabel.Name = "Jokelabel";
            Jokelabel.Size = new Size(380, 54);
            Jokelabel.TabIndex = 14;
            Jokelabel.TextAlign = ContentAlignment.MiddleCenter;
            Jokelabel.UseWaitCursor = true;
            // 
            // instructionLabel
            // 
            instructionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            instructionLabel.ForeColor = Color.Navy;
            instructionLabel.Location = new Point(254, 149);
            instructionLabel.Margin = new Padding(2, 0, 2, 0);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(295, 33);
            instructionLabel.TabIndex = 11;
            instructionLabel.Text = "Setup and Punch Line";
            instructionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSetup_
            // 
            btnSetup_.BackColor = Color.DodgerBlue;
            btnSetup_.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSetup_.ForeColor = Color.AliceBlue;
            btnSetup_.Location = new Point(170, 267);
            btnSetup_.Margin = new Padding(2);
            btnSetup_.Name = "btnSetup_";
            btnSetup_.Size = new Size(156, 64);
            btnSetup_.TabIndex = 0;
            btnSetup_.Text = "Setup";
            btnSetup_.UseVisualStyleBackColor = false;
            btnSetup_.Click += btnSetup__Click;
            // 
            // btnPunchLine
            // 
            btnPunchLine.BackColor = Color.DodgerBlue;
            btnPunchLine.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPunchLine.ForeColor = Color.AliceBlue;
            btnPunchLine.Location = new Point(332, 267);
            btnPunchLine.Margin = new Padding(2);
            btnPunchLine.Name = "btnPunchLine";
            btnPunchLine.Size = new Size(156, 64);
            btnPunchLine.TabIndex = 1;
            btnPunchLine.Text = "Punch line";
            btnPunchLine.UseVisualStyleBackColor = false;
            btnPunchLine.Click += btnPunchLine_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Crimson;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(492, 267);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 64);
            btnExit.TabIndex = 2;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // AssChapter2_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Jokelabel);
            Controls.Add(instructionLabel);
            Controls.Add(btnSetup_);
            Controls.Add(btnPunchLine);
            Controls.Add(btnExit);
            Name = "AssChapter2_4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter2_4";
            ResumeLayout(false);
        }

        #endregion

        private Label Jokelabel;
        private Label instructionLabel;
        private Button btnSetup_;
        private Button btnPunchLine;
        private Button btnExit;
    }
}