﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            string mensaje;
            dgvProductos.DataSource = Program.Gestor.CargarProductos(out mensaje);
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
