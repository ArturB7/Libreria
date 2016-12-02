using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Datos
{
    class clsEditores
    {
        private int eId;
        private string eNombre;
        private string eCiudad;
        private string eEstado;
        private string ePais;

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "libreria" + ";UID=" + "root" + ";PWD=" + "123tamarindo");

            conectar.Open();
            return conectar;
        }

        public int Id
        {
            get
            {
                return eId;
            }
            set
            {
                eId = value;
            }
        }

        public string Nombre
        {
            get
            {
                return eNombre;
            }
            set
            {
                eNombre = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return eCiudad;
            }
            set
            {
                eCiudad = value;
            }
        }

        public string Estado
        {
            get
            {
                return eEstado;
            }
            set
            {
                eEstado = value;
            }
        }

        public string Pais
        {
            get
            {
                return ePais;
            }
            set
            {
                ePais = value;
            }
        }

    }
}
