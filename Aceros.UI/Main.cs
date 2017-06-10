using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aceros.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void mantemientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMantProducto producto = new frmMantProducto();
            producto.ShowDialog();


        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientos movimientos = new frmMovimientos();
            movimientos.ShowDialog();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCostos costos = new frmCostos();
            costos.ShowDialog();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes cliente = new FrmClientes();
            cliente.ShowDialog();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProveedores proveedores = new FrmProveedores();
            proveedores.ShowDialog();
        }
    }
}
