﻿using System;
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
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        private void frmEditoriales_Load(object sender, EventArgs e)
        {
            mostrarEditoriales();
        }

        private void mostrarEditoriales()
        {
            clsDatosEditores objEditor = new clsDatosEditores();
            dgvEditores.DataSource = objEditor.getEditores();
        }
    }
}
