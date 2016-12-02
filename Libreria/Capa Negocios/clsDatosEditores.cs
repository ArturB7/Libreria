using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Libreria.Capa_Datos;

namespace Libreria.Capa_Negocios
{
    class clsDatosEditores
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

        public void AgregarEditor(clsEditores objEditor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@editorid", objEditor.Id);
            cm.Parameters.AddWithValue("@nombre", objEditor.Nombre);
            cm.Parameters.AddWithValue("@ciudad", objEditor.Ciudad);
            cm.Parameters.AddWithValue("@estado", objEditor.Estado);
            cm.Parameters.AddWithValue("@pais", objEditor.Pais);
            

            sql = "INSERT INTO editorial (Pub_id, NombreEditorial, Ciudad, Estado, Pais) VALUES (@editorid, @nombre, @ciudad, @estado, @pais)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public clsEditores getEditorById(string EditorId)
        {
            clsEditores objEditor = new clsEditores();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM editorial WHERE Pub_id = @editorId";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@editorId", EditorId);
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                objEditor.Id = dr.GetInt32("Pub_id");
                objEditor.Nombre = dr.GetString("Nombre");
                objEditor.Ciudad = dr.GetString("Ciudad");
                objEditor.Estado = dr.GetString("Estado");
                objEditor.Pais = dr.GetString("Pais");


                Cerrar();
                return objEditor;
            }
            else
            {
                Cerrar();
                return null;
            }
        }

        public void ModificarEditor(clsEditores objEditor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@autorid", objEditor.Id);
            cm.Parameters.AddWithValue("@nombre", objEditor.Nombre);
            cm.Parameters.AddWithValue("@ciudad", objEditor.Ciudad);
            cm.Parameters.AddWithValue("@estado", objEditor.Estado);
            cm.Parameters.AddWithValue("@pais", objEditor.Pais);


            sql = "UPDATE editorial SET Pub_id = @autorid, Nombre = @nombre, Ciudad = @ciudad, Estado = @estado, Pais = @pais";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public void EliminarEditor(clsEditores objEditor)
        {
            string sql;
            MySqlCommand cm;
            Conectar();

            cm = new MySqlCommand();
            sql = "DELETE FROM editorial WHERE Pub_id = '" + objEditor.Id + "'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = cnConexion;
            cm.ExecuteNonQuery();
            Cerrar();
        }

        public List<clsEditores> getEditores()
        {
            List<clsEditores> lstEditores = new List<clsEditores>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT * FROM editorial";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                clsEditores objEditor = new clsEditores();

                objEditor.Id = dr.GetInt32("Pub_id");
                objEditor.Nombre = dr.GetString("Nombre");
                objEditor.Ciudad = dr.GetString("Ciudad");
                objEditor.Estado = dr.GetString("Estado");
                objEditor.Pais = dr.GetString("Pais");

                lstEditores.Add(objEditor);
            }

            Cerrar();
            return lstEditores;
        }

        public static List<clsEditores> Buscar(string EditorId)
        {
            List<clsEditores> _lista = new List<clsEditores>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Pub_id, NombreEditorial, Ciudad, Estado, Pais FROM editorial where Pub_id ='{0}'", EditorId), clsEditores.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsEditores pEditor = new clsEditores();

                pEditor.Id = _reader.GetInt32(0);
                pEditor.Nombre = _reader.GetString(1);
                pEditor.Ciudad = _reader.GetString(2);
                pEditor.Estado = _reader.GetString(3);
                pEditor.Pais = _reader.GetString(4);


                _lista.Add(pEditor);
            }

            return _lista;
        }

        public clsEditores buscarProducto(ref clsEditores cli)
        {
            Conectar();
            string consulta = "Select * from editorial where Pub_id= " + cli.Id;
            MySqlCommand miCom = new MySqlCommand(consulta, cnConexion);
            MySqlDataReader midataReader = miCom.ExecuteReader();
            midataReader.Read();
            if (midataReader.HasRows)
            {
                cli.Id = Convert.ToInt32(midataReader["Pub_id"].ToString());
                cli.Nombre = midataReader["Nombre"].ToString();
                cli.Ciudad = midataReader["Ciudad"].ToString();
                cli.Estado = midataReader["Estado"].ToString();
                cli.Pais = midataReader["Pais"].ToString();

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
    }
}
