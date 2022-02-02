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

            controlDispositius();

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
            dts = new DataSet();

            dts = _Dades.QueryDB("select * from TrustedDevices", "TrustedDevices");

            if (registered == false)
            {
                DataRow dr = dts.Tables[0].NewRow();
                dr["idUser"] = dts.Tables[0].Rows.Count+1;
                dr["MAC"] = GetMacAddress().ToString();
                dr["Hostname"] = txt_hostname.Text;
                dr["Trusted"] = "true";
                dts.Tables[0].Rows.Add(dr);

                _Dades.UpdateDB("select * from TrustedDevices","TrustedDevices", dts);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (registered == true)
            {
                _Dades.DeleteDB("delete from TrustedDevices where MAC='"+ GetMacAddress().ToString() + "' and Hostname ='" + txt_hostname.Text + "'" , "TrustedDevices", dts);
            }
        }

        private void Frm_GestioDispositius_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
        }

        private void controlDispositius()
        {
            dts = _Dades.QueryDB("select Trusted from TrustedDevices where MAC ='" + txt_mac + "' and Hostname ='" + txt_hostname + "'", "TrustedDevices");

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                int i = 0;

                if (dts.Tables[0].Rows[i]["Trusted"].ToString().Equals("1"))
                {
                    MessageBox.Show("This device is trusted");
                    registered = true;
                }
                else
                {
                    MessageBox.Show("This device is not trusted");
                    registered = false;
                }

                i++;
            }
        }
    }
}
