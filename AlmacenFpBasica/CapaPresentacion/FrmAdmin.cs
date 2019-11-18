using CapaDatos;
using System;
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
    public partial class FrmAdmin : Form
    {
        public string mensaje="";
        Producto eliminarP = new Producto();
        Categoria eliminarC = new Categoria();
        Subcategoria eliminarSC = new Subcategoria();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            mensaje = Program.Gestor.ModificarPassAdmin(txtPass.Text);
            MessageBox.Show(mensaje);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            cboProd.Items.Clear();
            cboProd.Items.AddRange(Program.Gestor.CargarProductos(out mensaje).ToArray());
            cboProd.DisplayMember = "descripcion";

            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.Gestor.CargarCategoria(out mensaje).ToArray());
            cboCat.DisplayMember = "nombreCategoria";

            cboSubCat.Items.Clear();
            cboSubCat.Items.AddRange(Program.Gestor.CargarSubCategoria(out mensaje).ToArray());
            cboSubCat.DisplayMember = "NombreSubCategoria";
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
           
            eliminarP =  cboProd.SelectedItem as Producto;
            Program.Gestor.EliminarProducto(eliminarP);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            eliminarC = cboCat.SelectedItem as Categoria;
            Program.Gestor.EliminarCategoria(eliminarC);
        }

        private void btnSubCat_Click(object sender, EventArgs e)
        {
            eliminarSC = cboSubCat.SelectedItem as Subcategoria;
            Program.Gestor.EliminarSubCategoria(eliminarSC);
        }
    }
}
