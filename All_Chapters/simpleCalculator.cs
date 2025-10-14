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
    public partial class simpleCalculator : Form
    {
        private string currentInput = string.Empty;
        private string operation = string.Empty;
        private double firstNumber, secondNumber;
        private bool isNewOperation = true;
        public simpleCalculator()
        {
            InitializeComponent();
        }

        private void simpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (isNewOperation)
                {
                    txtDisplay.Text = "";
                    isNewOperation = false;
                }

                currentInput += button.Text;
                txtDisplay.Text += button.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    firstNumber = double.Parse(currentInput);
                    operation = button.Text;
                    currentInput = ""; // ready for second number
                    txtDisplay.Text = firstNumber + " " + operation + " ";
                }
            }
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(operation) || string.IsNullOrEmpty(currentInput))
                {
                    MessageBox.Show("Enter a valid operation and second number!");
                    return;
                }

                secondNumber = double.Parse(currentInput);

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                }

                txtDisplay.Text = result.ToString();
                currentInput = result.ToString();
                isNewOperation = true;
                operation = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            currentInput = string.Empty;
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
            isNewOperation = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
