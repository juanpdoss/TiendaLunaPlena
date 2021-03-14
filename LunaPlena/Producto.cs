using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaPlena
{
    /// <summary>
    /// Clase publica e instaciable Producto. 
    /// </summary>
    public class Producto
    {
        #region getters y setters 
        private string nombre;
        private float precio;

        /// <summary>
        /// Retorna y establece (previa validacion) el atributo nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    this.nombre = "Nombre invalido.";
                else            
                this.nombre = value;
            }
        }

        /// <summary>
        /// Retorna atributo precio
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
         
        }

     

        #endregion

        #region constructores

        public Producto()// Constructor por defecto (para que la clase sea serializable).
        {

        }
        public Producto(string nombre, float precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        #endregion

        /// <summary>
        /// Retorna los datos de un producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Producto: " + this.nombre);
            sb.AppendLine("Precio: " + this.precio);
          
            return sb.ToString();
             
        }

        /// <summary>
        /// Dos productos seran iguales si comparten el nombre.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Producto a,Producto b)
        {
            bool sonIguales = false;

            if (a.nombre == b.nombre)
                sonIguales = true;


            return sonIguales;
        }

        /// <summary>
        /// Dos productos seran distintos si tienen distinto nombre.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Producto a,Producto b)
        {
            return !(a == b);
        }


    }
}
