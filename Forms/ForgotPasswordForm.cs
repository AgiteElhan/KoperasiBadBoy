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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.showDialog();
        }

        private async Task BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new appDbContext();
            var auth = new AuthService(db);//EA1C1B
            var password = await auth.ResetPasswordAsync(TxtUsername.Text, TxtFavColor.Text, TxtFavArtist.Text);
            if (password =="")
            {
                MessageBox.Show("Invalid username or the answer", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                TxtPassword.Text = password;
            }
        }
    }
}
