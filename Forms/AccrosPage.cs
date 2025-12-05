using KoperasiBadBoy.Data;
using KoperasiBadBoy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiBadBoy.Forms.MemberMenus
{
    public partial class AccrosPage : UserControl
    {   
        Member loggedMember;
        public AccrosPage(Member member)
        {
            InitializeComponent();
            loggedMember = member;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccrosPage_Load(object sender, EventArgs e)
        {
            timerInbox.Enabled = false;

            if (loggedMember.ReferenceId == null ||
                loggedMember.ReferenceId == "" ||
                loggedMember.ReferenceId == "-")
            {
                DialogResult result = MessageBox.Show(
                    "You do not have a privilege to Use Across Transfer. Registration Now?",
                    "Invalid",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    string message;

                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }

                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
            }
            else
            {
                timerInbox.Enabled = true;
            }
        }
    }
}
