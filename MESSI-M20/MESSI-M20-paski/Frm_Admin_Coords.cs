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
            int limit = 20, count;
            // string dictionary; // Variable per a debug
            Font fnt = new Font("Dubai", 12);


            verify_generate_button = true;
            
            HashSet<string>codes_list = new HashSet<string>();
            string[] codes = new string[limit];
            
            codes_list = Generate_Codes(codes_list);

            codes = codes_list.ToArray();

            count = 0;
            for(char i = 'A'; i < 'E'; i++)
            {
                for(int j = 1; j < 6; j++)
                {
                    if(count < limit)
                    {
                        codes_coords.Add((i.ToString() + j.ToString()), codes[count]);
                        Label lbl = new Label();
                        lbl.Font = fnt;
                        lbl.Text = codes[count];
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Dock = DockStyle.Fill;
                        lbl.Anchor = AnchorStyles.None;
                        layoutpnl_coord.Controls.Add(lbl);

                        count++;
                    }
                }
            }

            layoutpnl_coord.Visible = true;

            foreach (KeyValuePair<string, string> keyValues in codes_coords)
            {
               
            }
        }

        // Eina per a comprovar el diccionari
        #region Comprovacio de Diccionari [DEBUG]
        /*
        public string DictionaryToString(Dictionary<string, string> dictionary)
        {
            string dictionaryString = "{";
            foreach (KeyValuePair<string, string> keyValues in dictionary)
            {
                dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }*/
        #endregion

        private HashSet<string> Generate_Codes(HashSet<string> codes)
        {
            int limit = 20; // limit de codis a generar
            Random rand = new Random();
            int num_random;
            string strng_n_random;

            while(limit > 0)
            {
                num_random = rand.Next(0, 10000);
                strng_n_random = num_random.ToString();
                if (!codes.Contains(strng_n_random))
                {
                    while (strng_n_random.Length < 4)
                    {
                        strng_n_random = "0" + strng_n_random;
                    }
                    codes.Add(strng_n_random);
                    limit--;
                }
            }
            return codes;
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
        }
        #endregion
    }
}
