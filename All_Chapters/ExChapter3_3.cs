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
    public partial class ExChapter3_3 : Form
    {
        public ExChapter3_3()
        {
            InitializeComponent();
        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            string output;
            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + YearTextBox.Text;
            dateOutputLabel.Text = output;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            YearTextBox.Clear();
            dateOutputLabel.Text = "";
            dayOfWeekTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
