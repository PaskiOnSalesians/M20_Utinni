using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            pgbSplash.SetState(2);
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

    //Modify ProgressBar Color
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
