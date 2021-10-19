using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace MESSI_M20
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
        }

        private Boolean verifyAdmin = false;

        // Timer d'acces al login
        #region Timer
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            pgbSplash.Increment(4);
            Opacity -= 0.020;
            labelSplash.Text = pgbSplash.Value.ToString() + "%";

            if (Opacity == 0.0 && verifyAdmin == false)
            {
                timerSplash.Stop();
                this.Hide();
                Frm_Users frm = new Frm_Users();
                frm.ShowDialog();
            }
        }
        #endregion

        // Tecles rapides d'acces al panell d'administracio
        #region Events de Tecles Rapides
        private void formSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.F2)
            {
                verifyAdmin = true;
                this.Hide();
                Frm_Admin frm = new Frm_Admin();
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
