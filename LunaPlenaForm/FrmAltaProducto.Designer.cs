
namespace LunaPlenaForm
{
    partial class FrmAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Pink;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Pink;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Pink;
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Pink;
            resources.ApplyResources(this.txtPrecio, "txtPrecio");
            this.txtPrecio.Name = "txtPrecio";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Name = "lblNombre";
            // 
            // lblPrecio
            // 
            resources.ApplyResources(this.lblPrecio, "lblPrecio");
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPrecio.Name = "lblPrecio";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.BackColor = System.Drawing.Color.Pink;
            this.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcas.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMarcas, "cmbMarcas");
            this.cmbMarcas.Name = "cmbMarcas";
            // 
            // lblMarca
            // 
            resources.ApplyResources(this.lblMarca, "lblMarca");
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMarca.Name = "lblMarca";
            // 
            // FrmAlta
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::LunaPlenaForm.Properties.Resources.cinna1;
            this.CancelButton = this.btnCancelar;
            this.ControlBox = false;
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarcas);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label lblMarca;
    }
}