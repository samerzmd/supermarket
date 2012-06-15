using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system.customer
{
    public partial class customers_clasification_management : Form
    {
        public customers_clasification_management()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            add_cat addCat = new add_cat();
            addCat.ShowDialog();
        }
    }
}
