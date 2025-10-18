namespace KoperasiBadBoy.Forms
{
    partial class Terminologi
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
            labelTerminologi1 = new Label();
            labelTerminologi2 = new Label();
            labelTerminologi3 = new Label();
            labelExchange = new Label();
            labelInhouse = new Label();
            labellAccross = new Label();
            SuspendLayout();
            // 
            // labelTerminologi1
            // 
            labelTerminologi1.AutoSize = true;
            labelTerminologi1.Location = new Point(39, 34);
            labelTerminologi1.Name = "labelTerminologi1";
            labelTerminologi1.Size = new Size(26, 25);
            labelTerminologi1.TabIndex = 0;
            labelTerminologi1.Text = "--";
            // 
            // labelTerminologi2
            // 
            labelTerminologi2.AutoSize = true;
            labelTerminologi2.Location = new Point(39, 131);
            labelTerminologi2.Name = "labelTerminologi2";
            labelTerminologi2.Size = new Size(26, 25);
            labelTerminologi2.TabIndex = 1;
            labelTerminologi2.Text = "--";
            // 
            // labelTerminologi3
            // 
            labelTerminologi3.AutoSize = true;
            labelTerminologi3.Location = new Point(39, 231);
            labelTerminologi3.Name = "labelTerminologi3";
            labelTerminologi3.Size = new Size(26, 25);
            labelTerminologi3.TabIndex = 2;
            labelTerminologi3.Text = "--";
            // 
            // labelExchange
            // 
            labelExchange.AutoSize = true;
            labelExchange.Location = new Point(45, 308);
            labelExchange.Name = "labelExchange";
            labelExchange.Size = new Size(130, 25);
            labelExchange.TabIndex = 3;
            labelExchange.Text = "Exchange Rate:";
            // 
            // labelInhouse
            // 
            labelInhouse.AutoSize = true;
            labelInhouse.Location = new Point(303, 308);
            labelInhouse.Name = "labelInhouse";
            labelInhouse.Size = new Size(111, 25);
            labelInhouse.TabIndex = 4;
            labelInhouse.Text = "Inhouse Fee:";
            // 
            // labellAccross
            // 
            labellAccross.AutoSize = true;
            labellAccross.Location = new Point(551, 308);
            labellAccross.Name = "labellAccross";
            labellAccross.Size = new Size(101, 25);
            labellAccross.TabIndex = 5;
            labellAccross.Text = "Across Fee:";
            // 
            // Terminologi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labellAccross);
            Controls.Add(labelInhouse);
            Controls.Add(labelExchange);
            Controls.Add(labelTerminologi3);
            Controls.Add(labelTerminologi2);
            Controls.Add(labelTerminologi1);
            Name = "Terminologi";
            Size = new Size(755, 389);
            Load += Terminologi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTerminologi1;
        private Label labelTerminologi2;
        private Label labelTerminologi3;
        private Label labelExchange;
        private Label labelInhouse;
        private Label labellAccross;
    }
}
