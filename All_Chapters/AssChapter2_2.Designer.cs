namespace All_Chapters
{
    partial class AssChapter2_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssChapter2_2));
            CloseButton = new Button();
            label2 = new Label();
            label1 = new Label();
            FivePictureBox = new PictureBox();
            FourPictureBox = new PictureBox();
            ThreePictureBox = new PictureBox();
            TwoPictureBox = new PictureBox();
            OnePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FivePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FourPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThreePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TwoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OnePictureBox).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Crimson;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(197, 375);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(432, 65);
            CloseButton.TabIndex = 19;
            CloseButton.Text = "E&xit";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
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
            // FivePictureBox
            // 
            FivePictureBox.Cursor = Cursors.Hand;
            FivePictureBox.Image = Properties.Resources.five;
            FivePictureBox.Location = new Point(568, 139);
            FivePictureBox.Name = "FivePictureBox";
            FivePictureBox.Size = new Size(107, 188);
            FivePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FivePictureBox.TabIndex = 16;
            FivePictureBox.TabStop = false;
            FivePictureBox.Click += FivePictureBox_Click;
            // 
            // FourPictureBox
            // 
            FourPictureBox.Cursor = Cursors.Hand;
            FourPictureBox.Image = Properties.Resources.four;
            FourPictureBox.Location = new Point(455, 139);
            FourPictureBox.Name = "FourPictureBox";
            FourPictureBox.Size = new Size(107, 188);
            FourPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FourPictureBox.TabIndex = 15;
            FourPictureBox.TabStop = false;
            FourPictureBox.Click += FourPictureBox_Click;
            // 
            // ThreePictureBox
            // 
            ThreePictureBox.Cursor = Cursors.Hand;
            ThreePictureBox.Image = Properties.Resources.three;
            ThreePictureBox.Location = new Point(342, 139);
            ThreePictureBox.Name = "ThreePictureBox";
            ThreePictureBox.Size = new Size(107, 188);
            ThreePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ThreePictureBox.TabIndex = 14;
            ThreePictureBox.TabStop = false;
            ThreePictureBox.Click += ThreePictureBox_Click;
            // 
            // TwoPictureBox
            // 
            TwoPictureBox.Cursor = Cursors.Hand;
            TwoPictureBox.Image = Properties.Resources.two;
            TwoPictureBox.Location = new Point(229, 139);
            TwoPictureBox.Name = "TwoPictureBox";
            TwoPictureBox.Size = new Size(107, 188);
            TwoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TwoPictureBox.TabIndex = 13;
            TwoPictureBox.TabStop = false;
            TwoPictureBox.Click += TwoPictureBox_Click;
            // 
            // OnePictureBox
            // 
            OnePictureBox.Cursor = Cursors.Hand;
            OnePictureBox.Image = (Image)resources.GetObject("OnePictureBox.Image");
            OnePictureBox.Location = new Point(116, 139);
            OnePictureBox.Name = "OnePictureBox";
            OnePictureBox.Size = new Size(107, 188);
            OnePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OnePictureBox.TabIndex = 12;
            OnePictureBox.TabStop = false;
            OnePictureBox.Click += OnePictureBox_Click;
            // 
            // AssChapter2_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 465);
            Controls.Add(CloseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FivePictureBox);
            Controls.Add(FourPictureBox);
            Controls.Add(ThreePictureBox);
            Controls.Add(TwoPictureBox);
            Controls.Add(OnePictureBox);
            Name = "AssChapter2_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssChapter2_2";
            ((System.ComponentModel.ISupportInitialize)FivePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FourPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThreePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TwoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OnePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Label label2;
        private Label label1;
        private PictureBox FivePictureBox;
        private PictureBox FourPictureBox;
        private PictureBox ThreePictureBox;
        private PictureBox TwoPictureBox;
        private PictureBox OnePictureBox;
    }
}