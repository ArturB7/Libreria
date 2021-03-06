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
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void frmTitulos_Load(object sender, EventArgs e)
        {
            mostrarTitulos();
        }

        private void mostrarTitulos()
        {
            clsDatosTitulos objTitulo = new clsDatosTitulos();
            dgvTitulos.DataSource = objTitulo.getTitulos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregarTitulo obj = new frmAgregarTitulo();
            obj.Show();


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsTitulos objTitulo = new clsTitulos();
            clsDatosTitulos objdatos = new clsDatosTitulos();
            objTitulo.TituloId = Convert.ToInt32(this.dgvTitulos.CurrentRow.Cells[0].Value.ToString());
            objdatos.buscarTitulo(ref objTitulo);

            frmEditarTitulos x = new frmEditarTitulos();

            x.label1.Visible = false;
            x.label2.Visible = true;

            x.txtId.Text = Convert.ToString(objTitulo.TituloId);
            x.txtNombre.Text = objTitulo.Nombre;
            x.txtGenero.Text = objTitulo.Genero;
            x.txtAnio.Text = objTitulo.Fecha;
            x.txtCantidad.Text = Convert.ToString(objTitulo.Cantidad);
            x.txtNotas.Text = objTitulo.Notas;
            x.txtPrecio.Text = Convert.ToString(objTitulo.Precio);
            x.txtRegalias.Text = objTitulo.Reagalias;

            x.txtId.Enabled = false;
            x.txtNombre.Enabled = true;
            x.txtGenero.Enabled = true;
            x.txtAnio.Enabled = false;
            x.txtCantidad.Enabled = true;
            x.txtNotas.Enabled = true;
            x.txtPrecio.Enabled = true;
            x.txtRegalias.Enabled = true;


            x.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // CREA LOS OBJETOS
            clsDatosTitulos datos = new clsDatosTitulos();
            clsTitulos titulo = new clsTitulos();


            titulo.TituloId = Convert.ToInt32(dgvTitulos.Rows[dgvTitulos.SelectedRows[0].Index].Cells[0].Value.ToString());



            DialogResult result = MessageBox.Show("Seguro que deseas eliminar?", "", MessageBoxButtons.YesNoCancel);
            // REFRESCA LOS DATOS Y MUESTRA EL MENSAJE "ELIMINADO"
            if (result == DialogResult.Yes)
            {
                titulo.TituloId = Convert.ToInt32(dgvTitulos.Rows[dgvTitulos.SelectedRows[0].Index].Cells[0].Value.ToString());
                datos.EliminarTitulo(titulo);

                mostrarTitulos();
                MessageBox.Show("Producto eliminado");
            }
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            dgvTitulos.DataSource = clsDatosTitulos.Buscar(txtBuscarTitulo.Text);
        }
    }
}
