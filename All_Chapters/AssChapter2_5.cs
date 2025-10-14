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
    public partial class AssChapter2_5 : Form
    {
        public AssChapter2_5()
        {
            InitializeComponent();
        }

        private void ShHeadButton_Click(object sender, EventArgs e)
        {
            HeadCoinpictureBox.Visible = true;
            TailCoinPictureBox.Visible = false;
        }

        private void ShTailButton_Click(object sender, EventArgs e)
        {
            HeadCoinpictureBox.Visible = false;
            TailCoinPictureBox.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
