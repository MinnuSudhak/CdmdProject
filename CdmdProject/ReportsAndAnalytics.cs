﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdmdProject
{
    public partial class ReportsAndAnalytics : Form
    {
        public ReportsAndAnalytics()
        {
            InitializeComponent();
        }

        private void ReportsAndAnalytics_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();
        }
    }
}
