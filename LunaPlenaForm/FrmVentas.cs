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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            this.txtVentas.Text = Local.GetVentasPorMarca();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.txtVentas.Text = "";
            Local.LimpiarVentas();
            this.txtVentas.Text = Local.GetVentasPorMarca();
        }
    }
}
