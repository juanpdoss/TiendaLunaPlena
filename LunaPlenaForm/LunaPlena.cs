using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunaPlena;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace LunaPlenaForm
{
    public partial class LunaPlena : Form
    {
        Thread hiloFiltra;
        public LunaPlena()
        {
            InitializeComponent();  
            Local.ListaProductos = Serializador.ObtenerListaSerializada();
            hiloFiltra = new Thread(this.Filtrar);           
        }
   
        private void LunaPlena_Load(object sender, EventArgs e)
        {
            this.DgProductos.DataSource = Local.listaProductos;                     
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAux = new FrmAlta();

            if(frmAux.ShowDialog() == DialogResult.OK)
            {
                Producto productoNuevo = new Producto(frmAux.GetNombre, frmAux.GetPrecio);
                if (!Local.AgregarProducto(productoNuevo))
                    MessageBox.Show("No se pudo agregar el producto, verifique que el nombre sea univoco.");

            }

            //refresco DataGridView
            this.DgProductos.DataSource = null;
            this.DgProductos.DataSource = Local.ListaProductos;
           
        }
        private void LunaPlena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializador.SerializarListaProductos(Local.ListaProductos);
                 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificacion aux = new FormModificacion();

            DialogResult rta = aux.ShowDialog();

            if (rta == DialogResult.OK)
            {
                int i = this.DgProductos.CurrentCell.RowIndex;

                if (Local.ModificarProductoEnIndice(i, aux.GetNombre, aux.GetPrecio))
                {
                    MessageBox.Show("Modificacion exitosa.");
                }

            }
            else
            {
                MessageBox.Show("Modificacion cancelada.");
            }

        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                int i = this.DgProductos.CurrentCell.RowIndex;
                
                if(i>-1)
                {
                    this.DgProductos.DataSource = null;
                    Local.QuitarProducto(i);
                    this.DgProductos.DataSource = Local.ListaProductos;
                    
                }
               
            }catch(Exception a)
            {
                MessageBox.Show("No se pudo remover el producto." + a.Message);
               
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if(!this.hiloFiltra.IsAlive)
                this.hiloFiltra.Start();

        }


        /// <summary>
        /// Metodo que corre el hilo filtrar, el mismo crea una sublista a partir de la lista de productos si es que el
        /// textBox "txtFiltra" no esta vacio.
        /// </summary>
        private void Filtrar()
        {
            while(true)
            {
                if(!String.IsNullOrEmpty(txtFiltra.Text))
                {
                    if(this.DgProductos.InvokeRequired)
                    {
                        this.DgProductos.BeginInvoke((MethodInvoker)delegate
                        {
                            this.DgProductos.DataSource = Local.FiltrarProductos(txtFiltra.Text);
                        }
                        );
                    }
                }
                else
                {
                    if (this.DgProductos.InvokeRequired)
                    {
                        this.DgProductos.BeginInvoke((MethodInvoker)delegate
                        {
                            this.DgProductos.DataSource = Local.ListaProductos;
                        }
                        );
                    }
                }

                Thread.Sleep(1000);
            }
        }

     
    }
}
