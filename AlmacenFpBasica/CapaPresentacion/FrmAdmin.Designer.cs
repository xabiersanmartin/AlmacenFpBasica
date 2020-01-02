namespace CapaPresentacion
{
    partial class FrmAdmin
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubCat = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSubCat = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(93, 120);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 26);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(333, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(122, 80);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(107, 20);
            this.txtPass.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubCat);
            this.groupBox2.Controls.Add(this.btnCat);
            this.groupBox2.Controls.Add(this.btnProd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboSubCat);
            this.groupBox2.Controls.Add(this.cboCat);
            this.groupBox2.Controls.Add(this.cboProd);
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(296, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar elementos";
            // 
            // btnSubCat
            // 
            this.btnSubCat.Location = new System.Drawing.Point(225, 120);
            this.btnSubCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubCat.Name = "btnSubCat";
            this.btnSubCat.Size = new System.Drawing.Size(56, 19);
            this.btnSubCat.TabIndex = 8;
            this.btnSubCat.Text = "Eliminar";
            this.btnSubCat.UseVisualStyleBackColor = true;
            this.btnSubCat.Click += new System.EventHandler(this.btnSubCat_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(225, 81);
            this.btnCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(56, 19);
            this.btnCat.TabIndex = 7;
            this.btnCat.Text = "Eliminar";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(225, 45);
            this.btnProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(56, 19);
            this.btnProd.TabIndex = 6;
            this.btnProd.Text = "Eliminar";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sub Categorias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos";
            // 
            // cboSubCat
            // 
            this.cboSubCat.FormattingEnabled = true;
            this.cboSubCat.Location = new System.Drawing.Point(97, 120);
            this.cboSubCat.Margin = new System.Windows.Forms.Padding(2);
            this.cboSubCat.Name = "cboSubCat";
            this.cboSubCat.Size = new System.Drawing.Size(118, 21);
            this.cboSubCat.TabIndex = 2;
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(97, 80);
            this.cboCat.Margin = new System.Windows.Forms.Padding(2);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(118, 21);
            this.cboCat.TabIndex = 1;
            // 
            // cboProd
            // 
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(97, 45);
            this.cboProd.Margin = new System.Windows.Forms.Padding(2);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(118, 21);
            this.cboProd.TabIndex = 0;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubCat;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubCat;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboProd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}