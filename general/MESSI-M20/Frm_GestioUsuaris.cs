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
using System.Configuration;

using AccesDades;

namespace MESSI_M20
{
    public partial class Frm_GestioUsuaris : Form
    {
        Dades _Dades = new Dades();
        DataSet dts;

        public Frm_GestioUsuaris()
        {
            InitializeComponent();

            string mac_address;

            mac_address = GetMACBeauty(GetMacAddress().ToString());

            txtbox_mac.Text = mac_address;
            txt_hostname.Text = Environment.MachineName;
        }

        #region Get MAC address
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

        private string[] getUsers()
        {
            dts = new DataSet();

            dts = _Dades.QueryDB("select * from Users", "Users");

            string[] users = new string[dts.Tables[0].Rows.Count];

            for (int i = 0; i < dts.Tables[0].Rows.Count; i++)
            {

                users[i] = dts.Tables[0].Rows[i]["Username"].ToString();
            }

            return users;
        }

        private void btn_return_apanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminPanel frm = new Frm_AdminPanel();
            frm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //ReadAllSettings();
            AddUpdateAppSettings("TrustedUser", cmbox_users.Text);
            //ReadSetting("TrustedUser");
            ReadAllSettings();
        }

        #region App.config
        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        #endregion

        #region Beautiful MAC address
        private static string GetMACBeauty(string address)
        {
            string mac = "";

            for (int i = 0; i < address.Length; i++)
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
        #endregion

        #region Close App
        private void Frm_GestioUsuaris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void Frm_GestioUsuaris_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();

            string[] users = getUsers();

            for (int i = 0; i < users.Length; i++)
            {
                cmbox_users.Items.Add(users[i]);
            }
        }
    }
}
