using System;
using System.Collections.Generic;
using System.IO;
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
        public static List<Marca> listaMarcas;

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
                    if(value!=null)
                    {
                        Local.listaProductos = value;
                    }
                     
                }


           }

        /// <summary>
        /// Obtiene y establece la lista de marcas del local.
        /// </summary>
        public static List<Marca> ListaMarcas
        {
            get
            {
                return Local.listaMarcas;
            }
            set
            {
                if(value!=null)
                {
                    Local.listaMarcas = value;
                }           
            }
        }
        #endregion

        #region Constructor
        static Local()
        {
            Local.listaProductos = new List<Producto>();
            Local.listaMarcas = new List<Marca>();
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
        public static bool ModificarProductoEnIndice(int i,string nuevoNombre,float precioNuevo)
        {
            bool modifique = true;
            Local.listaProductos.ElementAt(i).Nombre=nuevoNombre;
            Local.listaProductos.ElementAt(i).Precio=precioNuevo;

            if(Local.listaProductos.ElementAt(i).Nombre == "Nombre invalido." || Local.listaProductos.ElementAt(i).Precio == 0)
            {
                modifique = true;
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

        /// <summary>
        /// Ordena los productos de menor a mayor del local utilizando de criterio el precio.
        /// </summary>
        /// <returns></returns>
        public static void OrdenarAscendente()
        {
            Local.ListaProductos.OrderBy(producto=>producto.Precio);   
        }

        /// <summary>
        /// Funcion privada que retorna true si alguna marca en el local ya tiene el nombre recibido por parametro, o false en el caso contrario.
        /// </summary>
        /// <param name="nombreMarca"></param>
        /// <returns></returns>
        
        private static bool ValidarMarcaEnLocal(string nombreMarca)
        {          
           foreach (Marca item in Local.ListaMarcas)
           {
               if(item.Nombre == nombreMarca)
               {
                   return true;
               }

           }
           
            return false;
        }

        /// <summary>
        /// Agrega una marca a la lista de marcas del local, retorna true si logra hacer el alta, false caso contrario.
        /// </summary>
        /// <returns></returns>
        public static bool AgregarMarca(string nombreNuevaMarca)
        {
            bool pudeAgregar = false;
            if (!Local.ValidarMarcaEnLocal(nombreNuevaMarca))
            {
                Marca aux = new Marca(nombreNuevaMarca);
                Local.listaMarcas.Add(aux);
                pudeAgregar = true;
            }
            return pudeAgregar;
        }
        

        /// <summary>
        /// Retorna la marca en el indice especificado
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public static Marca RetornaMarca(int indice)
        {
            if(Local.ListaMarcas.Count > indice && indice > -1)
            {
                  return Local.listaMarcas.ElementAt(indice);
            }
            else
            {
                return new Marca("invalido.");
            }

        }

        /// <summary>
        /// Le suma a la marca recibida por parametro la venta realizada
        /// </summary>
        public static bool AgregarVenta(Marca marca,float valorVendido,string nombreProducto)
        {
            marca.CantidadVentas++;
            marca.SumarEnCaja(valorVendido);
            string informacion = $"Producto: {nombreProducto}, Precio: {valorVendido.ToString()}, Marca: {marca.Nombre}, fecha y hora de la venta: ";
            return Local.GuardarVentaTxt(informacion);
        }


        /// <summary>
        /// retorna la marca cuyo nombre coincida con el string recibido por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Marca RetornarMarcaDesdeNombre(string nombre)
        {
            foreach (Marca item in Local.ListaMarcas)
            {
                if(item.Nombre == nombre)
                {
                    return item;
                }

            }

            return null;
        }


        /// <summary>
        /// Retorna en formato string la informacion de las ventas realizadas hasta el momento
        /// </summary>
        /// <returns></returns>
        public static string ObtenerInfoVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Estado de las marcas");
            sb.AppendLine();
            sb.AppendLine();
            foreach (var item in ListaMarcas)
            {
                sb.AppendLine($"Nombre: {item.Nombre} \ndinero en caja: {item.DineroEnCaja}");
                sb.AppendLine();
            }
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();

            return sb.ToString();
        }

        /// <summary>
        /// Guarda la venta realizada en un archivo de texto.
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        private static bool GuardarVentaTxt(string venta)
        {
            bool pudeGuardar = true;

            string path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path+= "\\infoCajas.txt";

            string fecha = DateTime.Now.ToString();
            venta += fecha;

            try
            {
                using (StreamWriter escritor = new StreamWriter(path, true))
                {
                    escritor.WriteLine(venta);
                }
            }
            catch
            {
                pudeGuardar = false;
            }

            return pudeGuardar;
        }


        /// <summary>
        /// Vuelve a poner las cajas de todas las marcas en 0
        /// </summary>
        public static void ResetearCajas()
        {
            if(Local.listaMarcas.Count > 0)
            {
                foreach (Marca item in Local.listaMarcas)
                {
                    item.DineroEnCaja = 0;
                }
            }
            
        }


        #endregion

    }
}
