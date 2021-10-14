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
    public partial class Frm_Admin_Coords : Form
    {
        private Boolean verify_generate_button = false;
        Dictionary<string, int> codes_coords = new Dictionary<string, int>();
        public Frm_Admin_Coords()
        {
            InitializeComponent();
        }

        // Boto retorn panell admin
        #region Tornar al Panell d'administracio
        private void btn_return_apanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminPanel frm = new Frm_AdminPanel();
            frm.ShowDialog();
        }
        #endregion

        private void btn_generate_Click(object sender, EventArgs e)
        {
            verify_generate_button = true;
            codes_list;

            for(int i = 'A'; i < 'E'; i++)
            {
                for(int j = 1; j < 6; j++)
                {
                    codes_coords.Add((i+j).ToString(), codes_list[]);
                }
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (verify_generate_button == false)
            {
                MessageBox.Show("Error, no s'han generat les coordenades.", "SITH CONTROLLER ERROR 02");
            }
        }
    }
}
