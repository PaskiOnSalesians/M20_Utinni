using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesDades;

namespace MESSI_M20
{
    public partial class Frm_GestioDispositius : Form
    {
        Dades _Dades = new Dades();
        DataSet dts = new DataSet();

        bool registered;

        public Frm_GestioDispositius()
        {
            InitializeComponent();
            string mac_address;

            mac_address = GetMacAddress().ToString();

            txt_mac.Text = GetMACBeauty(mac_address);
            txt_hostname.Text = Environment.MachineName; //nom maquina
        }

        #region Get MAC & Make it Beauty
        private static string GetMACBeauty(string address)
        {
            string mac = "";

            for(int i = 0; i < address.Length; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    mac += "-" + address[i];
                }
                else
                {
                    mac += address[i];
                }
            }

            return mac;
        }

        private static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        #endregion

        #region Return button
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminPanel frm = new Frm_AdminPanel();
            frm.ShowDialog();
        }
        #endregion

        #region Close Form
        private void Frm_GestioDispositius_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Hem d'afegir un nou usuari a la base de dades
            if (registered == false)
            {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Hem de borrar un usuari de la base de dades
            if (registered == true)
            {

            }
        }

        private void Frm_GestioDispositius_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();

            dts = _Dades.QueryDB("select Trusted from TrustedDevices where MAC ='" + txt_mac + "' and Hostname ='" + txt_hostname + "'");

            if (dts.Tables[0].Rows[0]["Trusted"].ToString().Equals("True"))
            {
                MessageBox.Show("This device is trusted");
                registered = true;
            }
            else
            {
                MessageBox.Show("This device is not trusted");
                registered = false;
            }
        }
    }
}
