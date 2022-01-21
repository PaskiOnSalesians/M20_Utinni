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

namespace MESSI_M20
{
    public partial class Frm_Planols : Form
    {
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
            lblTitle.Text = "Water Gun";
            lblText.Text = "text random de test";
        }

        private void pnlBP1_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
        }

        private void pnlBP2_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.Text = "Water Gun 2";
            lblText.Text = "text random de test";
        }

        private void pnlBP2_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
        }

        private void pnlBP3_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.Text = "test 3";
            lblText.Text = "";
        }

        private void pnlBP3_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblText.Text = "";
        }

        private void Frm_Planols_Load(object sender, EventArgs e)
        {
            string filePath = "..\\MESSI-M20\\Resources\\info.xml";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(filePath, settings);

            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<{0}>", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.Write(reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.Write("<![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.Write("<?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.Write("<!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.Write("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.Write("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.Write(reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</{0}>", reader.Name);
                        break;
                }
            }
        }
    }
}
