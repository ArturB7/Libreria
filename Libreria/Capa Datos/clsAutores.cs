using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Datos
{
    class clsAutores
    {
        private int aAutorId;
        private string aNombre;
        private string aApellido;
        private string aTelefono;
        private string aDireccion;
        private string aCiudad;
        private string aEstado;
        private int aCodigoPostal;

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "libreria" + ";UID=" + "root" + ";PWD=" + "123tamarindo");

            conectar.Open();
            return conectar;
        }

        public int Autorid
        {
            get
            {
                return aAutorId;
            }
            set
            {
                aAutorId = value;
            }
        }

        public string Nombre
        {
            get
            {
                return aNombre;
            }
            set
            {
                aNombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return aApellido;
            }
            set
            {
                aApellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return aTelefono;
            }
            set
            {
                aTelefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return aDireccion;
            }
            set
            {
                aDireccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return aCiudad;
            }
            set
            {
                aCiudad = value;
            }
        }

        public string Estado
        {
            get
            {
                return aEstado;
            }
            set
            {
                aEstado = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return aCodigoPostal;
            }
            set
            {
                aCodigoPostal = value;
            }
        }

       
    }
}
