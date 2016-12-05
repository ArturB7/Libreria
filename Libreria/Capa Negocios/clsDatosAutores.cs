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
    class clsDatosAutores
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

        public void AgregarAutor(clsAutores objAutor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@autorid", objAutor.Autorid);
            cm.Parameters.AddWithValue("@nombre", objAutor.Nombre);
            cm.Parameters.AddWithValue("@apellido", objAutor.Apellido);
            cm.Parameters.AddWithValue("@telefono", objAutor.Telefono);
            cm.Parameters.AddWithValue("@direccion", objAutor.Direccion);
            cm.Parameters.AddWithValue("@ciudad", objAutor.Ciudad);
            cm.Parameters.AddWithValue("@estado", objAutor.Estado);
            cm.Parameters.AddWithValue("@codigo", objAutor.CodigoPostal);

            sql = "INSERT INTO autores (idAutor, Nombre, Apellido, telefono, Direccion, Ciudad, Estado, CodigoPostal) VALUES (@autorid, @nombre, @apellido, @telefono, @direccion, @ciudad, @estado, @codigo)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public clsAutores getAutoresById(string AutorId)
        {
            clsAutores objAutor = new clsAutores();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM autores WHERE idAutor = @AutorId";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@AutorId", AutorId);
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                objAutor.Autorid = dr.GetInt32("idAutor");
                objAutor.Nombre = dr.GetString("Nombre");
                objAutor.Apellido = dr.GetString("Apellido");
                objAutor.Telefono = dr.GetString("telefono");
                objAutor.Direccion = dr.GetString("Direccion");
                objAutor.Ciudad = dr.GetString("Ciudad");
                objAutor.Estado = dr.GetString("Estado");
                objAutor.CodigoPostal = dr.GetInt32("CodigoPostal");


                Cerrar();
                return objAutor;
            }
            else
            {
                Cerrar();
                return null;
            }
        }

        public void ModificarAutor(clsAutores objAutor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@autorid", objAutor.Autorid);
            cm.Parameters.AddWithValue("@nombre", objAutor.Nombre);
            cm.Parameters.AddWithValue("@apellido", objAutor.Apellido);
            cm.Parameters.AddWithValue("@telefono", objAutor.Telefono);
            cm.Parameters.AddWithValue("@direccion", objAutor.Direccion);
            cm.Parameters.AddWithValue("@ciudad", objAutor.Ciudad);
            cm.Parameters.AddWithValue("@estado", objAutor.Estado);
            cm.Parameters.AddWithValue("@codigo", objAutor.CodigoPostal);


            sql = "UPDATE autores SET idAutor = @autorid, Nombre = @nombre, Apellido = @apellido, telefono = @telefono, Direccion = @direccion, Ciudad = @ciudad, Estado = @estado, CodigoPostal = @codigo";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public void EliminarAutor(clsAutores objAutor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            sql = "DELETE FROM autores WHERE idAutor = '" + objAutor.Autorid + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public List<clsAutores> getAutores()
        {
            List<clsAutores> lstAutores = new List<clsAutores>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM autores";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                clsAutores objAutor = new clsAutores();

                objAutor.Autorid = dr.GetInt32("idAutor");
                objAutor.Nombre = dr.GetString("Nombre");
                objAutor.Apellido = dr.GetString("Apellido");
                objAutor.Telefono = dr.GetString("telefono");
                objAutor.Direccion = dr.GetString("Direccion");
                objAutor.Ciudad = dr.GetString("Ciudad");
                objAutor.Estado = dr.GetString("Estado");
                objAutor.CodigoPostal = dr.GetInt32("CodigoPostal");


                lstAutores.Add(objAutor);
            }

            Cerrar();
            return lstAutores;
        }

        public static List<clsAutores> Buscar(string AutorId)
        {
            List<clsAutores> _lista = new List<clsAutores>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idAutor, Nombre, Apellido, telefono, Direccion, Ciudad, Estado, CodigoPostal FROM autores where idAutor ='{0}'", AutorId), clsAutores.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsAutores pAutor = new clsAutores();

                pAutor.Autorid = _reader.GetInt32(0);
                pAutor.Nombre = _reader.GetString(1);
                pAutor.Apellido = _reader.GetString(2);
                pAutor.Telefono = _reader.GetString(3);
                pAutor.Direccion = _reader.GetString(4);
                pAutor.Ciudad = _reader.GetString(5);
                pAutor.Estado = _reader.GetString(6);
                pAutor.CodigoPostal = _reader.GetInt32(6);


                _lista.Add(pAutor);
            }

            return _lista;
        }

        public clsAutores buscarAutor(ref clsAutores cli)
        {
            Conectar();
            string consulta = "Select * from autores where idAutor= " + cli.Autorid;
            MySqlCommand miCom = new MySqlCommand(consulta, cnConexion);
            MySqlDataReader midataReader = miCom.ExecuteReader();
            midataReader.Read();
            if (midataReader.HasRows)
            {
                cli.Autorid = Convert.ToInt32(midataReader["idAutor"].ToString());
                cli.Nombre = midataReader["Nombre"].ToString();
                cli.Apellido = midataReader["Apellido"].ToString();
                cli.Telefono = midataReader["telefono"].ToString();
                cli.Direccion = midataReader["Direccion"].ToString();
                cli.Ciudad = midataReader["Ciudad"].ToString();
                cli.Estado = midataReader["Estado"].ToString();
                cli.CodigoPostal = Convert.ToInt32(midataReader["CodigoPostal"].ToString());

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

        public static implicit operator clsDatosAutores(clsDatosTitulos v)
        {
            throw new NotImplementedException();
        }
    }
}
