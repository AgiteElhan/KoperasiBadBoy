﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiBadBoy.Forms
{
    public partial class Terminologi : UserControl
    {
        private Member? loggedMember;
        public Terminologi(Member? member)
        {
            loggedMember = member;
            InitializeComponent();

        }

        private void Terminologi_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration? configuration = await service.GetConfig();
            if (configuration != null)
            {
                labelTerminologi1.Text = configuration.terminologi1;
                labelTerminologi2.Text = configuration.terminologi2;
                labelTerminologi3.Text = configuration.terminologi3;
                labelExchange.Text += " " + configuration.ExchangeRate.ToString();
                labelInhouse.Text += " " + configuration.transferInhouseFee.ToString();
                labellAccross.Text += " " + configuration.transferAccrossFee.ToString();
            }
        }

        
    }
