namespace All_Chapters
{
    partial class AssChapter2_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssChapter2_6));
            label2 = new Label();
            label1 = new Label();
            NameStarsPictureBox = new PictureBox();
            ExitButton = new Button();
            HideButton = new Button();
            ShowButton = new Button();
            NoNameStarsPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NameStarsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoNameStarsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(676, 11);
            label2.Name = "label2";
            label2.Size = new Size(112, 39);
            label2.TabIndex = 18;
            label2.Text = "ID: 767";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(420, 39);
            label1.TabIndex = 17;
            label1.Text = "Name: Abdullahi Abdiweli Adam";
            // 
            // NameStarsPictureBox
            // 
            NameStarsPictureBox.Image = (Image)resources.GetObject("NameStarsPictureBox.Image");
            NameStarsPictureBox.Location = new Point(135, 67);
            NameStarsPictureBox.Name = "NameStarsPictureBox";
            NameStarsPictureBox.Size = new Size(524, 288);
            NameStarsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NameStarsPictureBox.TabIndex = 16;
            NameStarsPictureBox.TabStop = false;
            NameStarsPictureBox.Visible = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Crimson;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(496, 373);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(144, 67);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // HideButton
            // 
            HideButton.BackColor = Color.DodgerBlue;
            HideButton.FlatAppearance.BorderSize = 0;
            HideButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            HideButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            HideButton.FlatStyle = FlatStyle.Flat;
            HideButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            HideButton.ForeColor = Color.White;
            HideButton.Location = new Point(334, 373);
            HideButton.Name = "HideButton";
            HideButton.Size = new Size(144, 67);
            HideButton.TabIndex = 1;
            HideButton.Text = "Hide Star Names";
            HideButton.UseVisualStyleBackColor = false;
            HideButton.Click += HideButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.BackColor = Color.DodgerBlue;
            ShowButton.FlatAppearance.BorderSize = 0;
            ShowButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            ShowButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            ShowButton.FlatStyle = FlatStyle.Flat;
            ShowButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ShowButton.ForeColor = Color.White;
            ShowButton.Location = new Point(172, 373);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(144, 67);
            ShowButton.TabIndex = 0;
            ShowButton.Text = "Show Star Names";
            ShowButton.UseVisualStyleBackColor = false;
            ShowButton.Click += ShowButton_Click;
            // 
            // NoNameStarsPictureBox
            // 
            NoNameStarsPictureBox.Image = Properties.Resources.stars;
            NoNameStarsPictureBox.Location = new Point(135, 67);
            NoNameStarsPictureBox.Name = "NoNameStarsPictureBox";
            NoNameStarsPictureBox.Size = new Size(524, 288);
            NoNameStarsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            NoNameStarsPictureBox.TabIndex = 12;
            NoNameStarsPictureBox.TabStop = false;
            // 
            // AssChapter2_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 466);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameStarsPictureBox);
            Controls.Add(ExitButton);
            Controls.Add(HideButton);
            Controls.Add(ShowButton);
            Controls.Add(NoNameStarsPictureBox);
            Name = "AssChapter2_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter2_6";
            ((System.ComponentModel.ISupportInitialize)NameStarsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoNameStarsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox NameStarsPictureBox;
        private Button ExitButton;
        private Button HideButton;
        private Button ShowButton;
        private PictureBox NoNameStarsPictureBox;
    }
}