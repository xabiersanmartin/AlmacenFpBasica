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
       public Tipo tipo = new Tipo();
       public Categoria categoria = new Categoria();
       public Subcategoria subcategoria = new Subcategoria();
        string msg = "";
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
            string mensaje;
            dgvProductos.DataSource = Program.Gestor.CargarProductos(out mensaje);
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //List<Producto> listaP = new List<Producto>();
           //listaP = Program.Gestor.CargarProductos(out msg);
            dgvProductos.DataSource = FrmPrincipal.productos;
        }
    }
}
