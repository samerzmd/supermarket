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
    public partial class sell_products : Form
    {
        public sell_products()
        {
            InitializeComponent();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX2_Click(object sender, EventArgs e)
        {
            products_search search = new products_search();
            search.ShowDialog();
        }


    }
}
