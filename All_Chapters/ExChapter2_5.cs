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
    public partial class ExChapter2_5 : Form
    {
        public ExChapter2_5()
        {
            InitializeComponent();
        }

        private void ExChapter2_5_Load(object sender, EventArgs e)
        {

        }

        private void catPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meow");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
