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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.Controls.Add(this.btnAcceder);
            this.grbAdmin.Controls.Add(this.lblPassword);
            this.grbAdmin.Controls.Add(this.textBox2);
            this.grbAdmin.Controls.Add(this.txtUsuario);
            this.grbAdmin.Controls.Add(this.textBox1);
            this.grbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.Location = new System.Drawing.Point(944, 82);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(265, 246);
            this.grbAdmin.TabIndex = 0;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Zona Administrador";
            this.grbAdmin.Enter += new System.EventHandler(this.grbAdmin_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 24);
            this.textBox1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(29, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(50, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(31, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 24);
            this.textBox2.TabIndex = 2;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(76, 182);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(103, 33);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(1061, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 64);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 608);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbAdmin);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario principal";
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}

