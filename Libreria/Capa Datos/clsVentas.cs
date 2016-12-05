using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Libreria.Capa_Datos
{
    class clsVentas
    {
        private int vIdVenta;
        private DateTime vfecha;
        private int vidTitulo;
        private int vCantidad;

        public int IdVenta
        {
            get
            {
                return vIdVenta;
            }
            set
            {
                vIdVenta = value;
            }
        }

        public int IdTitulo
        {
            get
            {
                return vidTitulo;
            }
            set
            {
                vidTitulo = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return vfecha;
            }
            set
            {
                vfecha = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return vCantidad;
            }
            set
            {
                vCantidad = value;
            }
        }

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "libreria" + ";UID=" + "root" + ";PWD=" + "123tamarindo");

            conectar.Open();
            return conectar;
        }

    }
}
