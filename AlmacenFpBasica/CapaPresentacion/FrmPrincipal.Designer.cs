namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnVaciarZonaAdmin = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVaciarAñadirProducto = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSubCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.pcbEmpresa = new System.Windows.Forms.PictureBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAñadirCategoria = new System.Windows.Forms.TextBox();
            this.cboTipoAñadirCategoria = new System.Windows.Forms.ComboBox();
            this.btnVaciarCategoria = new System.Windows.Forms.Button();
            this.btnAñadirCategoria = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAñadirSubCategoria = new System.Windows.Forms.TextBox();
            this.btnVaciarSubCategoria = new System.Windows.Forms.Button();
            this.btnAñadirSubCategoria = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCatAñadirSubCategoria = new System.Windows.Forms.ComboBox();
            this.grbAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmpresa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbAdmin.Controls.Add(this.btnVaciarZonaAdmin);
            this.grbAdmin.Controls.Add(this.btnAcceder);
            this.grbAdmin.Controls.Add(this.lblPassword);
            this.grbAdmin.Controls.Add(this.txtContrasena);
            this.grbAdmin.Controls.Add(this.txtUsuario);
            this.grbAdmin.Controls.Add(this.txtUser);
            this.grbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.Location = new System.Drawing.Point(1118, 370);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(208, 156);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Zona Administrador";
            this.grbAdmin.Enter += new System.EventHandler(this.grbAdmin_Enter);
            // 
            // btnVaciarZonaAdmin
            // 
            this.btnVaciarZonaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVaciarZonaAdmin.Location = new System.Drawing.Point(105, 117);
            this.btnVaciarZonaAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnVaciarZonaAdmin.Name = "btnVaciarZonaAdmin";
            this.btnVaciarZonaAdmin.Size = new System.Drawing.Size(86, 27);
            this.btnVaciarZonaAdmin.TabIndex = 14;
            this.btnVaciarZonaAdmin.Text = "Vaciar";
            this.btnVaciarZonaAdmin.UseVisualStyleBackColor = true;
            this.btnVaciarZonaAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAcceder.Location = new System.Drawing.Point(11, 117);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(86, 27);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(11, 87);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(179, 24);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(6, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(50, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(9, 44);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 24);
            this.txtUser.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(779, 499);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 27);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVaciarAñadirProducto);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSubCat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.cboCat);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(892, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(208, 469);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Producto";
            // 
            // btnVaciarAñadirProducto
            // 
            this.btnVaciarAñadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVaciarAñadirProducto.Location = new System.Drawing.Point(105, 430);
            this.btnVaciarAñadirProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnVaciarAñadirProducto.Name = "btnVaciarAñadirProducto";
            this.btnVaciarAñadirProducto.Size = new System.Drawing.Size(86, 27);
            this.btnVaciarAñadirProducto.TabIndex = 13;
            this.btnVaciarAñadirProducto.Text = "&Vaciar";
            this.btnVaciarAñadirProducto.UseVisualStyleBackColor = true;
            this.btnVaciarAñadirProducto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAnadir.Location = new System.Drawing.Point(15, 430);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(86, 27);
            this.btnAnadir.TabIndex = 12;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(15, 283);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(176, 141);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sub Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // cboSubCat
            // 
            this.cboSubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboSubCat.FormattingEnabled = true;
            this.cboSubCat.Location = new System.Drawing.Point(15, 135);
            this.cboSubCat.Margin = new System.Windows.Forms.Padding(2);
            this.cboSubCat.Name = "cboSubCat";
            this.cboSubCat.Size = new System.Drawing.Size(176, 21);
            this.cboSubCat.TabIndex = 5;
            this.cboSubCat.SelectedIndexChanged += new System.EventHandler(this.cboSubCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrecio.Location = new System.Drawing.Point(15, 229);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCantidad.Location = new System.Drawing.Point(15, 184);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(176, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // cboCat
            // 
            this.cboCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(15, 88);
            this.cboCat.Margin = new System.Windows.Forms.Padding(2);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(176, 21);
            this.cboCat.TabIndex = 1;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(15, 43);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(176, 21);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVerProductos.Location = new System.Drawing.Point(374, 499);
            this.btnVerProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(94, 27);
            this.btnVerProductos.TabIndex = 13;
            this.btnVerProductos.Text = "&Ver productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbEmpresa
            // 
            this.pcbEmpresa.Location = new System.Drawing.Point(30, 66);
            this.pcbEmpresa.Name = "pcbEmpresa";
            this.pcbEmpresa.Size = new System.Drawing.Size(835, 415);
            this.pcbEmpresa.TabIndex = 17;
            this.pcbEmpresa.TabStop = false;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(302, 17);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(258, 33);
            this.lblNombreEmpresa.TabIndex = 19;
            this.lblNombreEmpresa.Text = "Nombre Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAñadirCategoria);
            this.groupBox2.Controls.Add(this.cboTipoAñadirCategoria);
            this.groupBox2.Controls.Add(this.btnVaciarCategoria);
            this.groupBox2.Controls.Add(this.btnAñadirCategoria);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1118, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(208, 149);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo";
            // 
            // txtAñadirCategoria
            // 
            this.txtAñadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAñadirCategoria.Location = new System.Drawing.Point(14, 81);
            this.txtAñadirCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñadirCategoria.Name = "txtAñadirCategoria";
            this.txtAñadirCategoria.Size = new System.Drawing.Size(176, 20);
            this.txtAñadirCategoria.TabIndex = 14;
            // 
            // cboTipoAñadirCategoria
            // 
            this.cboTipoAñadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboTipoAñadirCategoria.FormattingEnabled = true;
            this.cboTipoAñadirCategoria.Location = new System.Drawing.Point(14, 43);
            this.cboTipoAñadirCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoAñadirCategoria.Name = "cboTipoAñadirCategoria";
            this.cboTipoAñadirCategoria.Size = new System.Drawing.Size(176, 21);
            this.cboTipoAñadirCategoria.TabIndex = 14;
            // 
            // btnVaciarCategoria
            // 
            this.btnVaciarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVaciarCategoria.Location = new System.Drawing.Point(104, 107);
            this.btnVaciarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnVaciarCategoria.Name = "btnVaciarCategoria";
            this.btnVaciarCategoria.Size = new System.Drawing.Size(86, 27);
            this.btnVaciarCategoria.TabIndex = 13;
            this.btnVaciarCategoria.Text = "&Vaciar";
            this.btnVaciarCategoria.UseVisualStyleBackColor = true;
            this.btnVaciarCategoria.Click += new System.EventHandler(this.btnVaciarCategoria_Click);
            // 
            // btnAñadirCategoria
            // 
            this.btnAñadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAñadirCategoria.Location = new System.Drawing.Point(14, 107);
            this.btnAñadirCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirCategoria.Name = "btnAñadirCategoria";
            this.btnAñadirCategoria.Size = new System.Drawing.Size(86, 27);
            this.btnAñadirCategoria.TabIndex = 12;
            this.btnAñadirCategoria.Text = "&Añadir";
            this.btnAñadirCategoria.UseVisualStyleBackColor = true;
            this.btnAñadirCategoria.Click += new System.EventHandler(this.btnAñadirCategoria_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(11, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Categoría";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboCatAñadirSubCategoria);
            this.groupBox3.Controls.Add(this.txtAñadirSubCategoria);
            this.groupBox3.Controls.Add(this.btnVaciarSubCategoria);
            this.groupBox3.Controls.Add(this.btnAñadirSubCategoria);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1118, 214);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(208, 151);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Añadir SubCategoria";
            // 
            // txtAñadirSubCategoria
            // 
            this.txtAñadirSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtAñadirSubCategoria.Location = new System.Drawing.Point(14, 82);
            this.txtAñadirSubCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtAñadirSubCategoria.Name = "txtAñadirSubCategoria";
            this.txtAñadirSubCategoria.Size = new System.Drawing.Size(176, 20);
            this.txtAñadirSubCategoria.TabIndex = 15;
            this.txtAñadirSubCategoria.TextChanged += new System.EventHandler(this.txtAñadirSubCategoria_TextChanged);
            // 
            // btnVaciarSubCategoria
            // 
            this.btnVaciarSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVaciarSubCategoria.Location = new System.Drawing.Point(104, 108);
            this.btnVaciarSubCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnVaciarSubCategoria.Name = "btnVaciarSubCategoria";
            this.btnVaciarSubCategoria.Size = new System.Drawing.Size(86, 27);
            this.btnVaciarSubCategoria.TabIndex = 13;
            this.btnVaciarSubCategoria.Text = "&Vaciar";
            this.btnVaciarSubCategoria.UseVisualStyleBackColor = true;
            this.btnVaciarSubCategoria.Click += new System.EventHandler(this.btnVaciarSubCategoria_Click);
            // 
            // btnAñadirSubCategoria
            // 
            this.btnAñadirSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAñadirSubCategoria.Location = new System.Drawing.Point(14, 108);
            this.btnAñadirSubCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirSubCategoria.Name = "btnAñadirSubCategoria";
            this.btnAñadirSubCategoria.Size = new System.Drawing.Size(86, 27);
            this.btnAñadirSubCategoria.TabIndex = 12;
            this.btnAñadirSubCategoria.Text = "&Añadir";
            this.btnAñadirSubCategoria.UseVisualStyleBackColor = true;
            this.btnAñadirSubCategoria.Click += new System.EventHandler(this.btnAñadirSubCategoria_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sub Categoría";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(11, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Categoría";
            // 
            // cboCatAñadirSubCategoria
            // 
            this.cboCatAñadirSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboCatAñadirSubCategoria.FormattingEnabled = true;
            this.cboCatAñadirSubCategoria.Location = new System.Drawing.Point(14, 41);
            this.cboCatAñadirSubCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCatAñadirSubCategoria.Name = "cboCatAñadirSubCategoria";
            this.cboCatAñadirSubCategoria.Size = new System.Drawing.Size(176, 21);
            this.cboCatAñadirSubCategoria.TabIndex = 14;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pcbEmpresa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAdmin);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmpresa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnVaciarZonaAdmin;
        private System.Windows.Forms.Button btnVaciarAñadirProducto;
        private System.Windows.Forms.PictureBox pcbEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAñadirCategoria;
        private System.Windows.Forms.Button btnVaciarCategoria;
        private System.Windows.Forms.Button btnAñadirCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAñadirSubCategoria;
        private System.Windows.Forms.Button btnVaciarSubCategoria;
        private System.Windows.Forms.Button btnAñadirSubCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoAñadirCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCatAñadirSubCategoria;
    }
}

