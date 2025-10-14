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
    public partial class ExChapter2_4 : Form
    {
        public ExChapter2_4()
        {
            InitializeComponent();
        }

        private void somaliButton_Click_1(object sender, EventArgs e)
        {
            translationLabel.Text = "Subax Wanagsan";
        }

        private void italianButton_Click_1(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void arabicButton_Click_1(object sender, EventArgs e)
        {
            translationLabel.Text = "Sabaxal Kheyr";
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            translationLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
