using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system.pcat
{
    public partial class cat_management : Form
    {
        public cat_management()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            add_cat add_cat = new add_cat();
            add_cat.ShowDialog();
        }
    }
}
