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
    public partial class DashboardAdminPage : UserControl
    {
        private MemberAccessException? loggedMember;
        public DashboardAdminPage(MemberAccessException? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void DashboardAdminPage_Load(object sender, EventArgs e)
        {

        }
    }
}
