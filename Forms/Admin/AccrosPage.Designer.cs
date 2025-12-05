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
            label1.Location = new Point(29, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Coop";
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Location = new Point(29, 50);
            dgvCoop.Margin = new Padding(2, 2, 2, 2);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 62;
            dgvCoop.Size = new Size(264, 195);
            dgvCoop.TabIndex = 1;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(298, 50);
            dgvBalance.Margin = new Padding(2, 2, 2, 2);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 62;
            dgvBalance.Size = new Size(323, 195);
            dgvBalance.TabIndex = 2;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(29, 282);
            dgvTransfer.Margin = new Padding(2, 2, 2, 2);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 62;
            dgvTransfer.Size = new Size(592, 195);
            dgvTransfer.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(276, 491);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 27);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Member";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 254);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Transfer";
            // 
            // AccrosPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AccrosPage";
            Size = new Size(643, 528);
            Load += AccrosPage_Load;
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
