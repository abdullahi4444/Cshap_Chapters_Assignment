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
    public partial class AssChapter3_10 : Form
    {
        int total = 0;
        public AssChapter3_10()
        {
            InitializeComponent();
        }

        private void pananpictureBox_Click(object sender, EventArgs e)
        {
            total += 115;
            Resultlabel.Text = total.ToString();
        }

        private void applepictureBox_Click(object sender, EventArgs e)
        {
            total += 80;
            Resultlabel.Text = total.ToString();
        }

        private void orangepictureBox_Click(object sender, EventArgs e)
        {
            total += 90;
            Resultlabel.Text = total.ToString();
        }

        private void pearpictureBox_Click(object sender, EventArgs e)
        {
            total += 120;
            Resultlabel.Text = total.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            total = 0;
            Resultlabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
