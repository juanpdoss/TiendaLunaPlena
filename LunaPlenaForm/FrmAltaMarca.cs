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
    public partial class FrmAltaMarca : Form
    {
        public FrmAltaMarca()
        {
            InitializeComponent();
        }


        public string NombreMarca 
        { 
            get
            {

                if(string.IsNullOrEmpty(this.txtNombreMarca.Text))
                {
                    return "nombre vacio.";
                }
                else
                {
                    return this.txtNombreMarca.Text;
                }

            }     
            
        }





    }
}
