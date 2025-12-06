using KoperasiBadBoy.Api.Connectors;
using KoperasiBadBoy.Api.Models;
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

namespace KoperasiBadBoy.Forms
{
    public partial class AccrosTransferPage : UserControl
    {
        public AccrosTransferPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccrosPage_Load(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();
            Double transferAmount = Double.Parse(textAmount.Text);

            TransferApiResponse? response = await connectorPost.TransferAsync(new TransferPayload
            {
                Amount = transferAmount,
                BenefCode = textBenef.Text,
                CoopCode = loggedMember.ReferenceId,
                MemberCode = loggedMember.MemberId,
                Fee = Double.Parse(config?.transferAcrossFee.ToString()),
                Remarks = textRemarks.Text,
                TransferRef = textTransRef.Text,
            });

            if (response != null && response.ResponseCode == "00")
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
                if (balance != null)
                {
                    balance.Amount -= Decimal.Parse(transferAmount.ToString());
                    balance.UpdateOn = DateTime.Now;
                    balance.TransactionName = "Across Transfer";
                    balance.Flow = "OUT";
                    balanceService.Update(balance);

                    BalanceApiResponse? balanceApiResponse = await connectorPost.BalanceUpdateAsync(new BalancePayload
                    {
                        Amount = Double.Parse(balance.Amount.ToString()),
                        MemberCode = loggedMember.MemberId,
                    });

                    if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                    {
                        MessageBox.Show("Transfer Successful", "Success");
                    }
                }
            }
        }
    }
}
