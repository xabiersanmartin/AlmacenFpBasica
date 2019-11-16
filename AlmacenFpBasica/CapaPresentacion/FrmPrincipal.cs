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
            cboTipo.DisplayMember = "TiposProducto";
            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat.DisplayMember = "nombreCategoria";
            cboSubCat.Items.Clear();
            cboSubCat.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat.DisplayMember = "nombreSubCategoria";
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto(int.Parse(cboCat.SelectedItem.ToString()),int.Parse(cboSubCat.SelectedItem.ToString()),txtDescripcion.Text,int.Parse(txtCantidad.Text),decimal.Parse(txtPrecio.Text));
            mensaje=  Program.Gestor.AnadirProducto(nuevoProducto);
            MessageBox.Show(mensaje);
        }
    }
}
