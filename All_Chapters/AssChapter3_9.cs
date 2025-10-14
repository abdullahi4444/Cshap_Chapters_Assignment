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
    public partial class AssChapter3_9 : Form
    {
        public AssChapter3_9()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double cookies = double.Parse(CookiestextBox.Text);
                double totalcalories = cookies * 75;
                Resultlabel.Text = totalcalories.ToString("0.0") + " " + "calories";
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Input Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CookiestextBox.Clear();
            Resultlabel.Text = "";

            CookiestextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
