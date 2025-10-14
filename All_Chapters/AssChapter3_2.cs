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
    public partial class AssChapter3_2 : Form
    {
        public AssChapter3_2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double charge;
                double tip;
                double tax;
                double total;

                charge = double.Parse(foodChargeTextBox.Text);
                tip = charge * 0.15;
                tax = charge * 0.07;
                total = charge + tip + tax;

                tiplabel.Text = tip.ToString("c");
                taxlabel.Text = tax.ToString("c");
                totallabel.Text = total.ToString("c");
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
