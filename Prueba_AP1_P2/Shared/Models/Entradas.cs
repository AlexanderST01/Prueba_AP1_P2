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
        public int EntradaId { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Concepto { get; set; }
        public double PesoTotal { get; set; }
        public int ProductoId { get; set; }
        public int CantidadProducida { get; set; }
        [ForeignKey("EntradaId")]
        public ICollection<EntredasDetalle> EntredasDetalles { get; set; } = new List<EntredasDetalle>(); 
    }
}
