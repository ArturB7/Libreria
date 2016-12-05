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
    public partial class frmEditarTitulos : Form
    {
        public frmEditarTitulos()
        {
            InitializeComponent();
        }

        private void btnActualizarTitulo_Click(object sender, EventArgs e)
        {
            // CREA LOS OBJETOS
            clsTitulos objTitulo = new clsTitulos();
            clsDatosTitulos objDatos = new clsDatosTitulos();
            //Productos obj = new Productos();


            // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
            objTitulo.TituloId = Convert.ToInt32(txtId.Text);
            objTitulo.Nombre = txtNombre.Text;
            objTitulo.Genero = txtGenero.Text;
            objTitulo.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objTitulo.Notas = txtNotas.Text;
            objTitulo.Precio = Convert.ToDecimal(txtPrecio.Text);
            objTitulo.Reagalias = txtRegalias.Text;
            // INSERTA AL PRODUCTO MEDIANTE EL MÉTODO
            objDatos.ModificarTitulo(objTitulo);
            // MUESTRA MENSAJE DE CONFIRMACION
            MessageBox.Show("Empleado Modificado", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmTitulos Titulos = new frmTitulos();
            this.Hide();
            Titulos.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
