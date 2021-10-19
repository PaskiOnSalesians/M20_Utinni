using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace MESSI_M20
{
    public partial class Frm_GestioUsuaris : Form
    {
        public Frm_GestioUsuaris()
        {
            InitializeComponent();

            string mac_address;

            mac_address = GetMacAddress().ToString();

            txtMAC.Text = mac_address;
            txtHostName.Text = Environment.MachineName;
        }

        private static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (nic.Description != "VirtualBox Host-Only Ethernet Adapter"))
                {
                    return nic.GetPhysicalAddress();
                }
            }

            return null;
        }

        private void btn_return_apanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminPanel frm = new Frm_AdminPanel();
            frm.ShowDialog();
        }

    }
}
