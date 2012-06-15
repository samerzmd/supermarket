using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supermarket_system
{
    public partial class Login_form : Telerik.WinControls.UI.ShapedForm
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (username_f.Text.Trim().Equals(null) && password_f.Text.Trim().Equals(null))
            {

            }
            else
            {
                home MD = new home();
                MD.Show();
                this.Hide();
            }
            
        }
    }
}
