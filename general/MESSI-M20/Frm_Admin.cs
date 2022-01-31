using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MESSI_M20
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();

            // Iniciem el Keypad
            #region Iniciar el Keypad
            ArrayList Code_Nums = new ArrayList() {0,1,2,3,4,5,6,7,8,9};
            Queue Encoded_Keypad = new Queue();
            Random rand = new Random();
            int random_num;
            int pos;

            while (Code_Nums.Count > 0)
            {
                random_num = rand.Next(0,10);
                if (Code_Nums.Contains(random_num))
                {
                    pos = Code_Nums.LastIndexOf(random_num);
                    Encoded_Keypad.Enqueue(Code_Nums[pos]);
                    Code_Nums.RemoveAt(pos);
                }
            }

            ImprimirCoord();
            ImprimirKeypad(SaveArray(Encoded_Keypad));
            #endregion

            verifyCode();
        }

        // Acces a dades
        #region Acces a dades

        SqlConnection cns;
        SqlDataAdapter adapter;
        DataSet dts;
        string query;

        private void ConnectDB()
        {
            string cadena = "", connexio;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["MESSIServer"];

            if (settings != null)
            {
                cadena = settings.ConnectionString.ToString();
            }

            connexio = cadena;

            cns = new SqlConnection(connexio);
            cns.Open();
        }

        private void QueryDB(string query)
        {
            adapter = new SqlDataAdapter(query, cns);

            dts = new DataSet();
            adapter.Fill(dts, "AdminCoordinates");
        }

        #endregion

        #region Comprovar codi

        private void verifyCode()
        {
            ConnectDB();
            QueryDB("select DictValue from AdminCoordinates where DictKey = '" + lbl_coord.Text + "'");

            if (dts.Tables[0].Rows[0].Equals(txt_box_code.Text))
            {
                this.Hide();
                Frm_AdminPanel frm = new Frm_AdminPanel();
                frm.ShowDialog();
                cns.Close();
            }
            
        }

        #endregion

        // Funcions relacionades amb les Coordenades
        #region Imprimir Coords
        private void ImprimirCoord()
        {
            ArrayList coords = new ArrayList();
            Random coord_random = new Random();
            int pos_coord_r;
            string coord;

            for (char c = 'A'; c < 'E'; c++)
            {
                for(int j = 1; j < 6; j++)
                {
                    coord = c + j.ToString();
                    coords.Add(coord);
                }
            }

            pos_coord_r = coord_random.Next(0, coords.Count);
            lbl_coord.Text = coords[pos_coord_r].ToString();
        }

        #endregion

        // Tancament de l'aplicacio
        #region Tancar_App

        // Tancar l'app si tanquem al finestra

        private void Frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // Funcions relacionades amb el Keypad
        #region Keypad

        // Guardem la cua a un arraylist

        #region Assignar l'ordre de la cua a un arraylist
        private ArrayList SaveArray(Queue Keypad)
        {
            ArrayList Encoded_Keys = new ArrayList();

            while (Keypad.Count > 0)
            {
                Encoded_Keys.Add(Keypad.Peek());
                Keypad.Dequeue();
            }
            return Encoded_Keys;
        }

        #endregion

        // Li posem nom a les tecles

        #region Imprimir Keypad
        private void ImprimirKeypad(ArrayList Encoded_Keypad)
        {
            int pos = 0;
            while(pos < 10)
            {
                switch (pos)
                {
                    case 0:
                        btn_1.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 1:
                        btn_2.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 2:
                        btn_3.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 3:
                        btn_4.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 4:
                        btn_5.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 5:
                        btn_6.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 6:
                        btn_7.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 7:
                        btn_8.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 8:
                        btn_9.Text = Encoded_Keypad[pos].ToString();
                        break;
                    case 9:
                        btn_10.Text = Encoded_Keypad[pos].ToString();
                        break;
                }
                pos++;
            }
        }

        #endregion

        // Botons de borrar y login

        #region Botons de borrar codi y login

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_box_code.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_box_code.Text.ToString() == "1234")
            {
                this.Hide();
                Frm_AdminPanel frm = new Frm_AdminPanel();
                frm.ShowDialog();
            }
        }

        #endregion

        // Botons Keypad

        #region Assignar nums dels botons

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_1.Text;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_2.Text;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_3.Text;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_4.Text;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_5.Text;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_6.Text;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_7.Text;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_8.Text;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (FullTextBox() == false)
            {
                txt_box_code.Text += btn_9.Text;
            }
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            if(FullTextBox() == false)
            {
                txt_box_code.Text += btn_10.Text;
            }
        }

        #endregion

        // Verificar si TextBox on surt la contrasenya esta ple

        #region Verificacio i limit del codi d'acces
        private Boolean FullTextBox()
        {
            if(txt_box_code.TextLength < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #endregion
    }
}
