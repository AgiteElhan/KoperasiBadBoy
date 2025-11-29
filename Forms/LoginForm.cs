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

namespace KoperasiBadBoy.Forms

{
    public partial class LoginForm : Form
    {
        public Member? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void setSuccessAlert(string message)
        {
            Username_Label.Text = message;
            Username_Label.Visible = true;
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            Username_Label.Visible = false;
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(Username_Label.Text, Username_Label.Text);
            if (user != null)
            {
                LoggedInUser = user;
                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    AdminForm form = new AdminForm(LoggedInUser);
                    form.ShowDialog();
                }
                else
                {
                    AccessService accessService = new AccessService(db);
                    Access access = await accessService.GetAccess(user.Id);
                    if (access == null)
                    {
                        Username_Label.Text = "YAaahh Gabisa mAsuK (Wkwkwkwk)";
                        Username_Label.ForeColor = Color.Red;
                        Username_Label.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        HomeForm form = new HomeForm(LoggedInUser);
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                Username_Label.Text = "Password SalAHH";
                Username_Label.ForeColor = Color.Red;
                Username_Label.Visible = true;
            }
        }

        private void Reset_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
