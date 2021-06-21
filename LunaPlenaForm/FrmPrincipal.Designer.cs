
namespace LunaPlenaForm
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltra = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVenderQR = new System.Windows.Forms.Button();
            this.btnVerInfoVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgProductos
            // 
            this.DgProductos.AllowUserToAddRows = false;
            this.DgProductos.AllowUserToDeleteRows = false;
            this.DgProductos.AllowUserToResizeRows = false;
            this.DgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgProductos.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgProductos.Location = new System.Drawing.Point(405, 96);
            this.DgProductos.MultiSelect = false;
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.ReadOnly = true;
            this.DgProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgProductos.RowTemplate.Height = 25;
            this.DgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProductos.Size = new System.Drawing.Size(582, 464);
            this.DgProductos.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Thistle;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.Location = new System.Drawing.Point(754, 578);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 31);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltra
            // 
            this.txtFiltra.Location = new System.Drawing.Point(874, 578);
            this.txtFiltra.Name = "txtFiltra";
            this.txtFiltra.Size = new System.Drawing.Size(113, 23);
            this.txtFiltra.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Thistle;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenar.Location = new System.Drawing.Point(634, 47);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(114, 43);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar ";
            this.btnOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Thistle;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(874, 47);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(113, 43);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVenderEfectivo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Thistle;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfo.Location = new System.Drawing.Point(0, 96);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(387, 464);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Text = "";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Thistle;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(995, 28);
            this.menuPrincipal.TabIndex = 13;
            this.menuPrincipal.Text = "menu ";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.quitarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.agregarProductoToolStripMenuItem.Text = "Agregar producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // quitarProductoToolStripMenuItem
            // 
            this.quitarProductoToolStripMenuItem.Name = "quitarProductoToolStripMenuItem";
            this.quitarProductoToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.quitarProductoToolStripMenuItem.Text = "Quitar producto";
            this.quitarProductoToolStripMenuItem.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem,
            this.reiniciarCajasToolStripMenuItem});
            this.marcasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // agregarMarcaToolStripMenuItem
            // 
            this.agregarMarcaToolStripMenuItem.Name = "agregarMarcaToolStripMenuItem";
            this.agregarMarcaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.agregarMarcaToolStripMenuItem.Text = "Agregar marca";
            this.agregarMarcaToolStripMenuItem.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar marca";
            this.eliminarMarcaToolStripMenuItem.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // reiniciarCajasToolStripMenuItem
            // 
            this.reiniciarCajasToolStripMenuItem.Name = "reiniciarCajasToolStripMenuItem";
            this.reiniciarCajasToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.reiniciarCajasToolStripMenuItem.Text = "Reiniciar cajas";
            this.reiniciarCajasToolStripMenuItem.Click += new System.EventHandler(this.btnReiniciarCajas_Click);
            // 
            // btnVenderQR
            // 
            this.btnVenderQR.BackColor = System.Drawing.Color.Thistle;
            this.btnVenderQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenderQR.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderQR.Location = new System.Drawing.Point(754, 47);
            this.btnVenderQR.Name = "btnVenderQR";
            this.btnVenderQR.Size = new System.Drawing.Size(113, 43);
            this.btnVenderQR.TabIndex = 14;
            this.btnVenderQR.Text = "Vender QR";
            this.btnVenderQR.UseVisualStyleBackColor = false;
            this.btnVenderQR.Click += new System.EventHandler(this.btnVenderQR_Click);
            // 
            // btnVerInfoVentas
            // 
            this.btnVerInfoVentas.BackColor = System.Drawing.Color.Thistle;
            this.btnVerInfoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerInfoVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerInfoVentas.Location = new System.Drawing.Point(514, 47);
            this.btnVerInfoVentas.Name = "btnVerInfoVentas";
            this.btnVerInfoVentas.Size = new System.Drawing.Size(114, 43);
            this.btnVerInfoVentas.TabIndex = 15;
            this.btnVerInfoVentas.Text = "Ver ventas";
            this.btnVerInfoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerInfoVentas.UseVisualStyleBackColor = false;
            this.btnVerInfoVentas.Click += new System.EventHandler(this.btnVerInfoVentas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 638);
            this.Controls.Add(this.btnVerInfoVentas);
            this.Controls.Add(this.btnVenderQR);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtFiltra);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.menuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luna plena";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LunaPlena_FormClosing);
            this.Load += new System.EventHandler(this.LunaPlena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltra;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarCajasToolStripMenuItem;
        private System.Windows.Forms.Button btnVenderQR;
        private System.Windows.Forms.Button btnVerInfoVentas;
    }
}

