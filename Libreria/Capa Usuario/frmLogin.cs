using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria.Capa_Usuario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "A")
            {
                if (txtContraseña.Text == "123")
                {
                    MessageBox.Show("Bienvenido");
                    frmPrincipal form = new frmPrincipal();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                }
            }
            else { MessageBox.Show("El Usuario no Existe"); }
        }
    }
}
