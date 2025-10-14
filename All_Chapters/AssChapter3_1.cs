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
    public partial class AssChapter3_1 : Form
    {
        public AssChapter3_1()
        {
            InitializeComponent();
        }

        private void tfmlButton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = titleTextBox.Text + ". " + firstTextBox.Text + " " + middleTextBox.Text + " " + lastTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void fmlbutton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = firstTextBox.Text + " " + middleTextBox.Text + " " + lastTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void flbutton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = firstTextBox.Text + " " + lastTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void lfmtbutton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = lastTextBox.Text + " " + firstTextBox.Text + " " + middleTextBox.Text + " " + titleTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void lfmbutton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = lastTextBox.Text + " " + firstTextBox.Text + " " + middleTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void lfbutton_Click(object sender, EventArgs e)
        {
            string fullInfo;
            fullInfo = lastTextBox.Text + " " + firstTextBox.Text;
            OutputLabel.Text = fullInfo;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
