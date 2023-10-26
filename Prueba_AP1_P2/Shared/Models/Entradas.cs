using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_AP1_P2.Shared.Models
{
    public class Entradas
    {
        [Key]
        public int EntradasId { get; set; }
        [Required(ErrorMessage ="El campo es obligatorio")]
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "El campo esta fuera de rango")]
        public double PesoTotal { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int ProductoId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo esta fuera de rango")]
        public int CantidadProducida { get; set; }
        [ForeignKey("EntradasId")]
        public ICollection<EntredasDetalle> EntredasDetalles { get; set; } = new List<EntredasDetalle>(); 
    }
}
