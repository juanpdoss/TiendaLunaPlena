
namespace LunaPlenaForm
{
    partial class FrmEliminarMarca
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(12, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 38);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(157, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(12, 31);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(121, 23);
            this.cboMarcas.TabIndex = 2;
            this.cboMarcas.SelectedIndexChanged += new System.EventHandler(this.cboMarcas_SelectedIndexChanged);
            // 
            // lblSeleccioneMarca
            // 
            this.lblSeleccioneMarca.AutoSize = true;
            this.lblSeleccioneMarca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneMarca.Location = new System.Drawing.Point(12, 9);
            this.lblSeleccioneMarca.Name = "lblSeleccioneMarca";
            this.lblSeleccioneMarca.Size = new System.Drawing.Size(152, 16);
            this.lblSeleccioneMarca.TabIndex = 3;
            this.lblSeleccioneMarca.Text = "Seleccione la marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(177, 113);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.Text = "";
            // 
            // FrmEliminarMarca
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(258, 260);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblSeleccioneMarca);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.Label lblSeleccioneMarca;
        private System.Windows.Forms.RichTextBox txtMarca;
    }
}