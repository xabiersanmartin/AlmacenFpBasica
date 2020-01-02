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
    public partial class FrmProductos : Form
    {
        //Producto actual del dataGridView
        Producto productoActual;

        public List<Producto> prods = new List<Producto>();
        public bool comprob;
        public string mensaje;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarDataGridView();

            //Ocultar columnas del data grid view
            dgvProductos.Columns[0].Visible = false;//Ocultar Codigo Producto
            dgvProductos.Columns[1].Visible = false;//Ocultar Codigo Categoria
            dgvProductos.Columns[3].Visible = false;//Ocultar Codigo SubCategoria
        }

        private void cargarDataGridView()
        {
            if (comprob == true)
            {
                dgvProductos.DataSource = Program.Gestor.CargarProductos(out mensaje);
            }
            else if (comprob == false)
            {
                dgvProductos.DataSource = prods;
            }
        }
    private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            //Ponemos visibles el groupBoxModificar y el btnDelete
            if (!groupBoxModificar.Enabled) 
            { 
                groupBoxModificar.Enabled = true;
                btnDelete.Enabled = true;
            }

            dgvProductos.Rows[e.RowIndex].Selected = true;
            //Ponemos los textos correspondientes
            productoActual = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            txtDelete.Text = "Eliminar el producto con descripción: " + productoActual.descripcion+" ?";
            txtDescripcion.Text = productoActual.descripcion.ToString();
            txtStock.Text = productoActual.stock.ToString();
            txtPrecio.Text = productoActual.precio.ToString();
            txtCategoria.Text = productoActual.nombreCategoria;
            txtSubcategoria.Text = productoActual.nombreSubCategoria;
            }
        }

     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mens = Program.Gestor.EliminarProducto(productoActual);

            if (mens != "")
            {
                MessageBox.Show(mens);
            }
            else
            {
                txtDelete.Text = "";
                cargarDataGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string mens = Program.Gestor.ModificarProducto(productoActual.codigoProducto.ToString(),txtDescripcion.Text,txtStock.Text,txtPrecio.Text);

                if (mens != "")
                {
                    MessageBox.Show(mens);
                }
                else
                {
                    txtCategoria.Text = "";
                    txtSubcategoria.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    txtDescripcion.Text = "";
                    txtDelete.Text = "";
                    cargarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarDataGridView();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string mensaje;
            dgvProductos.DataSource = Program.Gestor.BuscarProductosPorDescripcion(txtBrowse.Text, out mensaje);
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje);
            }
        }

    }
}
