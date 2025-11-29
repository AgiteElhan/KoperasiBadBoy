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
    public partial class RegistrasiFrom : Form
    {
        public RegistrasiFrom()
        {
            InitializeComponent();
        }

        private void RegistrasiFrom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(txtAddress.Text, txtCardId.Text,
                txtEmail.Text, txtName.Text, txtPassword.Text,
                txtPhone.Text, txtPhoneAlt.Text, txtReferenceId.Text,
                txtUsername.Text, txtQuest1.Text, txtQuest2.Text);

            if (member != null)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.setSuccessAlert("Registration Success! Please Login...");
                loginForm.ShowDialog();
            }
            else
            {
                labelError.Text = "Registration Failed!";
                labelError.Visible = true;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtArtis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
