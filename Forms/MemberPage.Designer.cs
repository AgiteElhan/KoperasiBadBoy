namespace KoperasiBadBoy.Forms
{
    partial class MemberPage
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
            lbl_member_id = new Label();
            lbl_status = new Label();
            lbl_address = new Label();
            lbl_phone_alt = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_fullname = new Label();
            lbl_card_id = new Label();
            comboBox1 = new ComboBox();
            lbl_update = new Button();
            dataGridView1 = new DataGridView();
            lbl_joindate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_member_id
            // 
            lbl_member_id.AutoSize = true;
            lbl_member_id.Location = new Point(67, 69);
            lbl_member_id.Name = "lbl_member_id";
            lbl_member_id.Size = new Size(84, 20);
            lbl_member_id.TabIndex = 0;
            lbl_member_id.Text = "Member ID";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(67, 581);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(49, 20);
            lbl_status.TabIndex = 2;
            lbl_status.Text = "Status";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(67, 454);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(62, 20);
            lbl_address.TabIndex = 3;
            lbl_address.Text = "Address";
            // 
            // lbl_phone_alt
            // 
            lbl_phone_alt.AutoSize = true;
            lbl_phone_alt.Location = new Point(67, 383);
            lbl_phone_alt.Name = "lbl_phone_alt";
            lbl_phone_alt.Size = new Size(73, 20);
            lbl_phone_alt.TabIndex = 4;
            lbl_phone_alt.Text = "Phone Alt";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(67, 319);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(50, 20);
            lbl_phone.TabIndex = 5;
            lbl_phone.Text = "Phone";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(67, 253);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email";
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.Location = new Point(67, 192);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(76, 20);
            lbl_fullname.TabIndex = 7;
            lbl_fullname.Text = "Full Name";
            // 
            // lbl_card_id
            // 
            lbl_card_id.AutoSize = true;
            lbl_card_id.Location = new Point(67, 133);
            lbl_card_id.Name = "lbl_card_id";
            lbl_card_id.Size = new Size(98, 20);
            lbl_card_id.TabIndex = 8;
            lbl_card_id.Text = "Card ID (KTP)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 604);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 28);
            comboBox1.TabIndex = 9;
            // 
            // lbl_update
            // 
            lbl_update.Location = new Point(67, 667);
            lbl_update.Name = "lbl_update";
            lbl_update.Size = new Size(94, 29);
            lbl_update.TabIndex = 10;
            lbl_update.Text = "Update";
            lbl_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(650, 627);
            dataGridView1.TabIndex = 11;
            // 
            // lbl_joindate
            // 
            lbl_joindate.AutoSize = true;
            lbl_joindate.Location = new Point(66, 530);
            lbl_joindate.Name = "lbl_joindate";
            lbl_joindate.Size = new Size(71, 20);
            lbl_joindate.TabIndex = 12;
            lbl_joindate.Text = "Join Date";
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_joindate);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_update);
            Controls.Add(comboBox1);
            Controls.Add(lbl_card_id);
            Controls.Add(lbl_fullname);
            Controls.Add(lbl_email);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_phone_alt);
            Controls.Add(lbl_address);
            Controls.Add(lbl_status);
            Controls.Add(lbl_member_id);
            Name = "MemberPage";
            Size = new Size(1097, 763);
            Load += MemberPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_member_id;
        private Label lbl_status;
        private Label lbl_address;
        private Label lbl_phone_alt;
        private Label lbl_phone;
        private Label lbl_email;
        private Label lbl_fullname;
        private Label lbl_card_id;
        private ComboBox comboBox1;
        private Button lbl_update;
        private DataGridView dataGridView1;
        private Label lbl_joindate;
    }
}
