namespace KoperasiBadBoy.Forms
{
    partial class AccrosTransferPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBalance = new TextBox();
            txtAmoun = new TextBox();
            txtTranferRef = new TextBox();
            txtRemarack = new TextBox();
            txtBenefiCary = new TextBox();
            label5 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            dgvIncoming = new DataGridView();
            dgvOutgoing = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Amoun";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 269);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Tranfer Ref";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 342);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Remarack";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(154, 64);
            txtBalance.Margin = new Padding(4, 4, 4, 4);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(275, 31);
            txtBalance.TabIndex = 4;
            // 
            // txtAmoun
            // 
            txtAmoun.Location = new Point(154, 215);
            txtAmoun.Margin = new Padding(4, 4, 4, 4);
            txtAmoun.Name = "txtAmoun";
            txtAmoun.Size = new Size(275, 31);
            txtAmoun.TabIndex = 5;
            // 
            // txtTranferRef
            // 
            txtTranferRef.Location = new Point(154, 298);
            txtTranferRef.Margin = new Padding(4, 4, 4, 4);
            txtTranferRef.Name = "txtTranferRef";
            txtTranferRef.Size = new Size(275, 31);
            txtTranferRef.TabIndex = 6;
            // 
            // txtRemarack
            // 
            txtRemarack.Location = new Point(154, 371);
            txtRemarack.Margin = new Padding(4, 4, 4, 4);
            txtRemarack.Name = "txtRemarack";
            txtRemarack.Size = new Size(275, 31);
            txtRemarack.TabIndex = 7;
            // 
            // txtBenefiCary
            // 
            txtBenefiCary.Location = new Point(154, 149);
            txtBenefiCary.Margin = new Padding(4, 4, 4, 4);
            txtBenefiCary.Name = "txtBenefiCary";
            txtBenefiCary.Size = new Size(275, 31);
            txtBenefiCary.TabIndex = 9;
            txtBenefiCary.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 8;
            label5.Text = "BenefiCary";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(165, 476);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(312, 476);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 36);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvIncoming
            // 
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(591, 64);
            dgvIncoming.Margin = new Padding(4, 4, 4, 4);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.RowHeadersWidth = 51;
            dgvIncoming.Size = new Size(375, 235);
            dgvIncoming.TabIndex = 12;
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(591, 354);
            dgvOutgoing.Margin = new Padding(4, 4, 4, 4);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.RowHeadersWidth = 51;
            dgvOutgoing.Size = new Size(375, 235);
            dgvOutgoing.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 325);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 14;
            label6.Text = "Outgoing";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(591, 35);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 15;
            label7.Text = "Incoming";
            // 
            // AccrosPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvOutgoing);
            Controls.Add(dgvIncoming);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtBenefiCary);
            Controls.Add(label5);
            Controls.Add(txtRemarack);
            Controls.Add(txtTranferRef);
            Controls.Add(txtAmoun);
            Controls.Add(txtBalance);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AccrosPage";
            Size = new Size(1302, 708);
            Load += AccrosPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBalance;
        private TextBox txtAmoun;
        private TextBox txtTranferRef;
        private TextBox txtRemarack;
        private TextBox txtBenefiCary;
        private Label label5;
        private Button btnSubmit;
        private Button btnClear;
        private DataGridView dgvIncoming;
        private DataGridView dgvOutgoing;
        private Label label6;
        private Label label7;
    }
}
