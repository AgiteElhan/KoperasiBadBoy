using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiBadBoy.Forms
{
    public partial class ExchangePage : UserControl
    {
        public ExchangePage()
        {
            InitializeComponent();
        }

        private void ExchangePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal rate = Convert.ToDecimal(txtRate.Text);
                decimal fee = Convert.ToDecimal(txtFee.Text);
                decimal total = (amount * rate) - fee;
                txtTotal.Text = total.ToString("0.00");
            }
            catch (Exception)
            {
                txtTotal.Text = "0.00";
            }
        }
    }
}
