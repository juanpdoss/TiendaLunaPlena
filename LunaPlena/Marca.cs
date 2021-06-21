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
        private float cajaEfectivo;
        private float cajaQR;
        private int cantidadVentas;
        private string informacionVentas;


        /// <summary>
        /// Retorna atributo informacionVentas;
        /// </summary>
        public string InformacionVentas
        {
            get
            {
                return this.informacionVentas;
            }
            set
            {
                this.informacionVentas += value;
            }
        }

        /// <summary>
        /// Retorna el total de una caja, sumando el dinero en efectivo y el dinero en QR.
        /// </summary>
        public float CajaTotal
        {
            get
            {
                return this.cajaQR + this.cajaEfectivo;
            }
            
        }
            
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
        /// retorna el dinero que tiene en QR la marca.
        /// </summary>
        public float DineroQRenCaja
        {
            get
            {
                return this.cajaQR;
            }
            set
            {
                this.cajaQR = value;
                
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
        /// retorna el atributo dinero que tiene en efectivo una marca.
        /// </summary>

        public float DineroEfectivoEnCaja
        {
            get
            {
                return this.cajaEfectivo;
            }
            set
            {
                this.cajaEfectivo = value;
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
        }
    
        #endregion

        #region metodos


        /// <summary>
        ///  Suma el dinero recibido a la caja en efectivo de la marca.
        /// </summary>
        /// <param name="dinero"></param>
        public void SumarEfectivoEnCaja(float dinero)
        {
            if(dinero>0)
            this.cajaEfectivo += dinero;   
        }


        /// <summary>
        /// Suma el dinero recibido a la caja en QR de la marca.
        /// </summary>
        /// <param name="dinero"></param>
        public void SumarQRenCaja(float dinero)
        {
            if(dinero>0)
            {
                this.DineroQRenCaja += dinero;
            }

        }

        /// <summary>
        /// Dos marcas seran iguales si comparten el mismo nombre.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator == (Marca a,Marca b)
        {
            return (a.nombre == b.nombre);
        }

        /// <summary>
        /// Dos marcas seran distintas si no comparten el mismo nombre.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Marca a,Marca b)
        {
            return !(a.nombre == b.nombre);
        }


        /// <summary>
        /// Establece el atributro informacionVentas en una cadena vacia.
        /// </summary>
        public  void LimpiarInformacionVentas()
        {
            this.informacionVentas = "";
            

        }

        /// <summary>
        /// Retorna el nombre, el dinero en caja, y la cantidad de ventas de una marca en formato string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Informacion de la marca");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dinero en caja: {this.CajaTotal}");
            sb.AppendLine($"Ventas realizadas: {this.cantidadVentas}");


            return sb.ToString();
        }


        #endregion
    }
}
