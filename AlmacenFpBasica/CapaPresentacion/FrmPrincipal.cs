﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public static List<Producto> productos;

        public string mensaje="";
        Tipo verT = new Tipo();
        Categoria verC = new Categoria();
        Subcategoria verSC = new Subcategoria();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void grbAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("No deje ningún campo vacio por favor");
                return;

            }
            Adminstrador admin = new Adminstrador(txtUser.Text, txtContrasena.Text);
            bool respuesta = Program.Gestor.IniciarSesion(admin, out mensaje);
            MessageBox.Show(mensaje);
            if (respuesta==true)
            {
                FrmAdmin frmabrir = new FrmAdmin();
                frmabrir.Show();
            }

            txtUser.Text = "";
            txtContrasena.Text = "";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Program.Gestor.Up();

            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(Program.Gestor.CargarTipos(out mensaje).ToArray());
            cboTipo.DisplayMember = "NombreTipo";


            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat.DisplayMember = "NombreCategoria";



            cboSubCat.Items.Clear();
            cboSubCat.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat.DisplayMember = "NombreSubCategoria";

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    Producto nuevoProducto = new Producto(verC.codCategoria, verSC.codSubCategoria, txtDescripcion.Text, int.Parse(txtCantidad.Text), decimal.Parse(txtPrecio.Text));
                    mensaje = Program.Gestor.AnadirProducto(nuevoProducto);
                    MessageBox.Show(mensaje);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductos producto = new FrmProductos();
            producto.comprob = true;
            producto.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           String msg;
           productos = Program.Gestor.BuscarProductosPorDescripcion(txtDescripcionBuscar.Text,out msg);
            if (msg!="")
            {
                MessageBox.Show(msg);
            }
            else
            {
                FrmProductos frm = new FrmProductos();
                frm.prods = productos;
                frm.comprob = false;
                frm.Show();
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            verT = cboTipo.SelectedItem as Tipo;           
        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            verC = cboCat.SelectedItem as Categoria;
        }

        private void cboSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            verSC = cboSubCat.SelectedItem as Subcategoria;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
