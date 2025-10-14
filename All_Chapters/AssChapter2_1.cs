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
    public partial class AssChapter2_1 : Form
    {
        public AssChapter2_1()
        {
            InitializeComponent();
        }

        private void SinisterButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Center";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
