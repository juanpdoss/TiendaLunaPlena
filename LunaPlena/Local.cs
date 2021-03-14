using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaPlena
{
    /// <summary>
    /// Clase estatica local.
    /// </summary>
    public static class Local
    {
        #region atributos, getters y setters
        public static List<Producto> listaProductos;

        /// <summary>
        /// Obtiene y establece la lista de productos del local.
        /// </summary>
       public static List<Producto> ListaProductos
        {
            get
            {
                return Local.listaProductos;
            }
            set
            {              
               Local.listaProductos = value;
                
            }


        }



        #endregion

        #region Constructor
        static Local()
        {
            Local.ListaProductos = new List<Producto>();
        }
        #endregion

        #region metodos
        /// <summary>
        /// Agregar un producto al local.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna true en caso de haber agregado el producto con exito. False caso contrario.</returns>
        public static bool AgregarProducto(Producto producto)
        {
            bool pudeAgregar = false;
            

            if (!(Local.EstaIncluido(producto)))
            {
                Local.listaProductos.Add(producto);
                pudeAgregar = true;
            }

            return pudeAgregar;
        }

        /// <summary>
        /// Retorna el primer producto cuyo nombre coincida con el parametro string "nombre".
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Retorna el producto en caso de exito, o null en caso contrario.</returns>
        public static Producto BuscarProducto(string nombre)
        {
            foreach (Producto item in Local.listaProductos)
            {
                if (item.Nombre == nombre)
                    return item;

            }

            return null;
        }


        /// <summary>
        /// Retorna en formato string la informacion de todos los productos contenidos en el local.
        /// </summary>
        /// <returns></returns>
        public static string LocalToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in Local.listaProductos)
            {
                sb.AppendLine(item.ToString());
            }


            return sb.ToString();
        }

        /// <summary>
        /// Valida si un producto esta (o no) incluido en la lista del local.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>retorna true si el producto esta incluido, false caso contrario.</returns>
        public static bool EstaIncluido(Producto a)
        {
            bool estaIncluido = false; 

            foreach (Producto item in Local.listaProductos)
            {
                if (item == a)
                {
                    estaIncluido = true;
                    break;

                }
                
            }


            return estaIncluido;
        }

        /// <summary>
        /// Remueve un producto del local. (Si este ultimo se encuentra incluido).
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Retorna true en caso de poder remover el producto, false caso contrario.</returns>
        public static bool QuitarProducto(int indice)
        {
            bool pudeQuitar = false;

            if(Local.EstaIncluido(Local.listaProductos.ElementAt(indice)))
            {
                Local.listaProductos.RemoveAt(indice);
                pudeQuitar = true;
            }
            return pudeQuitar;
        }


        /// <summary>
        /// Modifica un producto en el indice recibido como parametro.
        /// Si los parametros son invalidos, no se asignaran.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="nuevoNombre"></param>
        /// <param name="nuevoPrecio"></param>
        /// <returns>Retorna true en caso de modificar con exito, o false en caso contrario.</returns>
        public static bool ModificarProductoEnIndice(int i,string nuevoNombre,float nuevoPrecio)
        {
            bool modifique = false;

            if(!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                Producto aux = Local.listaProductos.ElementAt(i);
                aux.Nombre = nuevoNombre;


                if(nuevoPrecio>0)
                {
                    aux.Precio = nuevoPrecio;
                   //  Local.listaProductos.Insert(i,aux);
                    modifique = true;
                }
            }



            return modifique;
        }


        /// <summary>
        /// Crea una sublista de productos, los mismos coinciden en su campo Nombre con el parametro cadenaAbuscar.
        /// </summary>
        /// <param name="cadenaAbuscar"></param>
        /// <returns></returns>

        public static List<Producto> FiltrarProductos(string cadenaAbuscar)
        {
            List<Producto> aux = new List<Producto>();

            foreach (var item in Local.listaProductos)
            {
                if (item.Nombre.Contains(cadenaAbuscar))
                    aux.Add(item);

            }

            return aux;
        }

        #endregion

    }
}
