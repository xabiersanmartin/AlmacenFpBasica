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
        //TODO La base de datos no tiene los campos "nombreCategoria" y "nombreSubCategoria"
        //TODO poner aquí los campos "nombreCategoria" y "nombreSubCategoria" 

        //Producto actual del dataGridView
        Producto producto;

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


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ponemos visibles el groupBoxModificar y el btnDelete
            groupBoxModificar.Enabled = true;
            btnDelete.Enabled = true;

            //Ponemos los textos correspondientes
            producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            txtDelete.Text = "Eliminar el producto con descripción " + producto.descripcion+" ?";
            txtCodigoProducto.Text = producto.codigoProducto.ToString();
            txtCodigoCategoria.Text = producto.codigoCategoria.ToString();
            txtCodigoSubcategoria.Text = producto.codigoSubcategoria.ToString();
            txtDescripcion.Text = producto.descripcion.ToString();
            txtStock.Text = producto.stock.ToString();
            txtPrecio.Text = producto.precio.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mens = Program.Gestor.EliminarProducto(producto);

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
                string mens = Program.Gestor.ModificarProducto(producto);

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
