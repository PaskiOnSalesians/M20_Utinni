﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI_M20
{
    public partial class Frm_GestioUsuaris : Form
    {
        public Frm_GestioUsuaris()
        {
            InitializeComponent();
        }

        private void btn_return_apanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminPanel frm = new Frm_AdminPanel();
            frm.ShowDialog();
        }

        private void cmbUsers_TextChanged(object sender, EventArgs e)
        {
            if (cmbUsers.Text.Equals("Oriol"))
            {
                txtMAC.Text = "A1-21-VC-12-41-C2";
                txtHostName.Text = "LAPTOP-Oriol";
            }
            else
            {
                txtMAC.Text = string.Empty;
                txtHostName.Text = string.Empty;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
