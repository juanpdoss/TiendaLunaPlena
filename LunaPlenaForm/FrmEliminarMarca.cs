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

namespace LunaPlenaForm
{
    public partial class FrmEliminarMarca : Form
    {
        public FrmEliminarMarca()
        {
            InitializeComponent();
            this.cboMarcas.DataSource=Local.ListaMarcas;
            this.cboMarcas.DisplayMember = "nombre";
          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.cboMarcas.SelectedIndex >-1)
            {
                Local.EliminarMarca(
                Local.RetornarMarcaDesdeNombre(this.cboMarcas.Text)
                ); 
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index  = this.cboMarcas.SelectedIndex;

            Marca auxiliar = Local.RetornaMarca(index);

            this.txtMarca.Text = auxiliar.ToString();


        }
    }
}
