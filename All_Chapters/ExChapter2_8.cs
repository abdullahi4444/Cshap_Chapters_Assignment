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
    public partial class ExChapter2_8 : Form
    {
        public ExChapter2_8()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input
                double hoursWorked = double.Parse(hoursTextBox.Text);
                double hourlyRate = double.Parse(rateTextBox.Text);

                // Calculate gross pay
                double grossPay = hoursWorked * hourlyRate;

                // Display result
                payTextBox.Text = grossPay.ToString("C2");  // “C2” formats as currency
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
