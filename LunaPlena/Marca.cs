using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaPlena
{
    //Clase que representa las marcas en el local
    public class Marca
    {
        #region atributos y propiedades
        private string nombre;
        private float caja;
        private int cantidadVentas;
       

            
        /// <summary>
        /// retorna atributo cantidad de ventas
        /// </summary>
        public int CantidadVentas
        {
            get
            {
                return this.cantidadVentas;
            }
            set
            {
                if (value > 0)
                    this.cantidadVentas = value;
                else
                    this.cantidadVentas = 0;

            }

        }



        /// <summary>
        /// retorna atributo nombre
        /// </summary>
        public string Nombre 
        { 
            get
            {
                return this.nombre;
            }
                 
           set
           {
                if (!String.IsNullOrEmpty(value))
                    this.nombre = value;
                else
                    this.nombre = "Nombre invalido.";
           }
        }

        /// <summary>
        /// retorna el atributo caja de la marca, en caso de settearle un valor lo acumula.
        /// </summary>

        public float DineroEnCaja
        {
            get
            {
                return this.caja;
            }
            set
            {
                this.caja = value;
            }
        }
        #endregion

        #region constructores
        //Constructor por defecto
        public Marca()
        {

        }

        //Constructor que recibe de parametro el nombre de la marca.
        public Marca(string nombre)
        {
            this.nombre = nombre;
            this.cantidadVentas = 0;
        }
    
        #endregion

        #region metodos

        /// <summary>
        /// Retorna la info de la marca en formato string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dinero en caja: " + this.DineroEnCaja);

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dinero"></param>
        public void SumarEnCaja(float dinero)
        {
            this.caja += dinero;   
        }

        

        #endregion
    }
}
