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
    public partial class AssChapter3_6 : Form
    {
        public AssChapter3_6()
        {
            InitializeComponent();
        }

        private void calculateBMIbutton_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, height, bmi;
                weight = double.Parse(WeighttextBox.Text);
                height = double.Parse(HeighttextBox.Text);
                bmi = (weight * 703) / (height * height);
                Resultlabel.Text = bmi.ToString("F1");
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
