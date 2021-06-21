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
    public class Producto:IComparable<Producto>
    {
        #region getters y setters 
        private string nombre;
        private float precio;
        private Marca marca;

         
         
        public string Marca
        {
            get
            {
                return this.marca.Nombre;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    this.marca = new Marca(value);     
                }
                else
                {
                    this.marca = new Marca("sin nombre.");
                }
            }

        }

    
         


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
                if(value>0)
                {
                   this.precio = value;
                }
                else
                {
                    this.precio = 0;
                }              
            }
         
        }
        #endregion

        #region constructores

        public Producto()// Constructor por defecto (para que la clase sea serializable).
        {

        }
        public Producto(string nombre, float precio,Marca marca)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.marca = marca;
        }

        #endregion



        /// <summary>
        /// que retorna el atributo marca.
        /// </summary>
        public Marca GetObjetoMarca()
        {

            return this.marca;

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

            if (a.nombre == b.nombre && a.marca == b.marca)
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

        public int CompareTo(Producto other)
        {
            return this.precio.CompareTo(other.precio);
        }


    }
}
