using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TredaSolutions.Domains.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SKU { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Valor { get; set; }
        [Required]
        public int TiendaId { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
