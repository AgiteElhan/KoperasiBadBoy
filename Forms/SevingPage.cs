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
    public partial class SevingPage : UserControl
    {
        Member loggedMember;
        public SevingPage(Member member)
        {
            InitializeComponent();
            loggedMember = member;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void SevingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void SetDefaultField()
        {
            cbSavingType.SelectedIndex = 0;
            btnShowKTP.Visible = false;
            btnShowKK.Visible = false;
            btnShowGaji.Visible = false;
            btnBrowseKTP.Visible = true;
            btnBrowseKK.Visible = true;
            btnBrowseGaji.Visible = true;
        }

        private void SetChosenField()
        {
            btnShowKTP.Visible = true;
            btnShowKK.Visible = true;
            btnShowGaji.Visible = true;
            btnBrowseKTP.Visible = false;
            btnBrowseKK.Visible = false;
            btnBrowseGaji.Visible = false;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbSavingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSavingType.SelectedIndex == 0)
                ResetDropDown();

            if (cbSavingType.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(cbSavingType.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.findLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    txtInterest.Text = loanMaster.Interest.ToString();
                    txtInterestFine.Text = loanMaster.Fine.ToString();
                    txtTenor.Text = loanMaster.Tenor.ToString();
                    txtAdminFee.Text = loanMaster.AdminFee.ToString();
                    txtMinAmount.Text = loanMaster.MinAmount.ToString();
                    txtMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }
    }
}
