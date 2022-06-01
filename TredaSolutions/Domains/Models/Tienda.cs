using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TredaSolutions.Domains.Models
{
    public class Tienda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }
        public List<Producto>Productos { get; set; }
    }
}
