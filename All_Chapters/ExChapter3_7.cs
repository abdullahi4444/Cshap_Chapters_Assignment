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
    public partial class ExChapter3_7 : Form
    {
        private string name = "Ali";
        public ExChapter3_7()
        {
            InitializeComponent();
        }

        private void ShowNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }

        private void AbdullahiButton_Click(object sender, EventArgs e)
        {
            name = "Abdullahi";
        }

        private void AbdikadirButton_Click(object sender, EventArgs e)
        {
            name = "Abdikadir";
        }
    }
}
