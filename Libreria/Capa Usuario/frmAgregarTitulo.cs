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
    public partial class frmAgregarTitulo : Form
    {
        public frmAgregarTitulo()
        {
            InitializeComponent();
        }

        private void frmAgregarTitulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTitulo_Click(object sender, EventArgs e)
        {
            // CREA LOS OBJETOS
            clsTitulos objTitulo = new clsTitulos();
            clsDatosTitulos objDatos = new clsDatosTitulos();


            // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
            objTitulo.TituloId = Convert.ToInt32(txtIdTitulo.Text);
            objTitulo.Nombre = txtNombreTitulo.Text;
            objTitulo.Precio = Convert.ToDecimal(txtPrecioTitulo.Text);
            objTitulo.Genero = txtGeneroTitulo.Text;
            objTitulo.Fecha = (txtAnio.Text + Convert.ToString(cbMes.Text) + Convert.ToString(cbDia.Text));
            objTitulo.Notas = txtNotas.Text;
            objTitulo.Reagalias = txtRegalias.Text;
            


            // INSERTA AL PRODUCTO MEDIANTE EL MÉTODO
            objDatos.AgregarTitulo(objTitulo);
            // MUESTRA MENSAJE DE CONFIRMACION
            MessageBox.Show("Producto registrado", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmTitulos Titulos = new frmTitulos();
            this.Hide();
            Titulos.Show();
        }
    }
}
