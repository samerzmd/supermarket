﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system
{
    public partial class sys_user : Form
    {
        public sys_user()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            add_sys_user add = new add_sys_user();
            add.ShowDialog();
        }


    }
}
