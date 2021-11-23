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
        Dictionary<string, string> codes_coords = new Dictionary<string, string>();
        Font fnt = new Font("Dubai", 12);

        // Patata
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

        // Boto per a generar una taula
        #region Generar taula
        private void btn_generate_Click(object sender, EventArgs e)
        {
            codes_coords.Clear();
            int limit = 20, count;

            verify_generate_button = true;

            HashSet<string> codes_list = new HashSet<string>();
            string[] codes = new string[limit];

            codes_list = Generate_Codes(codes_list, ref limit, codes);

            codes = codes_list.ToArray();

            count = 0;
            for (char i = 'A'; i < 'E'; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (count < limit)
                    {
                        codes_coords.Add((i.ToString() + j.ToString()), codes[count]);
                        count++;
                    }
                }
            }
        }

        private HashSet<string> Generate_Codes(HashSet<string> codes_hash, ref int limit, string[] codes)
        {
            int limit_codis = 20; // limit de codis a generar
            Random rand = new Random();
            int num_random;
            string strng_n_random;

            while (limit_codis > 0)
            {
                num_random = rand.Next(0, 10000);
                strng_n_random = num_random.ToString();
                if (!codes.Contains(strng_n_random))
                {
                    while (strng_n_random.Length < 4)
                    {
                        strng_n_random = "0" + strng_n_random;
                    }
                    codes_hash.Add(strng_n_random);
                    limit_codis--;
                }
            }
            return codes_hash;
        }

        #endregion

        // Boto per a ensenyar la taula
        #region Botó Show
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (verify_generate_button == false)
            {
                MessageBox.Show("Error, no s'han generat les coordenades.", "SITH CONTROLLER: ERROR 02");
            }
            else
            {
                
                foreach (KeyValuePair<string, string> keyValue in codes_coords)
                {
                    Label lbl = new Label();
                    lbl.Font = fnt;
                    lbl.Text = keyValue.Value;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;
                    lbl.Anchor = AnchorStyles.None;
                    table_layout_pnl_coord.Controls.Add(lbl);
                }

                table_layout_pnl_coord.Visible = true;
            }
        }

        #endregion
    }
}
