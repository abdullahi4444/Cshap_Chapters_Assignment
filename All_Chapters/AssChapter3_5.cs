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
    public partial class AssChapter3_5 : Form
    {
        public AssChapter3_5()
        {
            InitializeComponent();
        }

        private void btnTofahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius, fahrenheit;
                celsius = double.Parse(TempTextBox.Text);
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                Resultlabel.Text = fahrenheit.ToString("F1") + " °F";
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void btnTocelcius_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius, fahrenheit;
                fahrenheit = double.Parse(TempTextBox.Text);
                celsius = (5.0 / 9.0) * (fahrenheit - 32);
                Resultlabel.Text = celsius.ToString("F1") + " °C";
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
