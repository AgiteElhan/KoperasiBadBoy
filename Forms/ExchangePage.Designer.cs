namespace KoperasiBadBoy.Forms
{
    partial class ExchangePage
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
            txtAmount = new TextBox();
            txtSubTotal = new TextBox();
            txtFee = new TextBox();
            txtRate = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(211, 124);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(258, 27);
            txtAmount.TabIndex = 0;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(211, 233);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(258, 27);
            txtSubTotal.TabIndex = 1;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(211, 290);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(258, 27);
            txtFee.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(211, 175);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(258, 27);
            txtRate.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(211, 335);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(258, 27);
            txtTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 35);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 5;
            label1.Text = "Exchange USD";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 233);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = "Sub Total";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 293);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 7;
            label3.Text = "Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 182);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 9;
            label4.Text = "Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 122);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 338);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 10;
            label6.Text = "Total";
            label6.Click += label6_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(125, 470);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(271, 470);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtRate);
            Controls.Add(txtFee);
            Controls.Add(txtSubTotal);
            Controls.Add(txtAmount);
            Name = "ExchangePage";
            Size = new Size(526, 565);
            Load += ExchangePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private TextBox txtSubTotal;
        private TextBox txtFee;
        private TextBox txtRate;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSubmit;
        private Button btnClear;
    }
}
