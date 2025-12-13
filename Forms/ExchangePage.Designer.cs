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
            txtAmount.Location = new Point(264, 155);
            txtAmount.Margin = new Padding(4, 4, 4, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(322, 31);
            txtAmount.TabIndex = 0;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(264, 291);
            txtSubTotal.Margin = new Padding(4, 4, 4, 4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(322, 31);
            txtSubTotal.TabIndex = 1;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(264, 362);
            txtFee.Margin = new Padding(4, 4, 4, 4);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(322, 31);
            txtFee.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(264, 219);
            txtRate.Margin = new Padding(4, 4, 4, 4);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(322, 31);
            txtRate.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(264, 419);
            txtTotal.Margin = new Padding(4, 4, 4, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(322, 31);
            txtTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 5;
            label1.Text = "Exchange USD";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 291);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 6;
            label2.Text = "Sub Total";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 366);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 25);
            label3.TabIndex = 7;
            label3.Text = "Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 9;
            label4.Text = "Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 8;
            label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 422);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 10;
            label6.Text = "Total";
            label6.Click += label6_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(156, 588);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 36);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(339, 588);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 36);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ExchangePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "ExchangePage";
            Size = new Size(658, 706);
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
