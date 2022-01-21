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
    public partial class Frm_UserMain : Form
    {
        public Frm_UserMain()
        {
            InitializeComponent();
        }

        private void btnBlueprintsUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Planols frm = new Frm_Planols();
            frm.ShowDialog();
        }
    }
}
