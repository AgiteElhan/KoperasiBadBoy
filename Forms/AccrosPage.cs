using KoperasiBadBoy.Api.Connectors;
using KoperasiBadBoy.Api.Models;
using KoperasiBadBoy.Data;
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
    public partial class AccrosPage : UserControl
    {
        public AccrosPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async Task<string> MemberRegistration(AppDbContext db)
        {
            string message = "Succes";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
            
                message = "Configuration not found!";
            

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    message = "Coop not registered to Across System. Please contact administrator.";
                }
                try
                {
                    MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(
                        new MemberPayload
                        {
                            name = loggedMember.FullName,
                            address = loggedMember.Address,
                            code = loggedMember.MemberId,
                            coopCode = configuration.terminologi3!
                        });

                    if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                    {
                        loggedMember.ReferenceId = configuration.terminologi3!;
                        memberService.Update(loggedMember);

                        BalanceService balanceService = new BalanceService(db);
                        balanceService.setBalance(loggedMember.MemberId);

                        timerInbox.Enabled = true;
                    }
                    else
                    {
                        message = "Failed to register member to across system: " + memberApiResponse?.ResponseMessage;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccrosPage_Load(object sender, EventArgs e)
        {

        }
    }
}
