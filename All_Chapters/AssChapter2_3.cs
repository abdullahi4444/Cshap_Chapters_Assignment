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
    public partial class AssChapter2_3 : Form
    {
        public AssChapter2_3()
        {
            InitializeComponent();
        }

        private void OnepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Two of Clubs";
        }

        private void TwopictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Ace of Hearts";
        }

        private void ThreepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "King of Spades";
        }

        private void FourpictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Ten of Diamonds";
        }

        private void FivepictureBox_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "Seven of Hearts";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssChapter2_3_Load(object sender, EventArgs e)
        {

        }
    }
}
