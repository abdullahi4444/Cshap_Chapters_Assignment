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
    public partial class ExChapter2_6 : Form
    {
        public ExChapter2_6()
        {
            InitializeComponent();
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void somaliaPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Somalia Flag";
        }

        private void saudiaPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Saudi Arabia Flag";
        }

        private void palestinePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Palestine Flag";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
