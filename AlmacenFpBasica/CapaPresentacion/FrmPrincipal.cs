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
            if (mensaje!="")
            {
                MessageBox.Show(mensaje);
            }
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
            Empresa EmpresaCargar = new Empresa();
            EmpresaCargar = Program.Gestor.CargarEmpresa(out string mensaje);
            pcbEmpresa.ImageLocation=EmpresaCargar.logo;
            lblNombreEmpresa.Text = EmpresaCargar.nombre;
            cargarCBOs();

        }
        private void cargarCBOs()
        {
            cboTipo.Items.Clear();
            cboTipo.Items.AddRange(Program.Gestor.CargarTipos(out mensaje).ToArray());
            cboTipo.DisplayMember = "NombreTipo";

            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat.DisplayMember = "NombreCategoria";

            cboSubCat.Items.Clear();
            cboSubCat.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat.DisplayMember = "NombreSubCategoria";

            cboTipoAñadirCategoria.Items.Clear();
            cboTipoAñadirCategoria.Items.AddRange(Program.Gestor.CargarTipos(out mensaje).ToArray());
            cboTipoAñadirCategoria.DisplayMember = "NombreTipo";

            cboCatAñadirSubCategoria.Items.Clear();
            cboCatAñadirSubCategoria.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCatAñadirSubCategoria.DisplayMember = "NombreCategoria";

        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Producto nuevoProducto = new Producto(verC.codCategoria, verSC.codSubCategoria, txtDescripcion.Text, int.Parse(txtCantidad.Text), decimal.Parse(txtPrecio.Text));
                    mensaje = Program.Gestor.AnadirProducto(nuevoProducto);
                    if (mensaje!="")
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        vaciarCamposAñadirProducto();
                    }
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

        private void vaciarCamposAñadirProducto()
        {
            cboTipo.SelectedItem = null;
            cboCat.SelectedItem = null;
            cboSubCat.SelectedItem = null;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            vaciarCamposAñadirProducto();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtContrasena.Text = "";
        }

        private void btnVaciarCategoria_Click(object sender, EventArgs e)
        {
            cboTipoAñadirCategoria.SelectedItem = null;
            txtAñadirCategoria.Text = "";
        }

        private void btnVaciarSubCategoria_Click(object sender, EventArgs e)
        {
            cboCatAñadirSubCategoria.SelectedItem = null;
            txtAñadirSubCategoria.Text = "";
        }

        private void btnAñadirCategoria_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Categoria nuevaCategoria= new Categoria(txtAñadirCategoria.Text);
                    mensaje = Program.Gestor.AñadirCategoria(nuevaCategoria, (Tipo)cboTipoAñadirCategoria.SelectedItem);
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        cboTipoAñadirCategoria.SelectedItem = null;
                        txtAñadirCategoria.Text = "";
                        cargarCBOs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnAñadirSubCategoria_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Subcategoria nuevaSubCategoria = new Subcategoria(txtAñadirSubCategoria.Text);
                    mensaje = Program.Gestor.AñadirSubCategoria(nuevaSubCategoria,(Categoria)cboCatAñadirSubCategoria.SelectedItem);
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        cboCatAñadirSubCategoria.SelectedItem = null;
                        txtAñadirCategoria.Text = "";
                        cargarCBOs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtAñadirSubCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
