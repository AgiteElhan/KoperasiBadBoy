namespace KoperasiBadBoy.Forms
{
    partial class ConfigPage
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
            textTerminologi1 = new TextBox();
            label2 = new Label();
            textExchangeRate = new TextBox();
            btnUpdate = new Button();
            textInhouseFee = new TextBox();
            label3 = new Label();
            textTerminologi2 = new TextBox();
            label4 = new Label();
            textAcccrossFee = new TextBox();
            label5 = new Label();
            textTerminologi3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Terminologi 1";
            // 
            // textTerminologi1
            // 
            textTerminologi1.Location = new Point(48, 59);
            textTerminologi1.Multiline = true;
            textTerminologi1.Name = "textTerminologi1";
            textTerminologi1.Size = new Size(247, 257);
            textTerminologi1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 324);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "Exchange Rate";
            // 
            // textExchangeRate
            // 
            textExchangeRate.Location = new Point(48, 358);
            textExchangeRate.Name = "textExchangeRate";
            textExchangeRate.Size = new Size(247, 31);
            textExchangeRate.TabIndex = 3;
            textExchangeRate.TextChanged += textBox2_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(379, 412);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textInhouseFee
            // 
            textInhouseFee.Location = new Point(313, 358);
            textInhouseFee.Name = "textInhouseFee";
            textInhouseFee.Size = new Size(247, 31);
            textInhouseFee.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 324);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Inhouse Fee";
            // 
            // textTerminologi2
            // 
            textTerminologi2.Location = new Point(313, 59);
            textTerminologi2.Multiline = true;
            textTerminologi2.Name = "textTerminologi2";
            textTerminologi2.Size = new Size(247, 257);
            textTerminologi2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 21);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 5;
            label4.Text = "Terminologi 2";
            // 
            // textAcccrossFee
            // 
            textAcccrossFee.Location = new Point(579, 358);
            textAcccrossFee.Name = "textAcccrossFee";
            textAcccrossFee.Size = new Size(247, 31);
            textAcccrossFee.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(579, 324);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 11;
            label5.Text = "Acrross Fee";
            // 
            // textTerminologi3
            // 
            textTerminologi3.Location = new Point(579, 59);
            textTerminologi3.Multiline = true;
            textTerminologi3.Name = "textTerminologi3";
            textTerminologi3.Size = new Size(247, 257);
            textTerminologi3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 21);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 9;
            label6.Text = "Terminologi 3";
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textAcccrossFee);
            Controls.Add(label5);
            Controls.Add(textTerminologi3);
            Controls.Add(label6);
            Controls.Add(textInhouseFee);
            Controls.Add(label3);
            Controls.Add(textTerminologi2);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(textExchangeRate);
            Controls.Add(label2);
            Controls.Add(textTerminologi1);
            Controls.Add(label1);
            Name = "ConfigPage";
            Size = new Size(876, 491);
            Load += ConfigPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textTerminologi1;
        private Label label2;
        private TextBox textExchangeRate;
        private Button btnUpdate;
        private TextBox textInhouseFee;
        private Label label3;
        private TextBox textTerminologi2;
        private Label label4;
        private TextBox textAcccrossFee;
        private Label label5;
        private TextBox textTerminologi3;
        private Label label6;
    }
}
