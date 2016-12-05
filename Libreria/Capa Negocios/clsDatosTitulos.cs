using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Capa_Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Negocios
{
     class clsDatosTitulos
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

        public void AgregarTitulo(clsTitulos objTitulo)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@tituloid", objTitulo.TituloId);
            cm.Parameters.AddWithValue("@nombre", objTitulo.Nombre);
            cm.Parameters.AddWithValue("@genero", objTitulo.Genero);
            cm.Parameters.AddWithValue("@precio", objTitulo.Precio);
            cm.Parameters.AddWithValue("@notas", objTitulo.Notas);
            cm.Parameters.AddWithValue("@fecha", objTitulo.Fecha);
            cm.Parameters.AddWithValue("@regalias", objTitulo.Reagalias);

            sql = "INSERT INTO titulos (Tituloid, Nombre, Genero, precio, Notas, FechaPubicacion, Regalias) VALUES (@tituloid, @nombre, @genero, @precio, @notas, @fecha, @regalias)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public clsTitulos getTituloById(string TituloId)
        {
            clsTitulos objTitulo = new clsTitulos();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM titulos WHERE Tituloid = @TituloId";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@TituloId", TituloId);
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                objTitulo.TituloId = dr.GetInt32("TituloId");
                objTitulo.Nombre = dr.GetString("Nombre");
                objTitulo.Genero = dr.GetString("Genero");
                objTitulo.Precio = dr.GetDecimal("Precio");
                objTitulo.Notas = dr.GetString("Notas");
                objTitulo.Fecha = dr.GetString("Fecha Publicacion");
                objTitulo.Reagalias = dr.GetString("Regalias");


                Cerrar();
                return objTitulo;
            }
            else
            {
                Cerrar();
                return null;
            }
        }

        public void ModificarTitulo(clsTitulos objTitulo)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@tituloid", objTitulo.TituloId);
            cm.Parameters.AddWithValue("@nombre", objTitulo.Nombre);
            cm.Parameters.AddWithValue("@genero", objTitulo.Genero);
            cm.Parameters.AddWithValue("@precio", objTitulo.Precio);
            cm.Parameters.AddWithValue("@notas", objTitulo.Notas);
            cm.Parameters.AddWithValue("@regalias", objTitulo.Reagalias);


            sql = "UPDATE titulos SET  Nombre = @nombre, Genero = @genero, precio = @precio, Notas = @notas, Regalias = @regalias where Tituloid=@tituloid";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public void EliminarTitulo(clsTitulos objTitulo)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            sql = "DELETE FROM titulos WHERE Tituloid = '" + objTitulo.TituloId + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public List<clsTitulos> getTitulos()
        {
            List<clsTitulos> lstTitulos = new List<clsTitulos>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM titulos";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                clsTitulos objTitulo = new clsTitulos();

                objTitulo.TituloId = dr.GetInt32("TituloId");
                objTitulo.Nombre = dr.GetString("Nombre");
                objTitulo.Genero = dr.GetString("Genero");
                objTitulo.Precio = dr.GetDecimal("Precio");
                objTitulo.Notas = dr.GetString("Notas");
                objTitulo.Fecha = dr.GetString("FechaPubicacion");
                objTitulo.Reagalias = dr.GetString("Regalias");


                lstTitulos.Add(objTitulo);
            }

            Cerrar();
            return lstTitulos;
        }

        public static List<clsTitulos> Buscar(string TituloId)
        {
            List<clsTitulos> _lista = new List<clsTitulos>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Tituloid, Nombre, Genero, precio, Notas, FechaPubicacion, Regalias FROM titulos where Nombre ='{0}'", TituloId), clsTitulos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsTitulos pTitulo = new clsTitulos();

                pTitulo.TituloId = _reader.GetInt32(0);
                pTitulo.Nombre = _reader.GetString(1);
                pTitulo.Genero = _reader.GetString(2);
                pTitulo.Precio = _reader.GetDecimal(3);
                pTitulo.Notas = _reader.GetString(4);
                pTitulo.Fecha = _reader.GetString(5);
                pTitulo.Reagalias = _reader.GetString(6);


                _lista.Add(pTitulo);
            }

            return _lista;
        }

        public clsTitulos buscarTitulo(ref clsTitulos cli)
        {
            Conectar();
            string consulta = "Select * from titulos where Tituloid= " + cli.TituloId;
            MySqlCommand miCom = new MySqlCommand(consulta, cnConexion);
            MySqlDataReader midataReader = miCom.ExecuteReader();
            midataReader.Read();
            if (midataReader.HasRows)
            {
                cli.TituloId = Convert.ToInt32(midataReader["Tituloid"].ToString());
                cli.Nombre = midataReader["Nombre"].ToString();
                cli.Genero = midataReader["Genero"].ToString();
                cli.Precio = Convert.ToDecimal(midataReader["precio"].ToString());
                cli.Notas = midataReader["Notas"].ToString();
                cli.Fecha = midataReader["FechaPubicacion"].ToString();
                cli.Reagalias = midataReader["Regalias"].ToString();

            }
            else
            {
                return null;
            }
            midataReader.Close();
            miCom.Dispose();
            cnConexion.Close();
            return cli;
        }

        public void RestarInventario(clsTitulos objTitulo)
        {
            string sql;
            MySqlCommand cm;
            Conectar();
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@Tituloid", objTitulo.TituloId);
            cm.Parameters.AddWithValue("@Cantidad", objTitulo.Cantidad);

            sql = "UPDATE titulos SET Cantidad = Cantidad - @Cantidad  WHERE Tituloid = @Tituloid";

            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();


        }
    }
}
