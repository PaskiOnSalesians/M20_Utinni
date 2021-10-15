using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
