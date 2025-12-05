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

namespace KoperasiBadBoy.Forms.Admin
{
    public partial class AccrosPage : UserControl
    {
        public AccrosPage()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AcrossPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            AppDbContext appDbContext = new AppDbContext();
            ConfigurationService configurationService = new ConfigurationService(appDbContext);
            Configuration? configuration = await configurationService.GetConfig();
            String message = "";

            ConnectorGet connectorGet = new ConnectorGet();
            CoopApiResponse? coopApiResponse = await connectorGet.GetCoopAsync();
            if (coopApiResponse != null && coopApiResponse.ResponseCode == "00")
            {
                dgvCoop.Rows.Clear();
                foreach (var coop in coopApiResponse.CoopList)
                {
                    dgvCoop.Rows.Add(coop.Code, coop.Name, coop.Address);
                }
            }
            else
            {
                message = coopApiResponse != null ? coopApiResponse.ResponseCode + " - "
                    + coopApiResponse.ResponseMessage : "Did not get data";
            }

            BalanceApiResponse? balanceApiResponse = await connectorGet.GetBalancesByCoopAsync(configuration.terminologi3);
            if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
            {
                dgvBalance.Rows.Clear();
                foreach (var balance in balanceApiResponse.BalanceList)
                {
                    dgvBalance.Rows.Add(balance.Member.Code, balance.Member.Name, balance.Amount);
                }
            }
            else
            {
                message = balanceApiResponse != null ? balanceApiResponse.ResponseCode + " - "
                    + balanceApiResponse.ResponseMessage : "Did not get data";
            }

            TransferApiResponse? transferApiResponse = await connectorGet.GetTransfersByCoopAsync(configuration.terminologi3);
            if (transferApiResponse != null && transferApiResponse.ResponseCode == "00")
            {
                dgvTransfer.Rows.Clear();
                foreach (var transfer in transferApiResponse.TransferList)
                {
                    dgvTransfer.Rows.Add(transfer.Code, transfer.CoopCode, transfer.CodeOrigin, transfer.CodeBenef, transfer.Amount, transfer.Remarks);
                }
            }
            else
            {
                message = transferApiResponse != null ? transferApiResponse.ResponseCode + " - "
                    + transferApiResponse.ResponseMessage : "Did not get data";
            }

            if (message != "")
            {
                MessageBox.Show("Failed to load data from API.\n Error:" + message);
            }
        }
        private async void timerInbox_Tick(object sender, EventArgs e)
        {
            timerInbox.Stop();
            try
            {
                //timerInbox.Start();
                Console.WriteLine("Retrieving...");
                ConnectorGet connectorGet = new ConnectorGet();

                TransferApiResponse? responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                    dgvOutgoing.Columns["Id"].Visible = false;
                    dgvOutgoing.Columns["MemverCode"].Visible = false;
                    dgvOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dgvOutgoing.Columns["coopCode"].Visible = false;
                    dgvOutgoing.Columns["updateOn"].Visible = false;
                    dgvOutgoing.Columns["transferRef"].HeaderText = "Reference";
                    dgvOutgoing.Columns["transferDate"].HeaderText = "Date";
                    dgvOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dgvOutgoing.Columns["Fee"].HeaderText = "Fee";
                    dgvOutgoing.Columns["Remarks"].HeaderText = "Remarks";
                    dgvOutgoing.Columns["transactionCode"].HeaderText = "Transaction Code";
                }

                string benefCode = logggedMember.ReferencedId + "-" + loggedMember.MemberId;
                TransferApiResponse? responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseIncoming != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvIncoming.DataSource = responseIncoming.TransferList;
                    dgvIncoming.Columns["Id"].Visible = false;
                    dgvIncoming.Columns["memberCode"].HeaderText = "Member Code";
                    dgvIncoming.Columns["BenefCode"].Visible = false;
                    dgvIncoming.Columns["CoopCode"].Visible = "Coop Code";
                    dgvIncoming.Columns["updateOn"].Visible = false;
                    dgvIncoming.Columns["TransferRef"].HeaderText = "Reference";
                    dgvIncoming.Columns["TransferDate"].HeaderText = "Date";
                    dgvIncoming.Columns["Amount"].HeaderText = "Amount";
                    dgvIncoming.Columns["Fee"].HeaderText = "Fee";
                    dgvIncoming.Columns["Remarks"].HeaderText = "Remarks";
                    dgvIncoming.Columns["transactionCode"].HeaderText = "Transaction Code";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                timerInbox.Start(); // restart setelah selesai
            }
        }

    }
}
