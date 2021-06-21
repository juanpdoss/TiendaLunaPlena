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
        private static string rutaArchivoProductos;
        private static string rutaArchivoMarcas;
        #endregion

        #region constructor

        /// <summary>
        /// El constructor tiene la ruta de archivo donde se guardara el xml.
        /// </summary>
        static Serializador()
        {
            Serializador.rutaArchivoProductos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Serializador.rutaArchivoProductos += "\\productosXml";

            Serializador.rutaArchivoMarcas = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Serializador.rutaArchivoMarcas += "\\marcasXml";      
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
                using (xmlTextWriter = new XmlTextWriter(Serializador.rutaArchivoProductos, Encoding.UTF8))
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
        public static List<Producto> ObtenerListaProductos()
        {
            List<Producto> listaProductos=new List<Producto>();
            XmlTextReader xmlTextReader; //Objeto que lee desde un archivo xml
            XmlSerializer xmlSerializer; //Objeto que deserealizada.

            //Si el archivo no existe retorno null.
            if (!File.Exists(Serializador.rutaArchivoProductos))
                return listaProductos;

            using (xmlTextReader = new XmlTextReader(Serializador.rutaArchivoProductos))
            {
                xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                listaProductos = (List<Producto>)xmlSerializer.Deserialize(xmlTextReader);

            }

            

            return listaProductos;
        }

        /// <summary>
        /// Serializada la lista de marcas
        /// </summary>
        /// <param name="listaMarcas"></param>
        public static bool SerializarListaMarcas(List<Marca> listaMarcas)
        {
            bool pudeSerializar = true;
            XmlSerializer serializer; //Objeto que serializa en Xml.
            XmlTextWriter xmlTextWriter; //Objeto que escribe el archivo Xml.

            try
            {
                using (xmlTextWriter = new XmlTextWriter(Serializador.rutaArchivoMarcas, Encoding.UTF8))
                {
                    serializer = new XmlSerializer(typeof(List<Marca>));
                    serializer.Serialize(xmlTextWriter, listaMarcas);
                }

            }
            catch
            {
                pudeSerializar = false;
            }


            return pudeSerializar;

        }


        public static List<Marca> ObtenerListaMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            XmlTextReader xmlTextReader; //Objeto que lee desde un archivo xml
            XmlSerializer xmlSerializer; //Objeto que deserealiza.

            //Si el archivo no existe retorno null.
            if (!File.Exists(Serializador.rutaArchivoMarcas))
                return listaMarcas;

            using (xmlTextReader = new XmlTextReader(Serializador.rutaArchivoMarcas))
            {
                xmlSerializer = new XmlSerializer(typeof(List<Marca>));
                listaMarcas = (List<Marca>)xmlSerializer.Deserialize(xmlTextReader);

            }

            return listaMarcas;

        }



    }
}
