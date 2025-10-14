namespace All_Chapters
{
    partial class ExChapter2_7
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
            backbutton = new Button();
            frontbutton = new Button();
            backpictureBox = new PictureBox();
            frontpictureBox = new PictureBox();
            FandBbutton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)backpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frontpictureBox).BeginInit();
            SuspendLayout();
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.CornflowerBlue;
            backbutton.Cursor = Cursors.Hand;
            backbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            backbutton.ForeColor = SystemColors.ButtonHighlight;
            backbutton.Location = new Point(221, 321);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(124, 69);
            backbutton.TabIndex = 0;
            backbutton.Text = "Show The Card Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // frontbutton
            // 
            frontbutton.BackColor = Color.CornflowerBlue;
            frontbutton.Cursor = Cursors.Hand;
            frontbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            frontbutton.ForeColor = SystemColors.ButtonHighlight;
            frontbutton.Location = new Point(351, 321);
            frontbutton.Name = "frontbutton";
            frontbutton.Size = new Size(124, 69);
            frontbutton.TabIndex = 1;
            frontbutton.Text = "Show The Card Front";
            frontbutton.UseVisualStyleBackColor = false;
            frontbutton.Click += frontbutton_Click;
            // 
            // backpictureBox
            // 
            backpictureBox.Image = Properties.Resources.back;
            backpictureBox.Location = new Point(170, 51);
            backpictureBox.Name = "backpictureBox";
            backpictureBox.Size = new Size(210, 246);
            backpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backpictureBox.TabIndex = 2;
            backpictureBox.TabStop = false;
            backpictureBox.Visible = false;
            // 
            // frontpictureBox
            // 
            frontpictureBox.Image = Properties.Resources.front;
            frontpictureBox.Location = new Point(408, 51);
            frontpictureBox.Name = "frontpictureBox";
            frontpictureBox.Size = new Size(210, 246);
            frontpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            frontpictureBox.TabIndex = 3;
            frontpictureBox.TabStop = false;
            frontpictureBox.Visible = false;
            // 
            // FandBbutton
            // 
            FandBbutton.BackColor = Color.DarkTurquoise;
            FandBbutton.Cursor = Cursors.Hand;
            FandBbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FandBbutton.ForeColor = SystemColors.ButtonHighlight;
            FandBbutton.Location = new Point(481, 321);
            FandBbutton.Name = "FandBbutton";
            FandBbutton.Size = new Size(124, 69);
            FandBbutton.TabIndex = 2;
            FandBbutton.Text = "Show Front and Back";
            FandBbutton.UseVisualStyleBackColor = false;
            FandBbutton.Click += FandBbutton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(351, 396);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 70);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 478);
            Controls.Add(ExitButton);
            Controls.Add(FandBbutton);
            Controls.Add(frontpictureBox);
            Controls.Add(backpictureBox);
            Controls.Add(frontbutton);
            Controls.Add(backbutton);
            Name = "ExChapter2_7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_7";
            Load += ExChapter2_7_Load;
            ((System.ComponentModel.ISupportInitialize)backpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)frontpictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backbutton;
        private Button frontbutton;
        private PictureBox backpictureBox;
        private PictureBox frontpictureBox;
        private Button FandBbutton;
        private Button ExitButton;
    }
}