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

namespace MESSI_M20
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
            ArrayList Code_Nums = new ArrayList() {0,1,2,3,4,5,6,7,8,9};
            Queue Encoded_Keypad = new Queue();
            var rand = new Random();

            while (!Code_Nums.Contains(""))
            {
                if (Code_Nums.Contains(rand.Next(0, 10)))
                {
                    Encoded_Keypad.Enqueue(rand);
                    Code_Nums.Remove(rand);
                }
            }

            SaveArray(Encoded_Keypad);
        }

        private void SaveArray(Queue Keypad)
        {
                        
        }

        private void Frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
