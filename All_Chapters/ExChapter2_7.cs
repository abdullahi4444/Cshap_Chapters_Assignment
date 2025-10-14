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
    public partial class ExChapter2_7 : Form
    {
        public ExChapter2_7()
        {
            InitializeComponent();
        }

        private void ExChapter2_7_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            backpictureBox.Visible = true;
            frontpictureBox.Visible = false;
        }

        private void frontbutton_Click(object sender, EventArgs e)
        {
            frontpictureBox.Visible = true;
            backpictureBox.Visible = false;
        }

        private void FandBbutton_Click(object sender, EventArgs e)
        {
            frontpictureBox.Visible = true;
            backpictureBox.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
