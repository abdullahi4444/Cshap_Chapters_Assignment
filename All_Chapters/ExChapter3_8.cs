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
    public partial class ExChapter3_8 : Form
    {
        // Constant fields
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        private decimal total = 0m;
        public ExChapter3_8()
        {
            InitializeComponent();
        }

        private void ExChapter3_8_Load(object sender, EventArgs e)
        {

        }

        private void FiveCentPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            TotalLabel.Text = total.ToString("c");
        }

        private void TenCentPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            TotalLabel.Text = total.ToString("c");
        }

        private void TwntyFiveCentPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS_VALUE;
            TotalLabel.Text = total.ToString("c");
        }

        private void FiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            TotalLabel.Text = total.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
