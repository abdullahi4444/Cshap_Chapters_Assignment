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
    public partial class AssChapter3_4 : Form
    {
        public AssChapter3_4()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                double AmountPurchase, StateSale, CounrySale, total;
                AmountPurchase = double.Parse(amountpurchasetextBox.Text);
                StateSale = AmountPurchase * 0.04;
                CounrySale = AmountPurchase * 0.02;
                total = AmountPurchase + StateSale + CounrySale;

                Satelabel.Text = StateSale.ToString("c");
                Countrylabel.Text = CounrySale.ToString("c");
                Totalsaleslabel.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("Invalid input pls try again!", "Input Error");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
