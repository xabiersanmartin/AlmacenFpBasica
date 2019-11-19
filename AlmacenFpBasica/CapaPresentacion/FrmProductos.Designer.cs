namespace CapaPresentacion
{
    partial class FrmProductos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.groupBoxModificar = new System.Windows.Forms.GroupBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoSubcategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBoxModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(195, 288);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 25);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(378, 257);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selecciona un elemento";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(114, 288);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 27;
            this.btnCargar.Text = "Cargar Coches";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(477, 259);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(222, 20);
            this.txtDelete.TabIndex = 32;
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(477, 288);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(222, 20);
            this.txtBrowse.TabIndex = 30;
            // 
            // groupBoxModificar
            // 
            this.groupBoxModificar.Controls.Add(this.label3);
            this.groupBoxModificar.Controls.Add(this.txtPrecio);
            this.groupBoxModificar.Controls.Add(this.label2);
            this.groupBoxModificar.Controls.Add(this.txtStock);
            this.groupBoxModificar.Controls.Add(this.label1);
            this.groupBoxModificar.Controls.Add(this.txtDescripcion);
            this.groupBoxModificar.Controls.Add(this.txtCodigoProducto);
            this.groupBoxModificar.Controls.Add(this.label5);
            this.groupBoxModificar.Controls.Add(this.txtCodigoCategoria);
            this.groupBoxModificar.Controls.Add(this.label6);
            this.groupBoxModificar.Controls.Add(this.txtCodigoSubcategoria);
            this.groupBoxModificar.Controls.Add(this.label7);
            this.groupBoxModificar.Controls.Add(this.btnUpdate);
            this.groupBoxModificar.Enabled = false;
            this.groupBoxModificar.Location = new System.Drawing.Point(396, 25);
            this.groupBoxModificar.Name = "groupBoxModificar";
            this.groupBoxModificar.Size = new System.Drawing.Size(322, 217);
            this.groupBoxModificar.TabIndex = 31;
            this.groupBoxModificar.TabStop = false;
            this.groupBoxModificar.Text = "Modificar";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.Location = new System.Drawing.Point(114, 28);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(189, 20);
            this.txtCodigoProducto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Codigo SubCategoria";
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Enabled = false;
            this.txtCodigoCategoria.Location = new System.Drawing.Point(114, 54);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(189, 20);
            this.txtCodigoCategoria.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Codigo Categoria";
            // 
            // txtCodigoSubcategoria
            // 
            this.txtCodigoSubcategoria.Enabled = false;
            this.txtCodigoSubcategoria.Location = new System.Drawing.Point(114, 80);
            this.txtCodigoSubcategoria.Name = "txtCodigoSubcategoria";
            this.txtCodigoSubcategoria.Size = new System.Drawing.Size(189, 20);
            this.txtCodigoSubcategoria.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Codigo Producto";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(169, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(396, 286);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(396, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 106);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(189, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(114, 132);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(189, 20);
            this.txtStock.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(114, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(189, 20);
            this.txtPrecio.TabIndex = 25;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 321);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.groupBoxModificar);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvProductos);
            this.Name = "FrmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBoxModificar.ResumeLayout(false);
            this.groupBoxModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoSubcategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}