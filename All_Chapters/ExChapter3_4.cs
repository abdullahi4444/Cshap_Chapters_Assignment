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
    public partial class ExChapter3_4 : Form
    {
        public ExChapter3_4()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double miles;
                double gallons;
                double mpg;

                miles = double.Parse(mileTextBox.Text);
                gallons = double.Parse(gallonsTextBox.Text);
                mpg = miles / gallons;
                mpgLabel.Text = mpg.ToString();

                mileTextBox.Clear();
                gallonsTextBox.Clear();
                mileTextBox.Focus();
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

        private void ExChapter3_4_Load(object sender, EventArgs e)
        {

        }
    }
}
