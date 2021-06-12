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
            this.cboMarcas.DataSource = Local.listaMarcas;
            this.cboMarcas.DisplayMember = "nombre";

            this.txtMarca.Text = Local.RetornaMarca(this.cboMarcas.SelectedIndex).ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(this.cboMarcas.SelectedIndex > -1)
            {
                int index = this.cboMarcas.SelectedIndex;
                Local.listaMarcas.RemoveAt(index);

            }
            else
            {
                MessageBox.Show("Error, no hay marcas en el sistema.");
                this.Close();
            }

    
        }

        private void cboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMarca.Text = Local.RetornaMarca(this.cboMarcas.SelectedIndex).ToString();
        }
    }
}
