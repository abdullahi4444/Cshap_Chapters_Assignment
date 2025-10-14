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
    public partial class AssChapter3_8 : Form
    {
        public AssChapter3_8()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double replacement = double.Parse(ReplacementtextBox.Text);
                double insurance = replacement * 0.8;
                Resultlabel.Text = insurance.ToString("c");
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Input Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplacementtextBox.Clear();
            Resultlabel.Text = "";

            ReplacementtextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
