using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_Chapters
{
    public partial class AssChapter2_6 : Form
    {
        public AssChapter2_6()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            NoNameStarsPictureBox.Visible = false;
            NameStarsPictureBox.Visible = true;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            NoNameStarsPictureBox.Visible = true;
            NameStarsPictureBox.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
