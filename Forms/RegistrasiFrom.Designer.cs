    namespace KoperasiBadBoy.Forms
{
    partial class RegistrasiFrom
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtPassword = new TextBox();
            txtPhoneAlt = new TextBox();
            txtAddress = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtUsername = new TextBox();
            txtReferenceId = new TextBox();
            txtQuest2 = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtCardId = new TextBox();
            txtEmail = new TextBox();
            txtQuest1 = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name ";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 272);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 2;
            label3.Text = "What Artis/Singer\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 272);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "What Fav Color ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 106);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 179);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Email ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 106);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 8;
            label7.Text = "Card ID";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 40);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 7;
            label8.Text = "Username ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(679, 186);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 6;
            label9.Text = "Address";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 179);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 11;
            label10.Text = "Referce Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(670, 47);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 10;
            label11.Text = "Password ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(668, 113);
            label12.Name = "label12";
            label12.Size = new Size(78, 20);
            label12.TabIndex = 9;
            label12.Text = "Phone ALT";
            label12.Click += label12_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(578, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtPhoneAlt
            // 
            txtPhoneAlt.Location = new Point(578, 154);
            txtPhoneAlt.Name = "txtPhoneAlt";
            txtPhoneAlt.Size = new Size(258, 27);
            txtPhoneAlt.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(578, 217);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(258, 117);
            txtAddress.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(299, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(258, 27);
            txtUsername.TabIndex = 25;
            // 
            // txtReferenceId
            // 
            txtReferenceId.Location = new Point(299, 217);
            txtReferenceId.Name = "txtReferenceId";
            txtReferenceId.Size = new Size(258, 27);
            txtReferenceId.TabIndex = 26;
            txtReferenceId.TextChanged += textBox9_TextChanged;
            // 
            // txtQuest2
            // 
            txtQuest2.Location = new Point(299, 307);
            txtQuest2.Name = "txtQuest2";
            txtQuest2.Size = new Size(258, 27);
            txtQuest2.TabIndex = 27;
            txtQuest2.TextChanged += txtArtis_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(299, 154);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(258, 27);
            txtPhone.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 29;
            // 
            // txtCardId
            // 
            txtCardId.Location = new Point(12, 149);
            txtCardId.Name = "txtCardId";
            txtCardId.Size = new Size(258, 27);
            txtCardId.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 27);
            txtEmail.TabIndex = 31;
            // 
            // txtQuest1
            // 
            txtQuest1.Location = new Point(12, 307);
            txtQuest1.Name = "txtQuest1";
            txtQuest1.Size = new Size(258, 27);
            txtQuest1.TabIndex = 32;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 361);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(126, 29);
            btnSubmit.TabIndex = 33;
            btnSubmit.Text = "Subimt";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(155, 361);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 29);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RegistrasiFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(txtQuest1);
            Controls.Add(txtEmail);
            Controls.Add(txtCardId);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(txtQuest2);
            Controls.Add(txtReferenceId);
            Controls.Add(txtUsername);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneAlt);
            Controls.Add(txtPassword);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "RegistrasiFrom";
            Text = "RegistrasiFrom";
            Load += RegistrasiFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtPassword;
        private TextBox txtPhoneAlt;
        private TextBox txtAddress;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtUsername;
        private TextBox txtReferenceId;
        private TextBox txtQuest2;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtCardId;
        private TextBox txtEmail;
        private TextBox txtQuest1;
        private Button btnSubmit;
        private Button btnBack;
    }
}