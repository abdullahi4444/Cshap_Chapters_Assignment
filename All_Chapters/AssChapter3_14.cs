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
    public partial class AssChapter3_14 : Form
    {
        public AssChapter3_14()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ticket prices
                const decimal CLASS_A_PRICE = 15.00m;
                const decimal CLASS_B_PRICE = 12.00m;
                const decimal CLASS_C_PRICE = 9.00m;

                // Get tickets sold from user
                int classA_Tickets = int.Parse(classATextBox.Text);
                int classB_Tickets = int.Parse(classBTextBox.Text);
                int classC_Tickets = int.Parse(classCTextBox.Text);

                // Calculate income for each class
                decimal incomeA = classA_Tickets * CLASS_A_PRICE;
                decimal incomeB = classB_Tickets * CLASS_B_PRICE;
                decimal incomeC = classC_Tickets * CLASS_C_PRICE;

                // Calculate total revenue
                decimal totalRevenue = incomeA + incomeB + incomeC;

                // Display results
                incomeALabel.Text = $"${incomeA:F2}";
                incomeBLabel.Text = $"${incomeB:F2}";
                incomeCLabel.Text = $"${incomeC:F2}";
                totalLabel.Text = $"${totalRevenue:F2}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for all ticket numbers.", "Input Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classATextBox.Clear();
            classBTextBox.Clear();
            classCTextBox.Clear();
            incomeALabel.Text = "";
            incomeBLabel.Text = "";
            incomeCLabel.Text = "";
            totalLabel.Text = "";

            classATextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
