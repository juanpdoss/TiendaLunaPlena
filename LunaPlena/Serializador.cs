using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LunaPlena
{
    public static class Serializador
    {
        #region atributos y propiedades
        private static string rutaArchivo;

        /// <summary>
        /// Retorna la ruta donde se encuentra el archivo xml.
        /// </summary>
        static public string Ruta 
        { 
            get
            {
                return Serializador.rutaArchivo;
            }
        }
        #endregion

        #region constructor

        /// <summary>
        /// El constructor tiene la ruta de archivo donde se guardara el xml.
        /// </summary>
        static Serializador()
        {
            Serializador.rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Serializador.rutaArchivo+= "\\productosXml";
        }


        #endregion


        /// <summary>
        /// Metodo encargado de serializar la lista de productos en xml.
        /// </summary>
        /// <param name="productos"></param>
        /// <returns>retorna true si el proceso de serializado fue exitoso, false en caso contrario.</returns>
        public static bool SerializarListaProductos(List<Producto> productos)
        {
            bool serializado = true;
            XmlSerializer serializer; //Objeto que serializa en Xml.
            XmlTextWriter xmlTextWriter; //Objeto que escribe el archivo Xml.
            
            try
            {
                using (xmlTextWriter = new XmlTextWriter(Serializador.rutaArchivo, Encoding.UTF8))
                {
                    serializer = new XmlSerializer(typeof(List<Producto>));
                    serializer.Serialize(xmlTextWriter, productos);
                }

            }catch
            {
                serializado = false;

            }
            return serializado;
        }

        /// <summary>
        /// Obtiene una lista de productos a partir de un archivo Xml.
        /// </summary>
        /// <returns>Retorna la lista de productos o null en caso de error.</returns>
        public static List<Producto> ObtenerListaSerializada()
        {
            List<Producto> listaProductos=null;
            XmlTextReader xmlTextReader; //Objeto que lee desde un archivo xml
            XmlSerializer xmlSerializer; //Objeto que deserealizada.

            //Si el archivo no existe retorno null.
            if (!File.Exists(Serializador.rutaArchivo))
                return Local.listaProductos;

            using (xmlTextReader = new XmlTextReader(Serializador.rutaArchivo))
            {
                xmlSerializer = new XmlSerializer(typeof(List<Producto>));

                listaProductos =(List<Producto>)xmlSerializer.Deserialize(xmlTextReader);

            }


            return listaProductos;
        }



    }
}
