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
          
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje);
            }
            if (comprob == true)
            {
                dgvProductos.DataSource = Program.Gestor.CargarProductos(out mensaje);
            }
            else if (comprob==false)
            {
                dgvProductos.DataSource = prods;
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
