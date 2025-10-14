namespace All_Chapters
{
    partial class ExChapter3_7
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
            ShowNameButton = new Button();
            AbdullahiButton = new Button();
            AbdikadirButton = new Button();
            SuspendLayout();
            // 
            // ShowNameButton
            // 
            ShowNameButton.BackColor = Color.DodgerBlue;
            ShowNameButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowNameButton.ForeColor = SystemColors.ButtonHighlight;
            ShowNameButton.Location = new Point(353, 143);
            ShowNameButton.Name = "ShowNameButton";
            ShowNameButton.Size = new Size(102, 76);
            ShowNameButton.TabIndex = 0;
            ShowNameButton.Text = "Show Name";
            ShowNameButton.UseVisualStyleBackColor = false;
            ShowNameButton.Click += ShowNameButton_Click;
            // 
            // AbdullahiButton
            // 
            AbdullahiButton.BackColor = Color.DodgerBlue;
            AbdullahiButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AbdullahiButton.ForeColor = SystemColors.ButtonHighlight;
            AbdullahiButton.Location = new Point(190, 225);
            AbdullahiButton.Name = "AbdullahiButton";
            AbdullahiButton.Size = new Size(170, 76);
            AbdullahiButton.TabIndex = 1;
            AbdullahiButton.Text = "Change Name to Abdullahi";
            AbdullahiButton.UseVisualStyleBackColor = false;
            AbdullahiButton.Click += AbdullahiButton_Click;
            // 
            // AbdikadirButton
            // 
            AbdikadirButton.BackColor = Color.DodgerBlue;
            AbdikadirButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AbdikadirButton.ForeColor = SystemColors.ButtonHighlight;
            AbdikadirButton.Location = new Point(450, 225);
            AbdikadirButton.Name = "AbdikadirButton";
            AbdikadirButton.Size = new Size(170, 76);
            AbdikadirButton.TabIndex = 2;
            AbdikadirButton.Text = "Change Name to Abdikadir";
            AbdikadirButton.UseVisualStyleBackColor = false;
            AbdikadirButton.Click += AbdikadirButton_Click;
            // 
            // ExChapter3_7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AbdikadirButton);
            Controls.Add(AbdullahiButton);
            Controls.Add(ShowNameButton);
            Name = "ExChapter3_7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExChapter3_7";
            ResumeLayout(false);
        }

        #endregion

        private Button ShowNameButton;
        private Button AbdullahiButton;
        private Button AbdikadirButton;
    }
}