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
    public partial class ExChapter3_5 : Form
    {
        public ExChapter3_5()
        {
            InitializeComponent();
        }

        private void ExChapter3_5_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal originalPrice; // The item's original price
                decimal discountPercentage; // The discount percentage
                decimal discountAmount; // The amount of discount
                decimal salePrice; // The item's sale price

                originalPrice = decimal.Parse(originalPriceTextBox.Text);
                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
                discountPercentage = discountPercentage / 100;
                discountAmount = originalPrice * discountPercentage;
                salePrice = originalPrice - discountAmount;

                salePriceLabel.Text = salePrice.ToString("c");

                originalPriceTextBox.Clear();
                discountPercentageTextBox.Clear();
                originalPriceTextBox.Focus();
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
