using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosTdesRsa
{
    public partial class PantallaTdes : Form
    {
        AlgoritmoTdes tdes;
        static String xml = "";

        public PantallaTdes()
        {
            InitializeComponent();
        }

        private void btnGenerarClave_Click(object sender, EventArgs e)
        {
            tdes = new AlgoritmoTdes();
            claveTxBox.Text = tdes.generateKeysTDES().ToString();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            tdes = new AlgoritmoTdes();
            txtEncriptadoTxBox.Text = tdes.encript(txtDesencriptadoTxBox.Text, claveTxBox.Text);
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            tdes = new AlgoritmoTdes();
            txtDesencriptadoTxBox.Text = tdes.decript(claveTxBox.Text, txtEncriptadoTxBox.Text);
        }

        private void btnExportarClave_Click(object sender, EventArgs e)
        {
            ConversorXml export = new ConversorXml();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                export.XmlExportar(save.FileName, export.ClavesXmlRsa(xml));
            }
        }

        private void btnExportarTxEncrip_Click(object sender, EventArgs e)
        {
            ConversorXml export = new ConversorXml();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text-File | *.txt";
            string returnValue = txtEncriptadoTxBox.Text;

            byte[] plainTextBytes = System.Text.Encoding.Default.GetBytes(txtEncriptadoTxBox.Text);
            returnValue = System.Convert.ToBase64String(plainTextBytes);

            if (save.ShowDialog() == DialogResult.OK)
            {
                export.TextoEncriptadoExportar(save.FileName, returnValue);
            }

        }

        private void btnImportarClave_Click(object sender, EventArgs e)
        {
            ConversorXml import = new ConversorXml();
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(save.FileName);
                claveTxBox.Text = import.GetClaveTdes(import.XmlImportar(save.FileName));
            }
        }

        private void btnImportarTxEncrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "Text-File | *.txt";
            string decodedText = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(save.FileName);
                byte[] textAsBytes = Convert.FromBase64String(text);
                decodedText = Encoding.UTF8.GetString(textAsBytes);

                txtEncriptadoTxBox.Text = decodedText;
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
        }
    }
}
