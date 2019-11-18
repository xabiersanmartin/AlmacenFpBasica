using System;
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
                MessageBox.Show("No deje ningún campo vacío por favor");
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
            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(Program.Gestor.CargarTipos(out mensaje).ToArray());
            cboTipo.DisplayMember = "NombreTipo";

            cboTipo1.Items.Clear();
            cboTipo1.Items.AddRange(Program.Gestor.CargarTipos(out mensaje).ToArray());
            cboTipo1.DisplayMember = "NombreTipo";

            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat.DisplayMember = "NombreCategoria";

            cboCat1.Items.Clear();
            cboCat1.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat1.DisplayMember = "NombreCategoria";

            cboSubCat.Items.Clear();
            cboSubCat.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat.DisplayMember = "NombreSubCategoria";

            cboSubCat1.Items.Clear();
            cboSubCat1.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat1.DisplayMember = "NombreSubCategoria";
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //if (!cboTipo.SelectedItem.Equals(null) || !cboCat.SelectedItem.Equals(null) || !cboSubCat.SelectedItem.Equals(null) || txtCantidad.Text!= "" || txtPrecio.Text != "" || txtDescripcion.Text != "")
            {
                try
                {
                    Producto nuevoProducto = new Producto(int.Parse(cboCat.SelectedItem.ToString()), int.Parse(cboSubCat.SelectedItem.ToString()), txtDescripcion.Text, int.Parse(txtCantidad.Text), decimal.Parse(txtPrecio.Text));
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
            Productos productos = new Productos();
            verT = cboTipo1.SelectedItem as Tipo;
            verC = cboCat1.SelectedItem as Categoria;
            verSC = cboSubCat1.SelectedItem as Subcategoria;
            productos.tipo = verT;
            productos.categoria = verC;
            productos.subcategoria = verSC;
            productos.Show();
        }
    }
}
