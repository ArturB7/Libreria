using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class eTicket
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaFacturacion { get; set; }

        //Creamos una lista con una nueva Instancia de la clase Articulo
        //esta lista contendra el detalle de la factura
        public List<eTitulo> Detail = new List<eTitulo>();
    }
}
