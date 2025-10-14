namespace All_Chapters
{
    partial class AssChapter2_5
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
            HeadCoinpictureBox = new PictureBox();
            TailCoinPictureBox = new PictureBox();
            ExitButton = new Button();
            ShHeadButton = new Button();
            ShTailButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HeadCoinpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TailCoinPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HeadCoinpictureBox
            // 
            HeadCoinpictureBox.Image = Properties.Resources.Head;
            HeadCoinpictureBox.Location = new Point(122, 97);
            HeadCoinpictureBox.Margin = new Padding(2);
            HeadCoinpictureBox.Name = "HeadCoinpictureBox";
            HeadCoinpictureBox.Size = new Size(252, 210);
            HeadCoinpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            HeadCoinpictureBox.TabIndex = 6;
            HeadCoinpictureBox.TabStop = false;
            HeadCoinpictureBox.Visible = false;
            // 
            // TailCoinPictureBox
            // 
            TailCoinPictureBox.Image = Properties.Resources.Tail;
            TailCoinPictureBox.Location = new Point(399, 97);
            TailCoinPictureBox.Margin = new Padding(2);
            TailCoinPictureBox.Name = "TailCoinPictureBox";
            TailCoinPictureBox.Size = new Size(252, 210);
            TailCoinPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TailCoinPictureBox.TabIndex = 7;
            TailCoinPictureBox.TabStop = false;
            TailCoinPictureBox.Visible = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(471, 355);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShHeadButton
            // 
            ShHeadButton.BackColor = Color.DodgerBlue;
            ShHeadButton.Cursor = Cursors.Hand;
            ShHeadButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ShHeadButton.ForeColor = SystemColors.ControlLightLight;
            ShHeadButton.Location = new Point(167, 355);
            ShHeadButton.Name = "ShHeadButton";
            ShHeadButton.Size = new Size(146, 57);
            ShHeadButton.TabIndex = 0;
            ShHeadButton.Text = "Shaw Head";
            ShHeadButton.UseVisualStyleBackColor = false;
            ShHeadButton.Click += ShHeadButton_Click;
            // 
            // ShTailButton
            // 
            ShTailButton.BackColor = Color.DodgerBlue;
            ShTailButton.Cursor = Cursors.Hand;
            ShTailButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ShTailButton.ForeColor = SystemColors.ControlLightLight;
            ShTailButton.Location = new Point(319, 355);
            ShTailButton.Name = "ShTailButton";
            ShTailButton.Size = new Size(146, 57);
            ShTailButton.TabIndex = 1;
            ShTailButton.Text = "Show Tail";
            ShTailButton.UseVisualStyleBackColor = false;
            ShTailButton.Click += ShTailButton_Click;
            // 
            // AssChapter2_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShTailButton);
            Controls.Add(ExitButton);
            Controls.Add(ShHeadButton);
            Controls.Add(TailCoinPictureBox);
            Controls.Add(HeadCoinpictureBox);
            Name = "AssChapter2_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter2_5";
            ((System.ComponentModel.ISupportInitialize)HeadCoinpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TailCoinPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox HeadCoinpictureBox;
        private PictureBox TailCoinPictureBox;
        private Button ExitButton;
        private Button ShHeadButton;
        private Button ShTailButton;
    }
}