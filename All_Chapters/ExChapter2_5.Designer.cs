namespace All_Chapters
{
    partial class ExChapter2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExChapter2_5));
            label1 = new Label();
            catPictureBox = new PictureBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)catPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label1.Location = new Point(313, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 3;
            label1.Text = "Click The Cat";
            // 
            // catPictureBox
            // 
            catPictureBox.BorderStyle = BorderStyle.Fixed3D;
            catPictureBox.Cursor = Cursors.Hand;
            catPictureBox.Image = (Image)resources.GetObject("catPictureBox.Image");
            catPictureBox.Location = new Point(147, 73);
            catPictureBox.Name = "catPictureBox";
            catPictureBox.Size = new Size(500, 300);
            catPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            catPictureBox.TabIndex = 2;
            catPictureBox.TabStop = false;
            catPictureBox.Click += catPictureBox_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(336, 396);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 68);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 476);
            Controls.Add(ExitButton);
            Controls.Add(label1);
            Controls.Add(catPictureBox);
            Name = "ExChapter2_5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_5";
            Load += ExChapter2_5_Load;
            ((System.ComponentModel.ISupportInitialize)catPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox catPictureBox;
        private Button ExitButton;
    }
}