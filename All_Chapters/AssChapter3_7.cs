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
    public partial class AssChapter3_7 : Form
    {
        public AssChapter3_7()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "A ";
        }

        private void btna_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "a ";
        }

        private void buttonAn_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "An ";
        }

        private void btnan_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "an ";
        }

        private void buttonThe_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "The ";
        }

        private void btnthe_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "the ";
        }

        private void mabutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Man ";
        }

        private void Womenbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Women ";
        }

        private void Dobutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Dog ";
        }

        private void catbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "Cat ";
        }

        private void carbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "car";
        }

        private void bicyclebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "bicycle ";
        }

        private void beautybutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "beautiful ";
        }

        private void bigbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "big ";
        }

        private void smallbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "small ";
        }

        private void strangebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "strange";
        }

        private void lokedbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "looked at ";
        }

        private void nodebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "node ";
        }

        private void spokebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "spoke to ";
        }

        private void laughtedbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "laughed at ";
        }

        private void drovebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "drove";
        }

        private void spacebutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "  ";
        }

        private void dotbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += ".";
        }

        private void exclamationbutton_Click(object sender, EventArgs e)
        {
            Resultlabel.Text += "!";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
