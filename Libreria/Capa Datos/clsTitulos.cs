using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Datos
{
    class clsTitulos
    {
        private int tTituloId;
        private string tNombre;
        private string tGenero;
        private decimal tPrecio;
        private string tNotas;
        private DateTime tFecha;
        private string tRegalias;

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "libreria" + ";UID=" + "root" + ";PWD=" + "123tamarindo");

            conectar.Open();
            return conectar;
        }

        public int TituloId
        {
            get
            {
                return tTituloId;
            }
            set
            {
                tTituloId = value;
            }

        }

        public string Nombre
        {
            get
            {
                return tNombre;
            }
            set
            {
                tNombre = value;
            }
        }

        public string Genero
        {
            get
            {
                return tGenero;
            }
            set
            {
                tGenero = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return tPrecio;
            }
            set
            {
                tPrecio = value;
            }
        }

        public string Notas
        {
            get
            {
                return tNotas;
            }
            set
            {
                tNotas = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return tFecha;
            }
            set
            {
                tFecha = value;
            }
        }

        public string Reagalias
        {
            get
            {
                return tRegalias;
            }
            set
            {
                tRegalias = value;
            }
        }
    }
}
