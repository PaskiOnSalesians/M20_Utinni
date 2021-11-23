using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Users
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }
        private void btnLeft1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
