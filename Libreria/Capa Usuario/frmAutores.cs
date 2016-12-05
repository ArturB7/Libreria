using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Capa_Datos;
using Libreria.Capa_Negocios;

namespace Libreria.Capa_Usuario
{
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            mostrarAutores();
        }

        private void mostrarAutores()
        {
            clsDatosAutores objAutor = new clsDatosAutores();
            dgvAutores.DataSource = objAutor.getAutores();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            frmAgregarAutores obj = new frmAgregarAutores();
            obj.Show();
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            clsAutores objAutores = new clsAutores();
            clsDatosAutores objdatos = new clsDatosAutores();
            objAutores.Autorid = Convert.ToInt32(this.dgvAutores.CurrentRow.Cells[0].Value.ToString());
            objdatos.buscarAutor(ref objAutores);

            frmEditarAutores x = new frmEditarAutores();

            x.label1.Visible = false;
            x.label2.Visible = true;

            x.txtAutorId.Text = Convert.ToString(objAutores.Autorid);
            x.txtNombre.Text = objAutores.Nombre;
            x.txtApellido.Text = objAutores.Apellido;
            x.txtTelefono.Text = objAutores.Telefono;
            x.txtDireccion.Text = Convert.ToString(objAutores.Direccion);
            x.txtCiudad.Text = objAutores.Ciudad;
            x.txtEstado.Text = Convert.ToString(objAutores.Estado);
            x.txtCodigoPostal.Text = Convert.ToString(objAutores.CodigoPostal);

            x.txtAutorId.Enabled = false;
            x.txtNombre.Enabled = true;
            x.txtApellido.Enabled = true;
            x.txtTelefono.Enabled = true;
            x.txtDireccion.Enabled = true;
            x.txtCiudad.Enabled = true;
            x.txtEstado.Enabled = true;
            x.txtCodigoPostal.Enabled = true;


            x.Show();

            this.Close();
      
        }
    }
}
