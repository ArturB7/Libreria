using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria.Capa_Usuario;

namespace Libreria.Capa_Usuario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTitulos Titulos = new frmTitulos();
            Titulos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            this.Hide();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            frmEditoriales Editoriales = new frmEditoriales();
            Editoriales.Show();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frmAutores Autores = new frmAutores();
            Autores.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
