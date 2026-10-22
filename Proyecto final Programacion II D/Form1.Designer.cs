namespace Proyecto_final_Programacion_II_D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.txtnombreProd = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtTipoProd = new System.Windows.Forms.TextBox();
            this.lblnombreProd = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbltipoProd = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.lblubicacion = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtexistenca = new System.Windows.Forms.TextBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblestatus = new System.Windows.Forms.Label();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreBusc = new System.Windows.Forms.TextBox();
            this.lblNombreBusc = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Location = new System.Drawing.Point(278, 88);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.Size = new System.Drawing.Size(716, 302);
            this.dtgvProductos.TabIndex = 0;
            this.dtgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellContentClick);
            // 
            // txtnombreProd
            // 
            this.txtnombreProd.Location = new System.Drawing.Point(124, 120);
            this.txtnombreProd.Multiline = true;
            this.txtnombreProd.Name = "txtnombreProd";
            this.txtnombreProd.Size = new System.Drawing.Size(100, 33);
            this.txtnombreProd.TabIndex = 2;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(124, 88);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtTipoProd
            // 
            this.txtTipoProd.Location = new System.Drawing.Point(124, 168);
            this.txtTipoProd.Multiline = true;
            this.txtTipoProd.Name = "txtTipoProd";
            this.txtTipoProd.Size = new System.Drawing.Size(100, 41);
            this.txtTipoProd.TabIndex = 3;
            // 
            // lblnombreProd
            // 
            this.lblnombreProd.AutoSize = true;
            this.lblnombreProd.Location = new System.Drawing.Point(71, 123);
            this.lblnombreProd.Name = "lblnombreProd";
            this.lblnombreProd.Size = new System.Drawing.Size(47, 13);
            this.lblnombreProd.TabIndex = 2;
            this.lblnombreProd.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(75, 91);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lbltipoProd
            // 
            this.lbltipoProd.AutoSize = true;
            this.lbltipoProd.Location = new System.Drawing.Point(26, 171);
            this.lbltipoProd.Name = "lbltipoProd";
            this.lbltipoProd.Size = new System.Drawing.Size(92, 13);
            this.lbltipoProd.TabIndex = 2;
            this.lbltipoProd.Text = "Tipo de Producto:";
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(124, 223);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(100, 20);
            this.txtubicacion.TabIndex = 4;
            // 
            // lblubicacion
            // 
            this.lblubicacion.AutoSize = true;
            this.lblubicacion.Location = new System.Drawing.Point(60, 226);
            this.lblubicacion.Name = "lblubicacion";
            this.lblubicacion.Size = new System.Drawing.Size(58, 13);
            this.lblubicacion.TabIndex = 2;
            this.lblubicacion.Text = "Ubicacion:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(124, 259);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 5;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(78, 262);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(40, 13);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio:";
            // 
            // txtexistenca
            // 
            this.txtexistenca.Location = new System.Drawing.Point(124, 295);
            this.txtexistenca.Name = "txtexistenca";
            this.txtexistenca.Size = new System.Drawing.Size(100, 20);
            this.txtexistenca.TabIndex = 6;
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(60, 298);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(58, 13);
            this.lblexistencia.TabIndex = 2;
            this.lblexistencia.Text = "Existencia:";
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Location = new System.Drawing.Point(73, 333);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(45, 13);
            this.lblestatus.TabIndex = 2;
            this.lblestatus.Text = "Estatus:";
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEstatus.Location = new System.Drawing.Point(124, 330);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(53, 21);
            this.cmbEstatus.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(45, 379);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(73, 32);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 379);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 32);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(278, 410);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 32);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(381, 410);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 32);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(577, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreBusc
            // 
            this.txtNombreBusc.Location = new System.Drawing.Point(431, 43);
            this.txtNombreBusc.Name = "txtNombreBusc";
            this.txtNombreBusc.Size = new System.Drawing.Size(128, 20);
            this.txtNombreBusc.TabIndex = 13;
            // 
            // lblNombreBusc
            // 
            this.lblNombreBusc.AutoSize = true;
            this.lblNombreBusc.Location = new System.Drawing.Point(378, 46);
            this.lblNombreBusc.Name = "lblNombreBusc";
            this.lblNombreBusc.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBusc.TabIndex = 2;
            this.lblNombreBusc.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(91, 427);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 494);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbEstatus);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblubicacion);
            this.Controls.Add(this.lbltipoProd);
            this.Controls.Add(this.lblNombreBusc);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblnombreProd);
            this.Controls.Add(this.txtexistenca);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.txtTipoProd);
            this.Controls.Add(this.txtNombreBusc);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombreProd);
            this.Controls.Add(this.dtgvProductos);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Registro de productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.TextBox txtnombreProd;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtTipoProd;
        private System.Windows.Forms.Label lblnombreProd;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbltipoProd;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.Label lblubicacion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtexistenca;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreBusc;
        private System.Windows.Forms.Label lblNombreBusc;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

