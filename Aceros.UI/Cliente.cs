using System;
using System.Windows.Forms;
using Cl.Aceros.BL;

namespace Aceros.UI
{
    public partial class FrmClientes : Form
    {
        MantenimientoCliente mante = new MantenimientoCliente();
        Clientes cli = new Clientes();
        

        public FrmClientes()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCLiCedula.Text = null;
            txtCliEmail.Text = null;
            txtCliNombre.Text = null;
            txtCliTelefono.Text = null;
        }


        private void btnCliAgregar_Click(object sender, EventArgs e)
        {
            int cedula;
            int telefono;

            try
            {
                //Llenar datos
                if (Int32.TryParse(txtCLiCedula.Text, out cedula))
                {
                    cli.Cedula = cedula;
                }
                else
                {
                    MessageBox.Show("Por favor Ingrese un numero de cedula valido");
                }

                if (Int32.TryParse(txtCliTelefono.Text, out telefono))
                {
                    cli.Telefono = telefono;
                }
                else
                {
                    MessageBox.Show("Por favor Ingrese un numero de telefono valido");
                }
                cli.Email = txtCliEmail.Text;
                cli.Nombre = txtCliNombre.Text;
                //Agregar a la lista
                mante.Insertar(cli);
                //Limpiar
                dgvClientes.DataSource = null;
                //Mostar Datos
                dgvClientes.DataSource = mante.mostrar();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Un Error ha ocurrido: " + ee.ToString());
            }
            


        }

        private void btnCliSalir_Click(object sender, EventArgs e)
        {
            FrmClientes.ActiveForm.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCliBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = mante.mostrar();
            txtCLiCedula.Enabled = true;
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnCliModificar.Enabled = true;
            btnCliEliminar.Enabled = true;

            try
            {
                if (e.RowIndex >= 0)
                {
                    txtCliNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    txtCLiCedula.Text = dgvClientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                    txtCliTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    txtCliEmail.Text = dgvClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    btnCliAgregar.Enabled = false;
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Un Error ha ocurrido: " + ee.ToString());
            }
            txtCLiCedula.Enabled = false;
            
        }

        private void btnCliEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Cedula = Convert.ToInt32(txtCLiCedula.Text);
                cli.Nombre = txtCliNombre.Text;
                cli.Telefono = Convert.ToInt32(txtCliTelefono.Text);
                cli.Email = txtCliEmail.Text;
                //Eliminar Registro
                mante.eliminar(cli);
            }
            catch (Exception ee)
            {

                MessageBox.Show("Un Error ha ocurrido: " + ee.ToString());
            }
            //Limpiar
            dgvClientes.DataSource = null;
            limpiar();
            txtCLiCedula.Enabled = true;
            //Mostar Datos
            dgvClientes.DataSource = mante.mostrar();
            btnCliAgregar.Enabled = true;

        }

        private void btnCliModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cli.Cedula = Convert.ToInt32(txtCLiCedula.Text);
                cli.Nombre = txtCliNombre.Text;
                cli.Telefono = Convert.ToInt32(txtCliTelefono.Text);
                cli.Email = txtCliEmail.Text;
                //Modificar Registro
                mante.actualizar(cli);
            }
            catch (Exception ee)
            {

                MessageBox.Show("Un Error ha ocurrido: " + ee.ToString());
            }
            //Limpiar
            dgvClientes.DataSource = null;
            limpiar();
            txtCLiCedula.Enabled = true;
            //Mostar Datos
            dgvClientes.DataSource = mante.mostrar();
            btnCliAgregar.Enabled = true;
        }
    }
}
