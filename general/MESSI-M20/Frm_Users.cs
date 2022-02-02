﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using AccesDades;

namespace Users
{
    public partial class Frm_Users : Form
    {
        Dades _Dades = new Dades();
        //DataSet dts;

        int intents = 0;
        public Frm_Users()
        {
            InitializeComponent();
        }

        #region Login+Intents
        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            DataSet credentials = _Dades.QueryDB("select * from MessiUsers where Username = '" + txtbox_user.Text + "'");


            if (txtbox_user.Text.Equals(credentials.Tables[0].Rows[0]["Username"]) && txtbox_pass.Text.Equals(credentials.Tables[0].Rows[0]["Password"]))
            {
                this.Hide();
                principal.Show();
            } 
            else
            {
                lbl_number_error.Visible = true;
                lbl_error.Visible = true;
                intents += 1;
                lbl_number_error.Text = Convert.ToString(intents);
            }

            if (intents == 3)
            {
                string path = @"ftp://51.83.97.10\home\utinni\M20\MESSI\Test.txt";

                if (!File.Exists(path))
                {
                    using (StreamWriter StreamW = File.CreateText(path))
                    {
                        StreamW.WriteLine(DateTime.Now.ToString() + ":" + txtbox_user.Text.ToString() + ":" + txtbox_user.Text);
                    }
                }
                else
                {
                    using (StreamWriter StreamW = File.CreateText(path))
                    {
                        StreamW.WriteLine(DateTime.Now.ToString() + ":" + txtbox_user.Text.ToString() + ":" + txtbox_user.Text);
                    }
                }

                Image myimage = new Bitmap(@"ftp://51.83.97.10\home\utinni\M20\MESSI\amenaza.jpg");

                lbl_intents.Visible = true;
                panel1.BackgroundImage = myimage;
                this.BackColor = Color.DarkRed;
                timer1.Enabled = true;
            }
        }

        #endregion

        #region Tancar_App
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        #endregion

        #region Events
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            _Dades.ConnectDB();
        }
        #endregion
    }
}
