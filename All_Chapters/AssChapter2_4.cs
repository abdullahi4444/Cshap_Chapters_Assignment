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
    public partial class AssChapter2_4 : Form
    {
        public AssChapter2_4()
        {
            InitializeComponent();
        }

        private void btnSetup__Click(object sender, EventArgs e)
        {
            Jokelabel.Text = "Why did the computer go to therapy?";
        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            Jokelabel.Text = "Because it had too many emotional bugs! 🐞😂";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
