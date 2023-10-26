using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_AP1_P2.Shared.Models
{
    public class EntredasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int ProductoId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo esta fuera de rango")]
        public double CantidadUtilizada { get; set; }
    }
}
