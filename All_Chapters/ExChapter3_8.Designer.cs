namespace All_Chapters
{
    partial class ExChapter3_8
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
            FiveCentPictureBox = new PictureBox();
            TenCentPictureBox = new PictureBox();
            FiftyCentsPictureBox = new PictureBox();
            TwntyFiveCentPictureBox = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ExitButton = new Button();
            OutputDescriptionLabel = new Label();
            TotalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FiveCentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TenCentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FiftyCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TwntyFiveCentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(262, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Click The Coin";
            // 
            // FiveCentPictureBox
            // 
            FiveCentPictureBox.Cursor = Cursors.Hand;
            FiveCentPictureBox.Image = Properties.Resources._5cent;
            FiveCentPictureBox.Location = new Point(131, 70);
            FiveCentPictureBox.Name = "FiveCentPictureBox";
            FiveCentPictureBox.Size = new Size(183, 181);
            FiveCentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FiveCentPictureBox.TabIndex = 1;
            FiveCentPictureBox.TabStop = false;
            FiveCentPictureBox.Click += FiveCentPictureBox_Click;
            // 
            // TenCentPictureBox
            // 
            TenCentPictureBox.Cursor = Cursors.Hand;
            TenCentPictureBox.Image = Properties.Resources._10cent;
            TenCentPictureBox.Location = new Point(331, 70);
            TenCentPictureBox.Name = "TenCentPictureBox";
            TenCentPictureBox.Size = new Size(183, 181);
            TenCentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TenCentPictureBox.TabIndex = 2;
            TenCentPictureBox.TabStop = false;
            TenCentPictureBox.Click += TenCentPictureBox_Click;
            // 
            // FiftyCentsPictureBox
            // 
            FiftyCentsPictureBox.Cursor = Cursors.Hand;
            FiftyCentsPictureBox.Image = Properties.Resources._50cent;
            FiftyCentsPictureBox.Location = new Point(331, 257);
            FiftyCentsPictureBox.Name = "FiftyCentsPictureBox";
            FiftyCentsPictureBox.Size = new Size(183, 181);
            FiftyCentsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FiftyCentsPictureBox.TabIndex = 4;
            FiftyCentsPictureBox.TabStop = false;
            FiftyCentsPictureBox.Click += FiftyCentsPictureBox_Click;
            // 
            // TwntyFiveCentPictureBox
            // 
            TwntyFiveCentPictureBox.Cursor = Cursors.Hand;
            TwntyFiveCentPictureBox.Image = Properties.Resources._25cent;
            TwntyFiveCentPictureBox.Location = new Point(131, 257);
            TwntyFiveCentPictureBox.Name = "TwntyFiveCentPictureBox";
            TwntyFiveCentPictureBox.Size = new Size(183, 181);
            TwntyFiveCentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TwntyFiveCentPictureBox.TabIndex = 3;
            TwntyFiveCentPictureBox.TabStop = false;
            TwntyFiveCentPictureBox.Click += TwntyFiveCentPictureBox_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Firebrick;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(265, 468);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 57);
            ExitButton.TabIndex = 32;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // OutputDescriptionLabel
            // 
            OutputDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            OutputDescriptionLabel.ForeColor = Color.Navy;
            OutputDescriptionLabel.Location = new Point(567, 219);
            OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            OutputDescriptionLabel.Size = new Size(80, 32);
            OutputDescriptionLabel.TabIndex = 33;
            OutputDescriptionLabel.Text = "Total:";
            // 
            // TotalLabel
            // 
            TotalLabel.BorderStyle = BorderStyle.Fixed3D;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TotalLabel.ForeColor = Color.Navy;
            TotalLabel.Location = new Point(567, 257);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(195, 32);
            TotalLabel.TabIndex = 34;
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExChapter3_8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 537);
            Controls.Add(TotalLabel);
            Controls.Add(OutputDescriptionLabel);
            Controls.Add(ExitButton);
            Controls.Add(FiftyCentsPictureBox);
            Controls.Add(TwntyFiveCentPictureBox);
            Controls.Add(TenCentPictureBox);
            Controls.Add(FiveCentPictureBox);
            Controls.Add(label1);
            Name = "ExChapter3_8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_8";
            Load += ExChapter3_8_Load;
            ((System.ComponentModel.ISupportInitialize)FiveCentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TenCentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FiftyCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TwntyFiveCentPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox FiveCentPictureBox;
        private PictureBox TenCentPictureBox;
        private PictureBox FiftyCentsPictureBox;
        private PictureBox TwntyFiveCentPictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ExitButton;
        private Label OutputDescriptionLabel;
        private Label TotalLabel;
    }
}