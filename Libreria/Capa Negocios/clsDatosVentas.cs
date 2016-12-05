using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Libreria.Capa_Datos;
using Libreria.Capa_Usuario;

namespace Libreria.Capa_Negocios
{
    class clsDatosVentas
    {
        private MySqlConnection cnConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "libreria" + ";UID=" + "root" + ";PWD=" + "123tamarindo";
            cnConexion.ConnectionString = strCadenaConexion;
            cnConexion.Open();
        }

        public void Cerrar()
        {
            cnConexion.Close();
        }

        clsTitulos objTitulo = new clsTitulos();


        public void RestarInventario(clsTitulos objTitulo)
        {
            string sql;
            MySqlCommand cm;
            Conectar();
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@Tituloid", objTitulo.TituloId);
            cm.Parameters.AddWithValue("@Cantidad", objTitulo.Cantidad);

            sql = "UPDATE productos SET Cantidad = Cantidad - @Cantidad  WHERE Tituloid = @Tituloid";

            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();


        }

        public void AgregarVenta(clsVentas objVentas)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@ventaid", objVentas.IdVenta);
            cm.Parameters.AddWithValue("@tituloid", objVentas.IdTitulo);
            cm.Parameters.AddWithValue("@cantidad", objVentas.Cantidad);
            cm.Parameters.AddWithValue("@fecha", objVentas.Fecha);

            sql = "INSERT INTO ventas (idVenta, Fecha, idTitulo, Cantidad) VALUES (@ventaid, @tituloid, @cantidad, @fecha)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

    }
}
