namespace KoperasiBadBoy.Forms.Admin
{
    partial class AccrosPage
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
            dgvCoop = new DataGridView();
            dgvBalance = new DataGridView();
            dgvTransfer = new DataGridView();
            btnRefresh = new Button();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Coop";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Location = new Point(36, 62);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 62;
            dgvCoop.Size = new Size(330, 244);
            dgvCoop.TabIndex = 1;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(372, 62);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 62;
            dgvBalance.Size = new Size(404, 244);
            dgvBalance.TabIndex = 2;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(36, 353);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 62;
            dgvTransfer.Size = new Size(740, 244);
            dgvTransfer.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(345, 614);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 5;
            label2.Text = "Member";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 318);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 7;
            label4.Text = "Transfer";
            // 
            // AccrosPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Controls.Add(label1);
            Name = "AccrosPage";
            Size = new Size(804, 660);
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCoop;
        private DataGridView dgvBalance;
        private DataGridView dgvTransfer;
        private Button btnRefresh;
        private Label label2;
        private Label label4;
    }
}
