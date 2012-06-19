using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system.products
{
    public partial class product_management : Form
    {
        public product_management()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            add_product add = new add_product();
            add.ShowDialog();
        }

        private void product_management_Load(object sender, EventArgs e)
        {

        }
    }
}
