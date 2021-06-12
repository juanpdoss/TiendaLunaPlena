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
    public partial class FrmAlta : Form
    {
        public FrmAlta()
        {
            InitializeComponent();
            this.cmbMarcas.DataSource = Local.listaMarcas;
            this.cmbMarcas.DisplayMember = "nombre";
        }

        /// <summary>
        /// Retorna el string en el txtNombre, en caso de estar vacio retorna "nombre invalido o vacio".
        /// </summary>
        public string GetNombre
        {
            get
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                    return "nombre vacio";
                else
                    return txtNombre.Text;

                
            }
        }

        /// <summary>
        /// Retorna el valor en el TextBox precio, en caso de estar vacio o ser un valor invalido, retorna 0.
        /// </summary>
        public float GetPrecio
        {
            get
            {
                if (String.IsNullOrEmpty(txtPrecio.Text))
                    return 0;
                else
                {
                    float.TryParse(txtPrecio.Text, out float aux);
                    return aux;
                }
                    
            }
        }

        /// <summary>
        /// Si no hay marcas seleccionadas, retorna 0.
        /// </summary>
        public int GetMarca
        {
            get
            {
                if(this.cmbMarcas.SelectedIndex == -1)
                {
                    return 0;
                }
                else
                {
                    return this.cmbMarcas.SelectedIndex;
                }
            }
        }

      
    }
}
