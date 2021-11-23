using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MESSI_M20
{
    public partial class Frm_Admin_Coords : Form
    {
        private bool verify_generate_button = false, imprimir = true;
        Dictionary<string, string> codes_coords = new Dictionary<string, string>();
        Font fnt = new Font("Dubai", 12);

        //bool verify = true;

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
        /*
        // Connexió a Base de Dades
        #region Connexió a Base de Dades

        // Variables de connexió
        #region Variables Connexió DB

        SqlConnection cns;
        SqlDataAdapter adapter;
        DataSet dts;
        string query;

        #endregion

        // Funcions Bàsiques
        #region Funcions Bàsiques

        // Funció de connexió
        private void ConnectDB()
        {
            string connexio;
            connexio = "Data Source=WHITEWOLF\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";

            cns = new SqlConnection(connexio);
        }

        // Consulta a Base de Dades
        private void QueryDB()
        {
            query = "select * from AdminCoordinates";
            adapter = new SqlDataAdapter(query, cns);

            cns.Open();
            dts = new DataSet();
            adapter.Fill(dts, "AdminCoordinates");
            cns.Close();
        }

        // Funció per actualitzar la DB
        private void UpdateDB()
        {
            int sol;

            cns.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, cns);

            SqlCommandBuilder Cmd = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                sol = adapter.Update(dts.Tables[0]);
                MessageBox.Show("S'han modificat: " + sol.ToString() + " registres.");
            }

            cns.Close();
            QueryDB();
        }

        #endregion

        #endregion
        */

        // Boto per a generar una taula
        #region Generar taula
        private void btn_generate_Click(object sender, EventArgs e)
        {
            table_layout_pnl_coord.Hide();
            table_layout_pnl_coord.Controls.Clear();
            codes_coords.Clear();
            int limit = 20, count, rowCount;

            verify_generate_button = true;
            imprimir = true;

            HashSet<string> codes_list = new HashSet<string>();
            string[] codes = new string[limit];

            codes_list = Generate_Codes(codes_list, ref limit, codes);

            codes = codes_list.ToArray();

            Label lbl_main = new Label();
            lbl_main.Font = fnt;
            lbl_main.Text = "";
            lbl_main.TextAlign = ContentAlignment.MiddleCenter;
            lbl_main.Dock = DockStyle.Fill;
            lbl_main.Anchor = AnchorStyles.None;
            table_layout_pnl_coord.Controls.Add(lbl_main, 0, 0);

            rowCount = 1;
            count = 0;
            for (char i = 'A'; i < 'E'; i++)
            {
                Label lbl_char = new Label();
                lbl_char.Font = fnt;
                lbl_char.Text = i.ToString();
                lbl_char.TextAlign = ContentAlignment.MiddleCenter;
                lbl_char.Dock = DockStyle.Fill;
                lbl_char.Anchor = AnchorStyles.None;
                table_layout_pnl_coord.Controls.Add(lbl_char, 0, rowCount);

                rowCount++;

                for (int j = 1; j < 6; j++)
                {
                    if (imprimir)
                    {
                        Label lbl_num = new Label();
                        lbl_num.Font = fnt;
                        lbl_num.Text = j.ToString();
                        lbl_num.TextAlign = ContentAlignment.MiddleCenter;
                        lbl_num.Dock = DockStyle.Fill;
                        lbl_num.Anchor = AnchorStyles.None;
                        table_layout_pnl_coord.Controls.Add(lbl_num, j, 0);
                    }
                    if (count < limit)
                    {
                        codes_coords.Add((i.ToString() + j.ToString()), codes[count]);
                        count++;
                    }
                }

                imprimir = false;
            }
            /*
            if (verify)
            {
                foreach (KeyValuePair<string, string> keyValue in codes_coords)
                {
                    DataRow DataR = dts.Tables[0].NewRow();
                    DataR["DictKey"] = codes_coords.Keys;
                    DataR["DictValue"] = codes_coords.Values;
                    dts.Tables[0].Rows.Add(DataR);
                }
            }*/

            //UpdateDB();
            //QueryDB();

            //verify = false;

            
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
