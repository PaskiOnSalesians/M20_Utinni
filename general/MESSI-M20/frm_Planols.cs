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
    public partial class Frm_Planols : Form
    {
        public Frm_Planols()
        {
            InitializeComponent();
        }

        private void btnBlueprints_Click(object sender, EventArgs e)
        {
            if (!pnlBP1.Visible)
            {
                pnlBP1.Visible = true;
                pnlBP2.Visible = true;
                pnlBP3.Visible = true;
            } else
            {
                pnlBP1.Visible = false;
                pnlBP2.Visible = false;
                pnlBP3.Visible = false;
            }
        }

    }
}
