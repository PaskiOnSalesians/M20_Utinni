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

        // Accedir al panell de coordenades
        #region Acces al panell de coordenades
        private void btn_admin_coord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Admin_Coords frm = new Frm_Admin_Coords();
            frm.ShowDialog();
        }
        #endregion

        // Accedir al panell de gestio d'usuaris
        #region Acces al panell de gestio d'usuaris
        private void btn_admin_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GestioUsuaris frm = new Frm_GestioUsuaris();
            frm.ShowDialog();
        }
        #endregion

        // Accedir al panell de gestio de dispositius
        #region Acces al panell de gestio de dispositius
        private void btn_admin_devices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_GestioDispositius frm = new Frm_GestioDispositius();
            frm.ShowDialog();
        }
        #endregion
    }
}
