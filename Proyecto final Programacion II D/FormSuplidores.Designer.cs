namespace Sulpidores
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarSupli = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblprovincia = new System.Windows.Forms.Label();
            this.lblCargoCont = new System.Windows.Forms.Label();
            this.lblNombreCont = new System.Windows.Forms.Label();
            this.lblNombreBuscSupli = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombreComp = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.txtcargocont = new System.Windows.Forms.TextBox();
            this.txtnombconta = new System.Windows.Forms.TextBox();
            this.txtNombreBuscSupl = new System.Windows.Forms.TextBox();
            this.txtcodigosupl = new System.Windows.Forms.TextBox();
            this.txtnombrecomp = new System.Windows.Forms.TextBox();
            this.dtgvSuplidores = new System.Windows.Forms.DataGridView();
            this.lblCodigoposta = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtCodigopostal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuplidores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(181, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 32);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(76, 406);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 32);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(76, 366);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 32);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarSupli
            // 
            this.btnBuscarSupli.Location = new System.Drawing.Point(467, 16);
            this.btnBuscarSupli.Name = "btnBuscarSupli";
            this.btnBuscarSupli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSupli.TabIndex = 37;
            this.btnBuscarSupli.Text = "Buscar";
            this.btnBuscarSupli.UseVisualStyleBackColor = true;
            this.btnBuscarSupli.Click += new System.EventHandler(this.btnBuscarSupli_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(181, 366);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 32);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(94, 311);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(52, 13);
            this.lbltelefono.TabIndex = 24;
            this.lbltelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(94, 276);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblprovincia
            // 
            this.lblprovincia.AutoSize = true;
            this.lblprovincia.Location = new System.Drawing.Point(95, 244);
            this.lblprovincia.Name = "lblprovincia";
            this.lblprovincia.Size = new System.Drawing.Size(54, 13);
            this.lblprovincia.TabIndex = 22;
            this.lblprovincia.Text = "Provincia:";
            // 
            // lblCargoCont
            // 
            this.lblCargoCont.AutoSize = true;
            this.lblCargoCont.Location = new System.Drawing.Point(49, 204);
            this.lblCargoCont.Name = "lblCargoCont";
            this.lblCargoCont.Size = new System.Drawing.Size(100, 13);
            this.lblCargoCont.TabIndex = 21;
            this.lblCargoCont.Text = "Cargo del contacto:";
            this.lblCargoCont.UseMnemonic = false;
            // 
            // lblNombreCont
            // 
            this.lblNombreCont.AutoSize = true;
            this.lblNombreCont.Location = new System.Drawing.Point(39, 160);
            this.lblNombreCont.Name = "lblNombreCont";
            this.lblNombreCont.Size = new System.Drawing.Size(110, 13);
            this.lblNombreCont.TabIndex = 23;
            this.lblNombreCont.Text = "Nombre del Contacto:";
            // 
            // lblNombreBuscSupli
            // 
            this.lblNombreBuscSupli.AutoSize = true;
            this.lblNombreBuscSupli.Location = new System.Drawing.Point(268, 21);
            this.lblNombreBuscSupli.Name = "lblNombreBuscSupli";
            this.lblNombreBuscSupli.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBuscSupli.TabIndex = 19;
            this.lblNombreBuscSupli.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(106, 69);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 18;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblnombreComp
            // 
            this.lblnombreComp.AutoSize = true;
            this.lblnombreComp.Location = new System.Drawing.Point(26, 101);
            this.lblnombreComp.Name = "lblnombreComp";
            this.lblnombreComp.Size = new System.Drawing.Size(123, 13);
            this.lblnombreComp.TabIndex = 17;
            this.lblnombreComp.Text = "Nombre de la Compañia:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 273);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 29;
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(155, 237);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(100, 20);
            this.txtprovincia.TabIndex = 28;
            // 
            // txtcargocont
            // 
            this.txtcargocont.Location = new System.Drawing.Point(155, 201);
            this.txtcargocont.Name = "txtcargocont";
            this.txtcargocont.Size = new System.Drawing.Size(100, 20);
            this.txtcargocont.TabIndex = 27;
            // 
            // txtnombconta
            // 
            this.txtnombconta.Location = new System.Drawing.Point(155, 146);
            this.txtnombconta.Multiline = true;
            this.txtnombconta.Name = "txtnombconta";
            this.txtnombconta.Size = new System.Drawing.Size(100, 41);
            this.txtnombconta.TabIndex = 26;
            // 
            // txtNombreBuscSupl
            // 
            this.txtNombreBuscSupl.Location = new System.Drawing.Point(321, 18);
            this.txtNombreBuscSupl.Name = "txtNombreBuscSupl";
            this.txtNombreBuscSupl.Size = new System.Drawing.Size(128, 20);
            this.txtNombreBuscSupl.TabIndex = 36;
            // 
            // txtcodigosupl
            // 
            this.txtcodigosupl.Location = new System.Drawing.Point(155, 66);
            this.txtcodigosupl.Name = "txtcodigosupl";
            this.txtcodigosupl.Size = new System.Drawing.Size(100, 20);
            this.txtcodigosupl.TabIndex = 16;
            // 
            // txtnombrecomp
            // 
            this.txtnombrecomp.Location = new System.Drawing.Point(155, 98);
            this.txtnombrecomp.Multiline = true;
            this.txtnombrecomp.Name = "txtnombrecomp";
            this.txtnombrecomp.Size = new System.Drawing.Size(100, 33);
            this.txtnombrecomp.TabIndex = 20;
            // 
            // dtgvSuplidores
            // 
            this.dtgvSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSuplidores.Location = new System.Drawing.Point(261, 63);
            this.dtgvSuplidores.Name = "dtgvSuplidores";
            this.dtgvSuplidores.Size = new System.Drawing.Size(716, 302);
            this.dtgvSuplidores.TabIndex = 15;
            this.dtgvSuplidores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSuplidores_CellContentClick);
            // 
            // lblCodigoposta
            // 
            this.lblCodigoposta.AutoSize = true;
            this.lblCodigoposta.Location = new System.Drawing.Point(73, 340);
            this.lblCodigoposta.Name = "lblCodigoposta";
            this.lblCodigoposta.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoposta.TabIndex = 38;
            this.lblCodigoposta.Text = "Codigo Postal:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(155, 304);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 39;
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.Location = new System.Drawing.Point(154, 337);
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigopostal.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.txtCodigopostal);
            this.Controls.Add(this.lblCodigoposta);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscarSupli);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblprovincia);
            this.Controls.Add(this.lblCargoCont);
            this.Controls.Add(this.lblNombreCont);
            this.Controls.Add(this.lblNombreBuscSupli);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblnombreComp);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtprovincia);
            this.Controls.Add(this.txtcargocont);
            this.Controls.Add(this.txtnombconta);
            this.Controls.Add(this.txtNombreBuscSupl);
            this.Controls.Add(this.txtcodigosupl);
            this.Controls.Add(this.txtnombrecomp);
            this.Controls.Add(this.dtgvSuplidores);
            this.Name = "Form1";
            this.Text = "Control de Suplidores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuplidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarSupli;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblprovincia;
        private System.Windows.Forms.Label lblCargoCont;
        private System.Windows.Forms.Label lblNombreCont;
        private System.Windows.Forms.Label lblNombreBuscSupli;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombreComp;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtprovincia;
        private System.Windows.Forms.TextBox txtcargocont;
        private System.Windows.Forms.TextBox txtnombconta;
        private System.Windows.Forms.TextBox txtNombreBuscSupl;
        private System.Windows.Forms.TextBox txtcodigosupl;
        private System.Windows.Forms.TextBox txtnombrecomp;
        private System.Windows.Forms.DataGridView dtgvSuplidores;
        private System.Windows.Forms.Label lblCodigoposta;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtCodigopostal;
    }
}

