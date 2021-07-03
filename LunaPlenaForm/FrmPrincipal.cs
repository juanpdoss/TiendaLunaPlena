using LunaPlena;
using System;
using System.Windows.Forms;

namespace LunaPlenaForm
{
    public partial class FrmPrincipal : Form
    {
        BindingSource binding;
       
        public FrmPrincipal()
        {
            InitializeComponent();  
            Local.ListaProductos = Serializador.ObtenerListaProductos();
            Local.ListaMarcas = Serializador.ObtenerListaMarcas();
            this.binding = new BindingSource();
         
           
        }
   
        private void LunaPlena_Load(object sender, EventArgs e)
        {
            this.menuPrincipal.Cursor = Cursors.Hand;
            this.btnFiltrar.Cursor = Cursors.Hand;
            this.btnVender.Cursor = Cursors.Hand;
            this.btnOrdenar.Cursor = Cursors.Hand;

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
            }
            else
            {
                MessageBox.Show("No hay marcas en el sistema.");
            }

            this.Actualizar();

        }
        private void LunaPlena_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!(Serializador.SerializarListaMarcas(Local.ListaMarcas)) || !(Serializador.SerializarListaProductos(Local.ListaProductos)))
            {
                MessageBox.Show("Atencion, hubo un error al guardar antes de salir. \nPudo existir una perdida de datos.");
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
                        Local.QuitarProducto(i);                    
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo remover el producto. Revise si tiene seleccionada una linea.");
                }
            }

            this.Actualizar();

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
            if (Local.listaProductos.Count > 0)
            {
                Local.OrdenarAscendente();
            }
            
            this.Actualizar();
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

            this.Actualizar();
        }

        private void btnVenderEfectivo_Click(object sender, EventArgs e)
        {

            if (this.DgProductos.SelectedRows.Count > 0)
            {
                try
                {            
                    DataGridViewRow fila = this.DgProductos.SelectedRows[0];

                    //obtengo los datos de la fila
                    string nombreProducto = fila.Cells[1].Value.ToString();   
                    float valorVendido = (float)fila.Cells[2].Value;
                    Marca marca = Local.RetornarMarcaDesdeNombre(fila.Cells[0].Value.ToString());
                    Local.GenerarInfoVenta(marca, valorVendido, nombreProducto,false);

                    if (!Local.AgregarVentaEfectivo(marca, valorVendido, nombreProducto))
                    {
                        MessageBox.Show("Hubo un error al registrar la venta en texto.");
                    }          
                    else
                    {
                        MessageBox.Show("Venta registrada");
                    }
                                            
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            this.Actualizar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if(Local.ListaMarcas.Count > 0)
            {
                FrmEliminarMarca frmEliminarMarca = new FrmEliminarMarca();
                DialogResult resultadoDialogo=frmEliminarMarca.ShowDialog();

                if(resultadoDialogo == DialogResult.OK)
                {
                    MessageBox.Show("Marca Eliminada");
                }
            }
            else
            {
                MessageBox.Show("No hay marcas en el sistema.");
            }

        }

        private void btnReiniciarCajas_Click(object sender, EventArgs e)
        {

            if(Local.listaMarcas.Count > 0 )
            {
                DialogResult respuesta = MessageBox.Show("Confirma reiniciar las cajas", "Atencion", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    Local.ResetearCajas();
                    this.Actualizar();
                }

            }
            else
            {
                MessageBox.Show("No hay marcas en el sistema.");
            }

         
            
        }

      

        private void btnVenderQR_Click(object sender, EventArgs e)
        {
            if (this.DgProductos.SelectedRows.Count > 0)
            {
                try
                {      
                    DataGridViewRow fila = this.DgProductos.SelectedRows[0];

                    //obtengo los datos de la fila
                    string nombreMarca = fila.Cells[0].Value.ToString();
                    string nombreProducto = fila.Cells[1].Value.ToString();
                    float valorVendido= (float)fila.Cells[2].Value;
                    Marca marca = Local.RetornarMarcaDesdeNombre(nombreMarca);
                    Local.GenerarInfoVenta(marca, valorVendido, nombreProducto,true);

                    if (!Local.AgregarVentaQR(marca, valorVendido, nombreProducto))
                    {
                        MessageBox.Show("Hubo un error al registrar la venta en texto.");
                    }
                    else
                    {
                        MessageBox.Show("Venta registrada");
                    }



                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Actualizar();
            }

           

        }

        private void btnVerInfoVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.ShowDialog();
        }

        private void retirarDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(Local.listaMarcas.Count>0)
            {
                FrmQuitarDeCaja frmQuitarDeCaja = new FrmQuitarDeCaja();
                DialogResult respuestaUsuario = frmQuitarDeCaja.ShowDialog();

                if (respuestaUsuario == DialogResult.OK)
                {
                    if (frmQuitarDeCaja.quiteEfectivo)
                    {
                        MessageBox.Show("Extraccion de dinero registrada.");

                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la extraccion.\nRe ingrese un monto valido.");

                    }

                }

                this.Actualizar();

            }          

        }


        #region metodos propios del formulario
        private void Actualizar()
        {
            this.binding.ResetBindings(true);
            this.DgProductos.Refresh();
            this.txtInfo.Text = Local.ObtenerInfoVentas();
        }
        #endregion
    }
}
