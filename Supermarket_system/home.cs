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
    public partial class home : DevComponents.DotNetBar.Office2007RibbonForm
    {

        public home()
        {
            InitializeComponent();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            sys_user childForm = new sys_user();
            childForm.MdiParent = this;
            childForm.Show();
            
            
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form lg = new Login_form();
            lg.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            sys_settings setting = new sys_settings();
            setting.MdiParent = this;
            setting.Show();
        }

        private void buttonItem34_Click(object sender, EventArgs e)
        {
            supplier.supplier_managment childForm = new supplier.supplier_managment();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void buttonItem35_Click(object sender, EventArgs e)
        {
            customer.customers_management childForm = new customer.customers_management();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void buttonItem43_Click(object sender, EventArgs e)
        {
            customer.customers_clasification_management childForm = new customer.customers_clasification_management();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void buttonItem36_Click(object sender, EventArgs e)
        {
            pcat.cat_management cm = new pcat.cat_management();
            cm.MdiParent = this;
            cm.Show();

        }

        private void buttonItem39_Click(object sender, EventArgs e)
        {
            products.buy_products buy_pro = new products.buy_products();
            buy_pro.Show();
        }

        private void buttonItem37_Click(object sender, EventArgs e)
        {
            products.product_management pm = new products.product_management();
            pm.MdiParent = this;
            pm.Show();
        }

        private void buttonItem38_Click(object sender, EventArgs e)
        {
            products.sell_products sp = new products.sell_products();
            sp.MdiParent = this;
            sp.Show();
        }

        private void buttonItem40_Click(object sender, EventArgs e)
        {
            invoices.supplier_invoices si = new invoices.supplier_invoices();
            si.MdiParent = this;
            si.Show();
        }

        private void buttonItem41_Click(object sender, EventArgs e)
        {
            invoices.customers_invoices ci = new invoices.customers_invoices();
            ci.MdiParent = this;
            ci.Show();
        }

        private void buttonItem44_Click(object sender, EventArgs e)
        {
            debit.customer_debit cd = new debit.customer_debit();
            cd.MdiParent = this;
            cd.Show();
        }

        private void buttonItem45_Click(object sender, EventArgs e)
        {
            debit.supplier_debit sd = new debit.supplier_debit();
            sd.MdiParent = this;
            sd.Show();
        }
      
    }
}
