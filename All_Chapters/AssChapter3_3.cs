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
    public partial class AssChapter3_3 : Form
    {
        public AssChapter3_3()
        {
            InitializeComponent();
        }

        private void c5Button_Click(object sender, EventArgs e)
        {
            try
            {
                double speed, distance;
                speed = double.Parse(speedTextBox.Text);
                distance = speed * 5;
                resultlabel.Text = distance.ToString() + " " + "miles";
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void c8button_Click(object sender, EventArgs e)
        {
            try
            {
                double speed, distance;
                speed = double.Parse(speedTextBox.Text);
                distance = speed * 8;
                resultlabel.Text = distance.ToString() + " " + "miles";
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void c12button_Click(object sender, EventArgs e)
        {
            try
            {
                double speed, distance;
                speed = double.Parse(speedTextBox.Text);
                distance = speed * 12;
                resultlabel.Text = distance.ToString() + " " + "miles";
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
