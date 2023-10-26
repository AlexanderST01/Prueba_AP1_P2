using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_AP1_P2.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        [ForeignKey("ProductosId")]
        public ICollection<EntredasDetalle> EntredasDetalles { get; set; } = new List<EntredasDetalle>();
    }
}
