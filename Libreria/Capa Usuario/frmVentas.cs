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
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Usuario
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            generaColumnas();
            txtProducto.Enabled = false;
            txtPrecio.Enabled = false;
        }

        public void generaColumnas()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Id", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Producto", 180, HorizontalAlignment.Left);
            listView1.Columns.Add("Cantidad", 60, HorizontalAlignment.Right);
            listView1.Columns.Add("Precio", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("Total", 80, HorizontalAlignment.Right);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { //evaluamos que haga cierta funcion solo cuando presionemos la tecla de enter
                txtID.Focus();
                MySqlConnection mcon = new MySqlConnection("database=libreria;datasource=localhost;port= 3306;username= root;password= 123tamarindo");
                MySqlCommand mcd;
                MySqlDataReader mdr;
                string s;
                try
                {
                    mcon.Open();
                    s = "select Nombre, precio from titulos where Tituloid=" + int.Parse(txtID.Text);
                    mcd = new MySqlCommand(s, mcon);
                    mdr = mcd.ExecuteReader();
                    if (mdr.Read())
                    {
                        txtProducto.Text = mdr.GetString("Nombre");
                        txtPrecio.Text = mdr.GetString("precio");

                    }
                    else
                    {
                        MessageBox.Show("Libro no Encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //mdr.Close();
                    mcon.Close();
                }
                txtCantidad.Focus();
            }
        }

        Double w = 0.0;
        public void agregarVenta()
        {

            string varId = txtID.Text;
            string varProducto = txtProducto.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double total = Convert.ToDouble(precio * cantidad);

            //Añadimos los elementos (filas) al ListView
            string[] elementosFila = new string[5];
            ListViewItem elementoListView;

            //Añadimos una primera fila al ListView
            elementosFila[0] = varId;
            elementosFila[1] = varProducto;
            elementosFila[2] = Convert.ToString(cantidad);
            elementosFila[3] = Convert.ToString(precio);
            elementosFila[4] = Convert.ToString(total);
            elementoListView = new ListViewItem(elementosFila);
            listView1.Items.Add(elementoListView);

            w = w + total;
            txtTotal.Text = Convert.ToString(w);

            txtCambio.Text = "";



        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                agregarVenta();

                // CREA LOS OBJETOS
                clsTitulos objTitulo = new clsTitulos();
                clsDatosTitulos objDatos = new clsDatosTitulos();

                // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
                objTitulo.TituloId = Convert.ToInt32(txtID.Text);
                objTitulo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                // INSERTA AL titulo MEDIANTE EL MÉTODO
                objDatos.RestarInventario(objTitulo);
                btnVender.Visible = true;

                /*txtID.Text = "";
                txtProducto.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";*/
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                int cambio;
                int pago;
                int total;
                pago = Convert.ToInt32(txtPago.Text);
                total = Convert.ToInt32(txtTotal.Text);

                cambio = pago - total;
                txtCambio.Text = Convert.ToString(cambio);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            AutoIncremento();
            generaColumnas();
            // CREA LOS OBJETOS
            clsVentas objvent = new clsVentas();
            clsDatosVentas objDatos = new clsDatosVentas();
            clsTitulos objTitulo = new clsTitulos();
            //Inicial = Fecha.Value.Year;
            //Mes = Fecha.Value.Month;
            //dia = Fecha.Value.Day;


            //dtpfecha1.Text = Convert.ToDateTime(dtpfecha1.Value);s
            //DateTime fecha1 = new DateTime(Inicial, Mes, dia);}
            //Fecha.Value = Convert.ToDateTime(entidades.Fecha);
            //Fecha.Value.ToString("yyyy//MM/dd");

            // LEE LOS DATOS DE LAS CAJAS Y LOS GUARDA EN EL OBJETO
            objvent.Fecha = Convert.ToDateTime(Fecha.Text.ToString());
            objvent.IdVenta = Convert.ToInt32(txtFolio.Text);
            objvent.IdTitulo = Convert.ToInt32(txtID.Text);
            objvent.Cantidad = Convert.ToInt32(txtCantidad.Text);

            objTitulo.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objTitulo.TituloId = Convert.ToInt32(txtID.Text);

            // INSERTA AL PRODUCTO MEDIANTE EL MÉTODO
            objDatos.AgregarVenta(objvent);
            MessageBox.Show("Venta Realizada con Exito");
            objDatos.RestarInventario(objTitulo);
            txtTotal.Text = "";
            comboEmpleado.Text = "";
        }

        public void AutoIncremento()
        {
            int i;
            if (int.TryParse(txtFolio.Text, out i))
            {
                txtFolio.Text = (i + 1).ToString();
            }

        }
    }
}
