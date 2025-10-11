namespace KoperasiBadBoy.Forms
{
    partial class ForgotPasswordForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtUsername = new TextBox();
            TxtFavColor = new TextBox();
            TxtFavArtist = new TextBox();
            TxtPassword = new TextBox();
            BtnSubmit = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 116);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "What is Your Fav Color?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 116);
            label3.Name = "label3";
            label3.Size = new Size(248, 25);
            label3.TabIndex = 2;
            label3.Text = "Who is Your Fav Artist/singer?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 301);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(224, 224, 224);
            TxtUsername.Location = new Point(52, 64);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(314, 31);
            TxtUsername.TabIndex = 4;
            // 
            // TxtFavColor
            // 
            TxtFavColor.BackColor = Color.FromArgb(224, 224, 224);
            TxtFavColor.Location = new Point(52, 158);
            TxtFavColor.Name = "TxtFavColor";
            TxtFavColor.Size = new Size(314, 31);
            TxtFavColor.TabIndex = 5;
            // 
            // TxtFavArtist
            // 
            TxtFavArtist.BackColor = Color.FromArgb(224, 224, 224);
            TxtFavArtist.Location = new Point(410, 158);
            TxtFavArtist.Name = "TxtFavArtist";
            TxtFavArtist.Size = new Size(340, 31);
            TxtFavArtist.TabIndex = 6;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(224, 224, 224);
            TxtPassword.Location = new Point(66, 348);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(394, 31);
            TxtPassword.TabIndex = 7;
            // 
            // BtnSubmit
            // 
            BtnSubmit.BackColor = Color.Lime;
            BtnSubmit.Location = new Point(52, 220);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(112, 34);
            BtnSubmit.TabIndex = 8;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = false;
            BtnSubmit.Click += this.BtnSubmit_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Red;
            BtnBack.Location = new Point(197, 220);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(112, 34);
            BtnBack.TabIndex = 9;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(BtnSubmit);
            Controls.Add(TxtPassword);
            Controls.Add(TxtFavArtist);
            Controls.Add(TxtFavColor);
            Controls.Add(TxtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtUsername;
        private TextBox TxtFavColor;
        private TextBox TxtFavArtist;
        private TextBox TxtPassword;
        private Button BtnSubmit;
        private Button BtnBack;
    }
}