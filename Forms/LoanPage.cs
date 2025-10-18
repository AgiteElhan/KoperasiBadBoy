using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoperasiBadBoy.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace KoperasiBadBoy.Forms
{
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        InstallmentForm? installmentForm;

        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void btnApplyLoan_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            decimal amount = decimal.Parse(txtMinAmount.Text);
            decimal minAmount = decimal.Parse(txtMinAmount.Text);
            decimal maxAmount = decimal.Parse(txtMaxAmount.Text);

            if (amount < minAmount || amount > maxAmount)
            {
                MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await loanService.SaveOrUpdate(loggedMember, txtLoanID.Text, txtDocumenKTP.Text, txtDocumentKK.Text, txtDocumentSlipGaji.Text, txtDueDate.Text, txtInterest.Text, txtTenor.Text, txtInterestFine.Text, txtMinAmount.Text, txtMaxAmount.Text);
        }

        private void HideInstallment()
        {
            if (installmentForm == null)
            {
                installmentForm = new InstallmentForm(loggedMember, 0);
            }
            installmentForm.Hide();
        }
        private void ResetDropDown()
        {
            txtInterest.Text = "";
            txtInterestFine.Text = "";
            txtTenor.Text = "";
            txtMinAmount.Text = "";
            txtMaxAmount.Text = "";
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }
        private void SetLoanDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            cmbLoanType.DataSource = productService.SetDropdownLoan();
            cmbLoanType.DisplayMember = "DisplayName";
            cmbLoanType.ValueMember = "Id";
        }

        private void btnBrowseKTP_Click(object sender, EventArgs e)
        {
            txtDocumenKTP.Text = FileHelper.UploadDocument("KTP");
        }

        private void btnBrowseKK_Click(object sender, EventArgs e)
        {
            txtDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void btnBrowseSlipGaji_Click(object sender, EventArgs e)
        {
            txtDocumentSlipGaji.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            cmbLoanType.Enabled = true;
            HideInstallment();
        }
        private void SetDefaultField()
        {
            cmbLoanType.SelectedIndex = 0;
            btnShowKK.Visible = false;
            btnShowKTP.Visible = false;
            btnShowSlipGaji.Visible = false;
            btnBrowseKK.Visible = true;
            btnBrowseKTP.Visible = true;
            btnBrowseSlipGaji.Visible = true;
        }
        private void SetChosenField()
        {
            btnShowKK.Visible = true;
            btnShowKTP.Visible = true;
            btnShowSlipGaji.Visible = true;
            btnBrowseKK.Visible = false;
            btnBrowseKTP.Visible = false;
            btnBrowseSlipGaji.Visible = false;
        }

        private void ResetField()
        {
            textBoxKk.Text = "";
            textBoxKtp.Text = "";
            textBoxSlip.Text = "";
            textBoxDueDate.Text = "";
            textBoxInterest.Text = "";
            textBoxTenor.Text = "";
            textBoxFine.Text = "";
            textBoxMinAmount.Text = "";
            textBoxMaxAmount.Text = "";
            textBoxLoanId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelId.Text = "";
        }
        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            dataGridViewLoan.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);
            dataGridViewLoan.Columns[0].DataPropertyName = "Id";
            dataGridViewLoan.Columns[1].DataPropertyName = "LoanId";
            dataGridViewLoan.Columns[2].DataPropertyName = "Outstanding";
            dataGridViewLoan.Columns[3].DataPropertyName = "ErrorLeft";

            dataGridViewLoan.Columns[0].Visible = false;
            dataGridViewLoan.Columns[1].HeaderText = "Loan ID";
            dataGridViewLoan.Columns[2].HeaderText = "Outstanding";
            dataGridViewLoan.Columns[3].HeaderText = "Error Left";
        }

        private void dgvLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                Loan? loan = await loanService.FindLoanById(id);

                if (loan != null)
                {
                    if (loan.IsApproved)
                    {
                        SetChosenField();
                        textBoxKk.Text = loan.KkPath;
                        textBoxKtp.Text = loan.KtpPath;
                        textBoxSlip.Text = loan.SlipGajiPath;
                        textBoxDueDate.Text = loan.DueDate.ToString();
                        textBoxInterest.Text = loan.Interest.ToString();
                        textBoxTenor.Text = loan.Tenor.ToString();
                        textBoxFine.Text = loan.Fine.ToString();
                        textBoxMinAmount.Text = loan.MinAmount.ToString();
                        textBoxMaxAmount.Text = loan.MaxAmount.ToString();
                        labelId.Text = loan.Id.ToString();
                        comboLoanMaster.SelectedIndex = 0;
                        comboLoanMaster.Enabled = false;

                        if (installmentForm == null)
                        {
                            installmentForm = new InstallmentForm(loggedMember, 0);
                            installmentForm.SetLoan(loan.Id);
                            installmentForm.Show();
                        }

                        buttonApply.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your Loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();
                    }
                }
                else
                {
                    HideInstallment();
                }
            }
        }

        private void cmbLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropDown();

            if (comboLoanMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboLoanMaster.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.FindLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    textBoxInterest.Text = loanMaster.Interest.ToString();
                    textBoxFine.Text = loanMaster.Fine.ToString();
                    textBoxTenor.Text = loanMaster.Tenor.ToString();
                    textBoxMinAmount.Text = loanMaster.MinAmount.ToString();
                    textBoxMaxAmount.Text = loanMaster.MaxAmount.ToString();
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
            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            HideInstallment();
        }
    }
}


