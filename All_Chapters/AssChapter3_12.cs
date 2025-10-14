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
    public partial class AssChapter3_12 : Form
    {
        public AssChapter3_12()
        {
            InitializeComponent();
        }

        private void AssChapter3_12_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Constants
                const double SQUARE_FEET_PER_GALLON = 115.0;
                const double HOURS_PER_GALLON = 8.0;
                const double HOURLY_RATE = 20.0;

                // Get user inputs
                double squareFeet = double.Parse(squareFeetTextBox.Text);
                double pricePerGallon = double.Parse(priceTextBox.Text);

                // Calculate values
                double gallonsRequired = Math.Ceiling(squareFeet / SQUARE_FEET_PER_GALLON);
                double hoursRequired = (squareFeet / SQUARE_FEET_PER_GALLON) * HOURS_PER_GALLON;
                double paintCost = gallonsRequired * pricePerGallon;
                double laborCharges = hoursRequired * HOURLY_RATE;
                double totalCost = paintCost + laborCharges;

                // Display results
                gallonsLabel.Text = $"Gallons of paint required: {gallonsRequired}";
                hoursLabel.Text = $"Hours of labor required: {hoursRequired:F2}";
                paintCostLabel.Text = $"Cost of paint: ${paintCost:F2}";
                laborLabel.Text = $"Labor charges: ${laborCharges:F2}";
                totalLabel.Text = $"Total cost of paint job: ${totalCost:F2}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            squareFeetTextBox.Clear();
            priceTextBox.Clear();
            gallonsLabel.Text = "";
            hoursLabel.Text = "";
            paintCostLabel.Text = "";
            laborLabel.Text = "";
            totalLabel.Text = "";

            squareFeetTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
