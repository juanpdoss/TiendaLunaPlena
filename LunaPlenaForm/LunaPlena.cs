using LunaPlena;
using System;
using System.Windows.Forms;

namespace LunaPlenaForm
{
    public partial class LunaPlena : Form
    {
        BindingSource binding;
       

        public LunaPlena()
        {
            InitializeComponent();  
            Local.ListaProductos = Serializador.ObtenerListaProductos();
            Local.ListaMarcas = Serializador.ObtenerListaMarcas();
            this.binding = new BindingSource();
           
        }
   
        private void LunaPlena_Load(object sender, EventArgs e)
        {
            this.binding.DataSource = Local.listaProductos;
            this.DgProductos.DataSource = this.binding;
            this.txtInfo.Text = Local.ObtenerInfoVentas();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            if(Local.listaMarcas.Count > 0)
            {
                FrmAlta frmAux = new FrmAlta();

                if (frmAux.ShowDialog() == DialogResult.OK)
                {
                    Marca auxMarca = Local.RetornaMarca(frmAux.GetMarca);
                    Producto productoNuevo = new Producto(frmAux.GetNombre, frmAux.GetPrecio, auxMarca);
                    if (!Local.AgregarProducto(productoNuevo))
                        MessageBox.Show("No se pudo agregar el producto, verifique que el nombre sea univoco.");

                }

                this.txtInfo.Text = Local.ObtenerInfoVentas();

            }
            else
            {
                MessageBox.Show("No hay marcas en el sistema.");
            }

        }
        private void LunaPlena_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializador.SerializarListaProductos(Local.ListaProductos);
            if (!Serializador.SerializarListaMarcas(Local.ListaMarcas))
            {
                MessageBox.Show("Atencion, hubo un error al guardar las marcas antes de salir.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if(Local.listaProductos.Count > 0)
            {
                FrmModificacion aux = new FrmModificacion();

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

         

        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if(Local.listaProductos.Count > 0)
            {
                try
                {
                    int i = this.DgProductos.CurrentCell.RowIndex;
                    if (i > -1)
                    {
                        this.DgProductos.DataSource = null;
                        Local.QuitarProducto(i);                    
                    }

                }
                catch
                {
                    MessageBox.Show("No se pudo remover el producto. Revise si tiene seleccionada una linea.");

                }
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Buscar")
            {
                if (Local.listaProductos.Count > 0)
                {
                    string datos = this.txtFiltra.Text;
                    if (!String.IsNullOrEmpty(datos))
                    {                    
                        //this.DgProductos.DataSource = null;
                        this.DgProductos.DataSource = Local.FiltrarProductos(datos);
                        ((Button)sender).Text = "Finalizar";
                    }
                }          
            }
            else
            {                
                this.DgProductos.DataSource = this.binding;
                ((Button)sender).Text = "Buscar";
            }

        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(Local.listaProductos.Count > 0)
            {
               Local.OrdenarAscendente();
            }
        
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAltaMarca aux = new FrmAltaMarca();
            DialogResult respuestaUsuario = aux.ShowDialog();

            if (respuestaUsuario == DialogResult.OK)
            {
                if (!Local.AgregarMarca(aux.NombreMarca))
                {
                    MessageBox.Show("No se pudo ingresar la marca.\n revise que el nombre sea univoco.", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            if (this.DgProductos.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila = this.DgProductos.SelectedRows[0];

                    //obtengo los datos de la fila
                    string nombreProducto = fila.Cells[0].Value.ToString();   
                    float valorVendido = (float)fila.Cells[1].Value;
                    Marca marca = Local.RetornarMarcaDesdeNombre(fila.Cells[2].Value.ToString());
                    if(marca != null && valorVendido != 0)
                    {
                        if (!Local.AgregarVenta(marca, valorVendido, nombreProducto))
                            MessageBox.Show("Hubo un error al registrar la venta en texto.");
                    }   
                    else
                    {
                        MessageBox.Show("Marca o precio invalidos.");
                    }
                    

                    this.txtInfo.Text = Local.ObtenerInfoVentas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }



        }

        private void btnConfigurarMarcas_Click(object sender, EventArgs e)
        {

            if(Local.listaMarcas.Count > 0)
            {
                FrmEliminarMarca form = new FrmEliminarMarca();

                DialogResult respuesta = form.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    MessageBox.Show("Marca eliminada.");

                }

            }

        }

        private void btnReiniciarCajas_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirma reiniciar las cajas", "Atencion", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                Local.ResetearCajas();
                this.txtInfo.Text = Local.ObtenerInfoVentas();
            }
        }

      
    }
}
