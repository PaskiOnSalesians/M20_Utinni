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
    public partial class Frm_AdminPanel : Form
    {
        public Frm_AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_admin_coord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Admin_Coords frm = new Frm_Admin_Coords();
            frm.ShowDialog();
        }

        private void btn_admin_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GestioUsuaris frm = new Frm_GestioUsuaris();
            frm.ShowDialog();
        }

        private void btn_admin_devices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GestioDispositius frm = new Frm_GestioDispositius();
            frm.ShowDialog();
        }
    }
}
