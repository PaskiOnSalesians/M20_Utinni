using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MESSI_M20;

namespace Users
{
    public partial class Frm_Users : Form
    {
        int intents = 0;
        public Frm_Users()
        {
            InitializeComponent();
        }

        #region Login+Intents
        private void button1_Click(object sender, EventArgs e)
        {
            Frm_UserMain principal = new Frm_UserMain();
            
            if (txt_box_user.Text == "hola" && textBox2.Text == "hola")
            {
                this.Hide();
                principal.Show();
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
                intents += 1;
                label3.Text = Convert.ToString(intents);
            }

            if (intents == 3)
            {
                string path = @"C:\Users\carsh\OneDrive - INSPECTORIA SALESIANA MARIA AUXILIADORA\Documentos\DAM\S2AM\M20\Test.txt";

                if (!File.Exists(path))
                {
                    using (StreamWriter StreamW = File.CreateText(path))
                    {
                        StreamW.WriteLine(DateTime.Now.ToString() + ":" + txt_box_user.Text.ToString() + ":" + txt_box_user.Text);
                    }
                }
                else
                {
                    using (StreamWriter StreamW = File.CreateText(path))
                    {
                        StreamW.WriteLine(DateTime.Now.ToString() + ":" + txt_box_user.Text.ToString() + ":" + txt_box_user.Text);
                    }
                }

                Image myimage = new Bitmap(@"C:\Users\carsh\OneDrive - INSPECTORIA SALESIANA MARIA AUXILIADORA\Imágenes\app\amenaza.jpg");

                label5.Visible = true;
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
    }
}
