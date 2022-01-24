using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MESSI_M20
{
    public partial class Frm_Planols : Form
    {
        List<string> DetailsTitles = new List<string>();
        List<string> TextDetails = new List<string>();
        List<string> ImageDetails = new List<string>();
        string ResourcesPath = "..\\MESSI-M20\\Resources\\StarKiller\\";


        public Frm_Planols()
        {
            InitializeComponent();
        }

        private void btnBlueprints_Click(object sender, EventArgs e)
        {
            if (!pnlBP1.Visible)
            {
                pnlBP1.Visible = true;
                pnlBP2.Visible = true;
                pnlBP3.Visible = true;
            } else
            {
                pnlBP1.Visible = false;
                pnlBP2.Visible = false;
                pnlBP3.Visible = false;
            }
        }

        private void pnlBP1_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[0];
            lblText.Text = TextDetails[0];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[0]);
        }

        private void pnlBP1_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
            picBlueprints.Visible = false;
        }

        private void pnlBP2_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[1];
            lblText.Text = TextDetails[1];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[1]);
        }

        private void pnlBP2_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
            picBlueprints.Visible = false;
        }

        private void pnlBP3_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.Text = DetailsTitles[2];
            lblText.Text = TextDetails[2];
            picBlueprints.Visible = true;
            picBlueprints.Image = Image.FromFile(ResourcesPath + ImageDetails[2]);
        }

        private void pnlBP3_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
            picBlueprints.Visible = false;
        }

        private void Frm_Planols_Load(object sender, EventArgs e)
        {
            string XMLfilePath = "..\\MESSI-M20\\Resources\\info.xml";

            XElement blueprints = XElement.Load(XMLfilePath);

            foreach (XElement n in blueprints.Descendants("title").Take(3))
            {
                DetailsTitles.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("textDetail").Take(3))
            {
                TextDetails.Add(n.Value);
            }

            foreach (XElement n in blueprints.Descendants("imageDetail").Take(3))
            {
                ImageDetails.Add(n.Value);
            }
        }

        private void btnSpaceShip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SpaceShips frm = new Frm_SpaceShips();
            frm.ShowDialog();
        }
    }
}
