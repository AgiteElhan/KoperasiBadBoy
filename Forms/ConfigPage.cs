
using KoperasiBadBoy.Data;
using KoperasiBadBoy.Models;
using KoperasiBadBoy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoperasiBadBoy.Data;

namespace KoperasiBadBoy.Forms
{
    public partial class ConfigPage : UserControl
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ConfigPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration config = await service.GetConfig();
            if (config != null)
            {
                textTerminologi1.Text = config.terminologi1;
                textTerminologi2.Text = config.terminologi2;
                textTerminologi3.Text = config.terminologi3;
                textExchangeRate.Text = config.exchangeRate.ToString();
                textInhouseFee.Text = config.transferInhouseFee.ToString();
                textAcccrossFee.Text = config.transferAcrossFee.ToString();

            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(textExchangeRate.Text);
            decimal inhouseFee = decimal.Parse(textInhouseFee.Text);
            decimal accrossFee = decimal.Parse(textAcccrossFee.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(textTerminologi1.Text, textTerminologi2.Text,textTerminologi3.Text, exchangeRate,inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated succesfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
