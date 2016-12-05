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
    public partial class frmAgregarAutores : Form
    {
        public frmAgregarAutores()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // CREA LOS OBJETOS
            clsAutores objAutores = new clsAutores();
            clsDatosAutores objDatos = new clsDatosAutores();


            // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
            objAutores.Autorid = Convert.ToInt32(txtAutorId.Text);
            objAutores.Nombre = txtNombre.Text;
            objAutores.Apellido = txtApellido.Text;
            objAutores.Telefono = txtTelefono.Text;
            objAutores.Direccion = txtDireccion.Text;
            objAutores.Ciudad = txtCiudad.Text;
            objAutores.Estado = txtEstado.Text;
            objAutores.CodigoPostal = Convert.ToInt32(txtCodigoPostal.Text);



            // INSERTA AL PRODUCTO MEDIANTE EL MÉTODO
            objDatos.AgregarAutor(objAutores);
            // MUESTRA MENSAJE DE CONFIRMACION
            MessageBox.Show("Autor Agregado", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAutores Autores = new frmAutores();
            this.Hide();
            Autores.Show();
        }
    }
}
