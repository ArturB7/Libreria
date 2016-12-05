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
    public partial class frmEditarAutores : Form
    {
        public frmEditarAutores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // CREA LOS OBJETOS
            clsAutores objAutor = new clsAutores();
            clsDatosAutores objDatos = new clsDatosAutores();
            //Productos obj = new Productos();


            // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
            objAutor.Autorid = Convert.ToInt32(txtAutorId.Text);
            objAutor.Nombre = txtNombre.Text;
            objAutor.Apellido = txtApellido.Text;
            objAutor.Telefono = txtTelefono.Text;
            objAutor.Direccion = txtDireccion.Text;
            objAutor.Ciudad = txtCiudad.Text;
            objAutor.Estado = txtEstado.Text;
            objAutor.CodigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
            // INSERTA AL PRODUCTO MEDIANTE EL MÉTODO
            objDatos.ModificarAutor(objAutor);
            // MUESTRA MENSAJE DE CONFIRMACION
            MessageBox.Show("Autor Modificado", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAutores Autores = new frmAutores();
            this.Hide();
            Autores.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
