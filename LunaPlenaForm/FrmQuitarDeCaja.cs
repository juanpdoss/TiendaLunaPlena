using LunaPlena;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaPlenaForm
{
    public partial class FrmQuitarDeCaja : Form
    {
        public bool quiteEfectivo;

        public FrmQuitarDeCaja()
        {
            InitializeComponent();
            this.cboMarcas.DataSource = Local.ListaMarcas;
            this.cboMarcas.DisplayMember = "nombre";
            bool quiteEfectivo = false;
        }

        private void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cboMarcas.SelectedIndex;

            Marca marcaSeleccionada = Local.RetornaMarca(index);

            this.txtMarcas.Text = marcaSeleccionada.GetInfoEnEfectivo();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            if (this.cboMarcas.SelectedIndex > -1)
            {

               Marca marcaElegida = Local.RetornarMarcaDesdeNombre(this.cboMarcas.Text);


               if(!(this.rdoExtraerTodo.Checked))
               {
                    float monto = (float)this.txtMonto.Value;

                    if (marcaElegida.RetirarEfectivoDeCaja(monto))
                    {
                        Local.RegistrarRetiroEfectivo(marcaElegida, monto);
                        this.quiteEfectivo = true;
                    }

               }
               else
               {
                    marcaElegida.VaciarCajaEfectivo();

               }


                    
            }

        }

      
    }
}
