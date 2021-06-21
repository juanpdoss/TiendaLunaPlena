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
        private static string pathInfoCajastxt;

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
            Local.pathInfoCajastxt= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathInfoCajastxt+= "\\infoCajas.txt";
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
            Local.ListaProductos.Sort();   
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
        /// Carga en la marca recibida por parametros los detalles de la venta realizada.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="valorVendido"></param>
        /// <param name="nombreProducto"></param>

        public static void GenerarInfoVenta(Marca marca,float valorVendido,string nombreProducto,bool usaQr)
        {
            string informacionParaMarca = $"Producto: {nombreProducto}, vendido por {valorVendido} pesos, pago realizado ";
            if (usaQr)
            {
                informacionParaMarca += "por qr.\n";
               
            }
            else
            {
                informacionParaMarca += "en efectivo\n";
            }
            
            marca.InformacionVentas = informacionParaMarca;

        }


        /// <summary>
        /// Agrega una venta en efectivo a la marca.
        /// </summary>
        public static bool AgregarVentaEfectivo(Marca marca,float valorVendido,string nombreProducto)
        {
            marca.CantidadVentas++;
            marca.SumarEfectivoEnCaja(valorVendido);
            string informacionTxt = $"Producto: {nombreProducto}, Precio: {valorVendido.ToString()}, Marca: {marca.Nombre}, fecha y hora de la venta: ";
            return Local.GuardarVentaTxt(informacionTxt,marca);
        }


        /// <summary>
        /// Agrega una venta QR a la marca.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="nombreProducto"></param>
        /// <returns></returns>
        public static bool AgregarVentaQR(Marca marca,float valorVendido,string nombreProducto)
        {
            marca.CantidadVentas++;
            marca.SumarQRenCaja(valorVendido); 
            string informacionTxt = $"Producto: {nombreProducto}\n, Pago por qr:{valorVendido.ToString()} , Marca: {marca.Nombre}, fecha y hora de la venta: ";
            return Local.GuardarVentaTxt(informacionTxt,marca);
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
            sb.AppendLine("Estado de las marcas\n");                  
            foreach (var item in ListaMarcas)
            {
                sb.AppendLine($"Marca: {item.Nombre} \nDinero en efectivo: {item.DineroEfectivoEnCaja}\nDinero QR: {item.DineroQRenCaja}\nTotal en caja: {item.CajaTotal} \nConcreto {item.CantidadVentas} ventas.\n");
                sb.AppendLine();
            }
                  
            return sb.ToString();
        }

        /// <summary>
        /// Guarda la venta realizada en un archivo de texto y en el atributo informacionVentas de la marca recibida por parametro.
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        private static bool GuardarVentaTxt(string venta,Marca marca)
        {
            bool pudeGuardar = true;

            string path = Local.pathInfoCajastxt;
            

            string fecha = DateTime.Now.ToString();
            venta += fecha;


            try
            {
                using (StreamWriter escritor = new StreamWriter(path, true))
                {
                    escritor.WriteLine(venta);
                    escritor.WriteLine();
                }
            }
            catch
            {
                pudeGuardar = false;
            }

            return pudeGuardar;
        }


        /// <summary>
        /// Retorna en formato string la informacion de las  ventas de todas las marcas
        /// </summary>
        /// <returns></returns>
        public static string GetVentasPorMarca()
        {
            StringBuilder sb = new StringBuilder();
            string fechaDehoy = DateTime.Now.ToString("MM/dd/yyyy");
            sb.AppendLine("Luna Plena, jornada del dia " + fechaDehoy);
            sb.AppendLine();

            foreach (var item in Local.listaMarcas)
            {
                sb.AppendLine("Marca - " + item.Nombre);

                if(item.InformacionVentas == "")
                {
                    sb.AppendLine("Sin ventas hasta el momento.");
                }
                else
                {
                   sb.AppendLine(item.InformacionVentas);
                }
               
                sb.AppendLine();

            }

            sb.AppendLine("Pare reestablecer esta informacion es necesario reiniciar las cajas.");

            return sb.ToString();
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
                    item.DineroEfectivoEnCaja = 0;
                    item.DineroQRenCaja = 0;
                    item.LimpiarInformacionVentas();
                }
            }  
        }


        /// <summary>
        /// Elimina del Local todas los productos que sean de la marca recibida por parametro.
        /// </summary>
        /// <param name="marca"></param>
        public static void EliminarMarca(Marca marca)
        {                 
           Local.ListaMarcas.Remove(marca);
        }

        #endregion

    }
}
