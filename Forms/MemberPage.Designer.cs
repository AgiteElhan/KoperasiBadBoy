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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cmb_box_status = new ComboBox();
            btn_update = new Button();
            dataGridView1 = new DataGridView();
            lbl_member_id = new Label();
            lbl_update = new Label();
            lbl_address = new Label();
            lbl_phone_alt = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_join_date = new Label();
            lbl_full_name = new Label();
            lbl_card_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Member Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Card Id (KTP)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 153);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 205);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Join Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 255);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 304);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 6;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 355);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 7;
            label7.Text = "Phone Alt";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 407);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 457);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 9;
            label9.Text = "Status";
            // 
            // cmb_box_status
            // 
            cmb_box_status.FormattingEnabled = true;
            cmb_box_status.Location = new Point(32, 480);
            cmb_box_status.Name = "cmb_box_status";
            cmb_box_status.Size = new Size(258, 28);
            cmb_box_status.TabIndex = 11;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(32, 514);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(620, 516);
            dataGridView1.TabIndex = 13;
            // 
            // lbl_member_id
            // 
            lbl_member_id.AutoSize = true;
            lbl_member_id.Location = new Point(170, 46);
            lbl_member_id.Name = "lbl_member_id";
            lbl_member_id.Size = new Size(18, 20);
            lbl_member_id.TabIndex = 14;
            lbl_member_id.Text = "...";
            // 
            // lbl_update
            // 
            lbl_update.AutoSize = true;
            lbl_update.Location = new Point(170, 518);
            lbl_update.Name = "lbl_update";
            lbl_update.Size = new Size(18, 20);
            lbl_update.TabIndex = 15;
            lbl_update.Text = "...";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(170, 407);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(18, 20);
            lbl_address.TabIndex = 16;
            lbl_address.Text = "...";
            // 
            // lbl_phone_alt
            // 
            lbl_phone_alt.AutoSize = true;
            lbl_phone_alt.Location = new Point(170, 355);
            lbl_phone_alt.Name = "lbl_phone_alt";
            lbl_phone_alt.Size = new Size(18, 20);
            lbl_phone_alt.TabIndex = 17;
            lbl_phone_alt.Text = "...";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(170, 304);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(18, 20);
            lbl_phone.TabIndex = 18;
            lbl_phone.Text = "...";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(170, 255);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(18, 20);
            lbl_email.TabIndex = 19;
            lbl_email.Text = "...";
            // 
            // lbl_join_date
            // 
            lbl_join_date.AutoSize = true;
            lbl_join_date.Location = new Point(170, 205);
            lbl_join_date.Name = "lbl_join_date";
            lbl_join_date.Size = new Size(18, 20);
            lbl_join_date.TabIndex = 20;
            lbl_join_date.Text = "...";
            lbl_join_date.Click += label16_Click;
            // 
            // lbl_full_name
            // 
            lbl_full_name.AutoSize = true;
            lbl_full_name.Location = new Point(170, 153);
            lbl_full_name.Name = "lbl_full_name";
            lbl_full_name.Size = new Size(18, 20);
            lbl_full_name.TabIndex = 21;
            lbl_full_name.Text = "...";
            // 
            // lbl_card_id
            // 
            lbl_card_id.AutoSize = true;
            lbl_card_id.Location = new Point(170, 99);
            lbl_card_id.Name = "lbl_card_id";
            lbl_card_id.Size = new Size(18, 20);
            lbl_card_id.TabIndex = 22;
            lbl_card_id.Text = "...";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_card_id);
            Controls.Add(lbl_full_name);
            Controls.Add(lbl_join_date);
            Controls.Add(lbl_email);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_phone_alt);
            Controls.Add(lbl_address);
            Controls.Add(lbl_update);
            Controls.Add(lbl_member_id);
            Controls.Add(dataGridView1);
            Controls.Add(btn_update);
            Controls.Add(cmb_box_status);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Size = new Size(983, 614);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cmb_box_status;
        private Button btn_update;
        private DataGridView dataGridView1;
        private Label lbl_member_id;
        private Label lbl_update;
        private Label lbl_address;
        private Label lbl_phone_alt;
        private Label lbl_phone;
        private Label lbl_email;
        private Label lbl_join_date;
        private Label lbl_full_name;
        private Label lbl_card_id;
    }
}
