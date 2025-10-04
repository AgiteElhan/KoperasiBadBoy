﻿using KoperasiBadBoy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiBadBoy.Forms
{
    public partial class AdminForm : Form
    {
        Member? loggedMember = null;

        public AdminForm()
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Brave Hero Cooperation (Administrator: " +
                        loggedMember.MemberId + " - " + loggedMember.FullName + ")";
        }

        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));

        }

        private void accesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AccessPage(loggedMember));
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }

        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ApprovalPage(loggedMember));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                loggedMember = null;
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigPage());

        }

        private void accrosCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new AcrossPage());

        }
    }
}
