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
        [RegularExpression(@"^([0-2][0-9]|(3)[0-1])(\-)(((0)[0-9])|((1)[0-2]))(\-)\d{4}$")]
        public string FechaApertura { get; set; }
        public List<Producto>Productos { get; set; }
    }
}
