using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosTdesRsa
{
    public partial class PantallaRsa : Form
    {
        static String xml = "";
        public PantallaRsa()
        {
            InitializeComponent();
        }

        public void getRSAkeys()
        {
            //Generate a public/private key pair.  
            RSA rsa = RSA.Create();
            //Save the public key information to an RSAParameters structure.  
            RSAParameters rsaKeyInfo = rsa.ExportParameters(true);
            xml = rsa.ToXmlString(true);
            //Console.WriteLine(xml);
            claveTxBox.Text = Convert.ToBase64String(rsaKeyInfo.D);
            clavePubTxBox.Text = Convert.ToBase64String(rsaKeyInfo.Modulus);
        }

        public void encriptarRSA()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(xml);
            byte[] text = Encoding.ASCII.GetBytes(txtDesencriptadoTxBox.Text);
            byte[] result = rsa.Encrypt(text, false);
            txtEncriptadoTxBox.Text = Convert.ToBase64String(result);
        }

        public void decriptRSA()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xml);
            RSAParameters key = rsa.ExportParameters(true);
            byte[] text = Convert.FromBase64String(txtEncriptadoTxBox.Text);
            byte[] resultado = new AlgoritmoRsa().RSADecrypt(text, key, false);
            txtDesencriptadoTxBox.Text = Encoding.Default.GetString(resultado);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEncriptadoTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImportarTxEncrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog save = new OpenFileDialog();
            save.Filter = "Text-File | *.txt";
            string decodedText = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(save.FileName);
                decodedText = text;

                txtEncriptadoTxBox.Text = decodedText;
                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
        }

        private void btnExportarTxEncrip_Click(object sender, EventArgs e)
        {
            ConversorXml export = new ConversorXml();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text-File | *.txt";
            string returnValue = txtEncriptadoTxBox.Text;
            if (save.ShowDialog() == DialogResult.OK)
            {
                export.TextoEncriptadoExportar(save.FileName, returnValue);
            }
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            decriptRSA();
        }

        private void btnGenerarClave_Click(object sender, EventArgs e)
        {
            getRSAkeys();
        }


        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            encriptarRSA();
        }

        private void btnExportarClave_Click(object sender, EventArgs e)
        {
            ConversorXml export = new ConversorXml();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML-File | *.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                export.XmlExportar(save.FileName, export.ClavesTdes(claveTxBox.Text));
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
                String[] data = import.GetClavesRsa(import.XmlImportar(save.FileName));
                xml = data[2];
                claveTxBox.Text = data[1];
                clavePubTxBox.Text = data[0];
            }
        }
    }
}
