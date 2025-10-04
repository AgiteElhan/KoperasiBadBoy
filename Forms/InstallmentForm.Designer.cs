namespace KoperasiBadBoy.Forms
{
    partial class InstallmentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLoanID = new TextBox();
            txtAmount = new TextBox();
            txtReceipt = new TextBox();
            button1 = new Button();
            btnBrowse = new Button();
            btnNewInstallment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 426);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Loan ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 91);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 158);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 3;
            label3.Text = "Receipt";
            // 
            // txtLoanID
            // 
            txtLoanID.Location = new Point(432, 52);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(336, 31);
            txtLoanID.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(432, 119);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(336, 31);
            txtAmount.TabIndex = 5;
            // 
            // txtReceipt
            // 
            txtReceipt.Location = new Point(432, 187);
            txtReceipt.Name = "txtReceipt";
            txtReceipt.Size = new Size(336, 31);
            txtReceipt.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(656, 244);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(432, 326);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnNewInstallment
            // 
            btnNewInstallment.Location = new Point(563, 326);
            btnNewInstallment.Name = "btnNewInstallment";
            btnNewInstallment.Size = new Size(205, 34);
            btnNewInstallment.TabIndex = 9;
            btnNewInstallment.Text = "New Installment";
            btnNewInstallment.UseVisualStyleBackColor = true;
            // 
            // InstallmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewInstallment);
            Controls.Add(btnBrowse);
            Controls.Add(button1);
            Controls.Add(txtReceipt);
            Controls.Add(txtAmount);
            Controls.Add(txtLoanID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "InstallmentForm";
            Text = "InstallmentForm";
            Load += InstallmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLoanID;
        private TextBox txtAmount;
        private TextBox txtReceipt;
        private Button button1;
        private Button btnBrowse;
        private Button btnNewInstallment;
    }
}