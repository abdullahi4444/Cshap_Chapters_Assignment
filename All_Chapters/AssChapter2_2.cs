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
    public partial class AssChapter2_2 : Form
    {
        public AssChapter2_2()
        {
            InitializeComponent();
        }

        private void OnePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void TwoPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void ThreePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void FourPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void FivePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
