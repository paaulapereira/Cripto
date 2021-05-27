using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgoritmosTdesRsa
{
    //en esa clase estaran almacenadas todas las posibles acciones que seran realizadas con XML
    class ConversorXml
    {
        //ACCION: exportar el XML
        public void XmlExportar(String nombre, XmlDocument xmlExportar)
        {
            XmlDocument documentoExportar = xmlExportar;
            String ubicacion = nombre;
            using (XmlTextWriter escritor = new XmlTextWriter(ubicacion, null))
            {
                escritor.Formatting = Formatting.Indented;
                documentoExportar.Save(escritor); //guarda el documento identado
            }
        }

        //ACCION: importar el XML
        public XmlDocument XmlImportar(String ubicacion)
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(ubicacion);
            Console.WriteLine(documento.ToString());
            //devuelve el documento importado
            return documento;
        }

        //ACCION: exportar el texto encriptado
        public void TextoEncriptadoExportar(String ubicacion, String texto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ubicacion);
                escritor.WriteLine(texto);
                escritor.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        //ACCION: obtener la clave TDES
        public String GetClaveTdes(XmlDocument clave) 
        {
            return clave.InnerText;
        }

        //ACCION: obtener la clave RSA
        public String[] GetClavesRsa(XmlDocument textos)
        {
            //escribe por consola el valor
            Console.WriteLine(textos.DocumentElement.OuterXml);

            String ubicacion = "RSA/clavePrivada";

            //almacena en uno de los nodos conectados el valor que tiene en ubicacion
            XmlNode conexiones = textos.SelectSingleNode(ubicacion);

            Console.WriteLine(conexiones.InnerText);

            XmlDocument nuevoTexto = new XmlDocument();
            nuevoTexto.LoadXml(conexiones.InnerText);

            String ubicacionClaves = "RSAKeyValue";
            XmlNodeList conexionesClave = nuevoTexto.SelectNodes(ubicacionClaves);

            XmlNode conexionPublica = nuevoTexto.SelectSingleNode("RSAKeyValue/Modulus");
            XmlNode conexionPrivada = nuevoTexto.SelectSingleNode("RSAKeyValue/D");
            
            //escribe por consola el camino-direccion
            Console.WriteLine(conexionPublica.InnerText);
            Console.WriteLine(conexionPrivada.InnerText);

            //almacena los datos existentes en cada nodo en un string
            String[] datos = {conexionPublica.InnerText, conexionPrivada.InnerText, conexiones.InnerText };
            return datos;
        }

        //ACCION: transcribir las claves RSA a xml
        public XmlDocument ClavesXmlRsa(String transcrito)
        {
            //se escribe las claves por consola
            Console.WriteLine(transcrito);

            //creando un nuevo xml
            XmlDocument texto = new XmlDocument();
            String nuevoTexto = transcrito;

            nuevoTexto = transcrito;
            Console.WriteLine(nuevoTexto);

            XmlNode textoConexion = texto.CreateXmlDeclaration("1.0", "UTF-8", null);
            texto.AppendChild(textoConexion);

            //se crean los nodos del xml, en el cual se pone la clave y la clave privada
            XmlNode destino = texto.CreateElement("RSA");
            XmlNode clave = texto.CreateElement("clave");
            clave.InnerText = nuevoTexto;
            XmlNode clavePrivada = texto.CreateElement("clavePrivada");
            clavePrivada.InnerText = nuevoTexto;

            //se adjuntan los valores de las claves y el destino al xml
            destino.AppendChild(clave);
            destino.AppendChild(clavePrivada);
            texto.AppendChild(destino);

            //devuelve el texto, que seria el xml con las claves
            return texto;
        }

        //ACCION: obtener las claves Triple DES en el Xml
        public XmlDocument ClavesTdes(String transcrito)
        {
            XmlDocument texto = new XmlDocument();
            XmlNode conexionTexto = texto.CreateXmlDeclaration("1.0", "UTF-8", null);

            texto.AppendChild(conexionTexto);

            //se crean los nodos del xml del Triple DES, en el cual se pone la clave
            XmlNode destino = texto.CreateElement("TDES");
            XmlNode clave = texto.CreateElement("clave");
            destino.InnerText = transcrito;
            //se adjunta el valor de la clave y el destino al xml
            destino.AppendChild(destino);
            texto.AppendChild(destino);
            //devuelve el texto, que seria el xml con la clave
            return texto;
        }

    }
}
