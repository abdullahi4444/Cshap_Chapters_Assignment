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
    public partial class ExChapter2_2 : Form
    {
        public ExChapter2_2()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the first button!");
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the second button!");
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the third button!");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
