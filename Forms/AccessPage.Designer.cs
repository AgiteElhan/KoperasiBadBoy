namespace KoperasiBadBoy.Forms
{
    partial class AccessPage
    {
        private void AccessPage_Load(object sender, EventArgs e)
        {
             /// <summary> 
             /// Required designer variable.
             /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
            
        }
       

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMember = new Label();
            cbMember = new ComboBox();
            btnSubmit = new Button();
            Detail = new GroupBox();
            txtAddress = new Label();
            labelAddress = new Label();
            txtPhoneAlt = new Label();
            labelFullName = new Label();
            txtNoPhone = new Label();
            labelJoinDate = new Label();
            txtEmail = new Label();
            labelEmail = new Label();
            txtJoinDate = new Label();
            labelNoPhone = new Label();
            txtFullName = new Label();
            labelPhoneAlt = new Label();
            label11 = new Label();
            label10 = new Label();
            dgvAccess = new DataGridView();
            txtAccess = new Label();
            LbGrup = new ListBox();
            cbGrantAll = new CheckBox();
            cbLoan = new CheckBox();
            cbSaving = new CheckBox();
            cbTransferInhouse = new CheckBox();
            cbTransferAccross = new CheckBox();
            cbExchenge = new CheckBox();
            Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccess).BeginInit();
            SuspendLayout();
            // 
            // txtMember
            // 
            txtMember.AutoSize = true;
            txtMember.Location = new Point(67, 75);
            txtMember.Name = "txtMember";
            txtMember.Size = new Size(65, 20);
            txtMember.TabIndex = 0;
            txtMember.Text = "Member";
            txtMember.Click += label1_Click;
            // 
            // cbMember
            // 
            cbMember.FormattingEnabled = true;
            cbMember.Location = new Point(67, 104);
            cbMember.Name = "cbMember";
            cbMember.Size = new Size(151, 28);
            cbMember.TabIndex = 3;
            cbMember.SelectedIndexChanged += cbMember_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(234, 103);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Detail
            // 
            Detail.Controls.Add(txtAddress);
            Detail.Controls.Add(labelAddress);
            Detail.Controls.Add(txtPhoneAlt);
            Detail.Controls.Add(labelFullName);
            Detail.Controls.Add(txtNoPhone);
            Detail.Controls.Add(labelJoinDate);
            Detail.Controls.Add(txtEmail);
            Detail.Controls.Add(labelEmail);
            Detail.Controls.Add(txtJoinDate);
            Detail.Controls.Add(labelNoPhone);
            Detail.Controls.Add(txtFullName);
            Detail.Controls.Add(labelPhoneAlt);
            Detail.Controls.Add(label11);
            Detail.Controls.Add(label10);
            Detail.Location = new Point(67, 366);
            Detail.Name = "Detail";
            Detail.Size = new Size(307, 263);
            Detail.TabIndex = 6;
            Detail.TabStop = false;
            Detail.Text = "Detail";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Location = new Point(206, 224);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(15, 20);
            txtAddress.TabIndex = 30;
            txtAddress.Text = "-";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(60, 224);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 20;
            labelAddress.Text = "Address";
            // 
            // txtPhoneAlt
            // 
            txtPhoneAlt.AutoSize = true;
            txtPhoneAlt.Location = new Point(206, 182);
            txtPhoneAlt.Name = "txtPhoneAlt";
            txtPhoneAlt.Size = new Size(15, 20);
            txtPhoneAlt.TabIndex = 29;
            txtPhoneAlt.Text = "-";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(60, 15);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(76, 20);
            labelFullName.TabIndex = 16;
            labelFullName.Text = "Full Name";
            labelFullName.Click += label3_Click;
            // 
            // txtNoPhone
            // 
            txtNoPhone.AutoSize = true;
            txtNoPhone.Location = new Point(206, 142);
            txtNoPhone.Name = "txtNoPhone";
            txtNoPhone.Size = new Size(15, 20);
            txtNoPhone.TabIndex = 28;
            txtNoPhone.Text = "-";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(60, 52);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(71, 20);
            labelJoinDate.TabIndex = 17;
            labelJoinDate.Text = "Join Date";
            labelJoinDate.Click += label4_Click;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(206, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(15, 20);
            txtEmail.TabIndex = 27;
            txtEmail.Text = "-";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(60, 93);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Email";
            // 
            // txtJoinDate
            // 
            txtJoinDate.AutoSize = true;
            txtJoinDate.Location = new Point(206, 52);
            txtJoinDate.Name = "txtJoinDate";
            txtJoinDate.Size = new Size(15, 20);
            txtJoinDate.TabIndex = 26;
            txtJoinDate.Text = "-";
            // 
            // labelNoPhone
            // 
            labelNoPhone.AutoSize = true;
            labelNoPhone.Location = new Point(60, 142);
            labelNoPhone.Name = "labelNoPhone";
            labelNoPhone.Size = new Size(74, 20);
            labelNoPhone.TabIndex = 19;
            labelNoPhone.Text = "No Phone";
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Location = new Point(206, 15);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(15, 20);
            txtFullName.TabIndex = 25;
            txtFullName.Text = "-";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.Location = new Point(60, 182);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(73, 20);
            labelPhoneAlt.TabIndex = 21;
            labelPhoneAlt.Text = "Phone Alt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(206, 52);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 24;
            label11.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(206, 52);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 23;
            label10.Text = "-";
            // 
            // dgvAccess
            // 
            dgvAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccess.Location = new Point(449, 111);
            dgvAccess.Name = "dgvAccess";
            dgvAccess.RowHeadersWidth = 51;
            dgvAccess.Size = new Size(651, 499);
            dgvAccess.TabIndex = 8;
            dgvAccess.CellContentClick += dgvAccess_CellContentClick;
            // 
            // txtAccess
            // 
            txtAccess.AutoSize = true;
            txtAccess.Location = new Point(449, 75);
            txtAccess.Name = "txtAccess";
            txtAccess.Size = new Size(53, 20);
            txtAccess.TabIndex = 9;
            txtAccess.Text = "Access";
            txtAccess.Click += label2_Click;
            // 
            // LbGrup
            // 
            LbGrup.FormattingEnabled = true;
            LbGrup.Items.AddRange(new object[] { "" });
            LbGrup.Location = new Point(67, 143);
            LbGrup.Name = "LbGrup";
            LbGrup.Size = new Size(261, 204);
            LbGrup.TabIndex = 7;
            LbGrup.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cbGrantAll
            // 
            cbGrantAll.AutoSize = true;
            cbGrantAll.Location = new Point(79, 164);
            cbGrantAll.Name = "cbGrantAll";
            cbGrantAll.Size = new Size(89, 24);
            cbGrantAll.TabIndex = 0;
            cbGrantAll.Text = "Grant All";
            cbGrantAll.UseVisualStyleBackColor = true;
            // 
            // cbLoan
            // 
            cbLoan.AutoSize = true;
            cbLoan.Location = new Point(79, 193);
            cbLoan.Name = "cbLoan";
            cbLoan.Size = new Size(63, 24);
            cbLoan.TabIndex = 11;
            cbLoan.Text = "Loan";
            cbLoan.UseVisualStyleBackColor = true;
            // 
            // cbSaving
            // 
            cbSaving.AutoSize = true;
            cbSaving.Location = new Point(79, 223);
            cbSaving.Name = "cbSaving";
            cbSaving.Size = new Size(75, 24);
            cbSaving.TabIndex = 12;
            cbSaving.Text = "Saving";
            cbSaving.UseVisualStyleBackColor = true;
            // 
            // cbTransferInhouse
            // 
            cbTransferInhouse.AutoSize = true;
            cbTransferInhouse.Location = new Point(79, 253);
            cbTransferInhouse.Name = "cbTransferInhouse";
            cbTransferInhouse.Size = new Size(148, 24);
            cbTransferInhouse.TabIndex = 13;
            cbTransferInhouse.Text = "Transfer - Inhouse";
            cbTransferInhouse.UseVisualStyleBackColor = true;
            // 
            // cbTransferAccross
            // 
            cbTransferAccross.AutoSize = true;
            cbTransferAccross.Location = new Point(79, 283);
            cbTransferAccross.Name = "cbTransferAccross";
            cbTransferAccross.Size = new Size(147, 24);
            cbTransferAccross.TabIndex = 14;
            cbTransferAccross.Text = "Transfer - Accross";
            cbTransferAccross.UseVisualStyleBackColor = true;
            // 
            // cbExchenge
            // 
            cbExchenge.AutoSize = true;
            cbExchenge.Location = new Point(79, 313);
            cbExchenge.Name = "cbExchenge";
            cbExchenge.Size = new Size(94, 24);
            cbExchenge.TabIndex = 15;
            cbExchenge.Text = "Exchenge";
            cbExchenge.UseVisualStyleBackColor = true;
            cbExchenge.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbExchenge);
            Controls.Add(cbTransferAccross);
            Controls.Add(cbTransferInhouse);
            Controls.Add(cbSaving);
            Controls.Add(cbLoan);
            Controls.Add(cbGrantAll);
            Controls.Add(txtAccess);
            Controls.Add(dgvAccess);
            Controls.Add(LbGrup);
            Controls.Add(Detail);
            Controls.Add(btnSubmit);
            Controls.Add(cbMember);
            Controls.Add(txtMember);
            Name = "AccessPage";
            Size = new Size(1292, 689);
            Load += AccessPage_Load;
            Detail.ResumeLayout(false);
            Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtMember;
        private ComboBox cbMember;
        private Button btnSubmit;
        private GroupBox Detail;
        private DataGridView dgvAccess;
        private Label txtAccess;
        private ListBox LbGrup;
        private CheckBox cbGrantAll;
        private CheckBox cbLoan;
        private CheckBox cbSaving;
        private CheckBox cbTransferInhouse;
        private CheckBox cbTransferAccross;
        private CheckBox cbExchenge;
        private Label labelFullName;
        private Label labelJoinDate;
        private Label labelEmail;
        private Label labelNoPhone;
        private Label labelAddress;
        private Label labelPhoneAlt;
        private Label label10;
        private Label label11;
        private Label txtEmail;
        private Label txtJoinDate;
        private Label txtFullName;
        private Label txtAddress;
        private Label txtPhoneAlt;
        private Label txtNoPhone;
    }
}
