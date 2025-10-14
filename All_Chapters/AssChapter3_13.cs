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
    public partial class AssChapter3_13 : Form
    {
        public AssChapter3_13()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Constant: tax rate is $0.64 per $100
                const double TAX_RATE = 0.64;

                // Get property value input
                double propertyValue = double.Parse(valueTextBox.Text);

                // Calculate property tax
                double tax = (propertyValue / 100) * TAX_RATE;

                // Display result
                taxLabel.Text = $"Property Tax: ${tax:F2}";
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric property value.", "Input Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueTextBox.Clear();
            taxLabel.Text = "";

            valueTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
