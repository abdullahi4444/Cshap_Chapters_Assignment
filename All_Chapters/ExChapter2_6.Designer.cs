namespace All_Chapters
{
    partial class ExChapter2_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExChapter2_6));
            clearbutton = new Button();
            countryLabel = new Label();
            palestinePictureBox = new PictureBox();
            saudiaPictureBox = new PictureBox();
            somaliaPictureBox = new PictureBox();
            instructionLabel = new Label();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)palestinePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saudiaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)somaliaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // clearbutton
            // 
            clearbutton.BackColor = Color.ForestGreen;
            clearbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbutton.ForeColor = SystemColors.ButtonHighlight;
            clearbutton.Location = new Point(270, 373);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(125, 65);
            clearbutton.TabIndex = 11;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = false;
            clearbutton.Click += clearbutton_Click;
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.Fixed3D;
            countryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countryLabel.Location = new Point(169, 308);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(420, 62);
            countryLabel.TabIndex = 10;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // palestinePictureBox
            // 
            palestinePictureBox.Cursor = Cursors.Hand;
            palestinePictureBox.Image = (Image)resources.GetObject("palestinePictureBox.Image");
            palestinePictureBox.Location = new Point(533, 78);
            palestinePictureBox.Name = "palestinePictureBox";
            palestinePictureBox.Size = new Size(253, 214);
            palestinePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            palestinePictureBox.TabIndex = 9;
            palestinePictureBox.TabStop = false;
            palestinePictureBox.Click += palestinePictureBox_Click;
            // 
            // saudiaPictureBox
            // 
            saudiaPictureBox.Cursor = Cursors.Hand;
            saudiaPictureBox.Image = (Image)resources.GetObject("saudiaPictureBox.Image");
            saudiaPictureBox.Location = new Point(274, 78);
            saudiaPictureBox.Name = "saudiaPictureBox";
            saudiaPictureBox.Size = new Size(253, 214);
            saudiaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            saudiaPictureBox.TabIndex = 8;
            saudiaPictureBox.TabStop = false;
            saudiaPictureBox.Click += saudiaPictureBox_Click;
            // 
            // somaliaPictureBox
            // 
            somaliaPictureBox.Cursor = Cursors.Hand;
            somaliaPictureBox.Image = (Image)resources.GetObject("somaliaPictureBox.Image");
            somaliaPictureBox.Location = new Point(15, 78);
            somaliaPictureBox.Name = "somaliaPictureBox";
            somaliaPictureBox.Size = new Size(253, 214);
            somaliaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            somaliaPictureBox.TabIndex = 7;
            somaliaPictureBox.TabStop = false;
            somaliaPictureBox.Click += somaliaPictureBox_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionLabel.Location = new Point(169, 23);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(459, 36);
            instructionLabel.TabIndex = 6;
            instructionLabel.Text = "Click the flag to see the name of the country";
            instructionLabel.Click += instructionLabel_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ControlLightLight;
            ExitButton.Location = new Point(401, 373);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(126, 65);
            ExitButton.TabIndex = 12;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ExChapter2_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(clearbutton);
            Controls.Add(countryLabel);
            Controls.Add(palestinePictureBox);
            Controls.Add(saudiaPictureBox);
            Controls.Add(somaliaPictureBox);
            Controls.Add(instructionLabel);
            Name = "ExChapter2_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter2_6";
            ((System.ComponentModel.ISupportInitialize)palestinePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)saudiaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)somaliaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearbutton;
        private Label countryLabel;
        private PictureBox palestinePictureBox;
        private PictureBox saudiaPictureBox;
        private PictureBox somaliaPictureBox;
        private Label instructionLabel;
        private Button ExitButton;
    }
}