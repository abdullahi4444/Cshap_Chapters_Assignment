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
    public partial class AssChapter3_11 : Form
    {
        public AssChapter3_11()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read user inputs
                decimal loan = decimal.Parse(loanTextBox.Text);
                decimal insurance = decimal.Parse(insuranceTextBox.Text);
                decimal gas = decimal.Parse(gasTextBox.Text);
                decimal oil = decimal.Parse(oilTextBox.Text);
                decimal tires = decimal.Parse(tiresTextBox.Text);
                decimal maintenance = decimal.Parse(maintenanceTextBox.Text);

                // Calculate monthly and annual totals
                decimal totalMonthly = loan + insurance + gas + oil + tires + maintenance;
                decimal totalAnnual = totalMonthly * 12;

                // Display results
                monthlyLabel.Text = $"Total Monthly Cost: ${totalMonthly:F2}";
                annualLabel.Text = $"Total Annual Cost: ${totalAnnual:F2}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for all fields.", "Input Error");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loanTextBox.Clear();
            insuranceTextBox.Clear();
            gasTextBox.Clear();
            oilTextBox.Clear();
            tiresTextBox.Clear();
            maintenanceTextBox.Clear();
            monthlyLabel.Text = "";
            annualLabel.Text = "";

            loanTextBox.Focus();
        }
    }
}
