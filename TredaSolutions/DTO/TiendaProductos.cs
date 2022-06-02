using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TredaSolutions.DTO
{
    public class TiendaProductos
    {
        public string NombreProducto { get; set; }
        public int SKU { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public string NombreTienda { get; set; }
        public DateTime FechaAperturaTienda { get; set; }
    }
}
