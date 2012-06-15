using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system.supplier
{
    public partial class supplier_managment : Form
    {
        public supplier_managment()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            add_supplier addSupplier = new add_supplier();
            addSupplier.ShowDialog();
        }
    }
}
