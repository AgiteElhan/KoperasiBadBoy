
namespace KoperasiBadBoy.Forms
{
    partial class LoginForm
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
            Username_Label = new TextBox();
            Password_Label = new TextBox();
            btn_Submit = new Button();
            btn_Registrtion = new Button();
            Reset_Password = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 51);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 101);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 184);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Username_Label
            // 
            Username_Label.Location = new Point(193, 124);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(377, 27);
            Username_Label.TabIndex = 3;
            // 
            // Password_Label
            // 
            Password_Label.Location = new Point(193, 207);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(377, 27);
            Password_Label.TabIndex = 4;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(193, 265);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(94, 29);
            btn_Submit.TabIndex = 5;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Registrtion
            // 
            btn_Registrtion.Location = new Point(463, 265);
            btn_Registrtion.Name = "btn_Registrtion";
            btn_Registrtion.Size = new Size(107, 29);
            btn_Registrtion.TabIndex = 6;
            btn_Registrtion.Text = "Registration";
            btn_Registrtion.UseVisualStyleBackColor = true;
            // 
            // Reset_Password
            // 
            Reset_Password.AutoSize = true;
            Reset_Password.Location = new Point(321, 269);
            Reset_Password.Name = "Reset_Password";
            Reset_Password.Size = new Size(110, 20);
            Reset_Password.TabIndex = 7;
            Reset_Password.TabStop = true;
            Reset_Password.Text = "Reset Password";
            Reset_Password.LinkClicked += Reset_Password_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset_Password);
            Controls.Add(btn_Registrtion);
            Controls.Add(btn_Submit);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Username_Label;
        private TextBox Password_Label;
        private Button btn_Submit;
        private Button btn_Registrtion;
        private LinkLabel Reset_Password;
    }
}