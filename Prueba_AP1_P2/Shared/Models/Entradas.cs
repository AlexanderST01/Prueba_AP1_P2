using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Prueba_AP1_P2.Shared.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(100,ErrorMessage = "El campo concepto no debe ser mayor a 100 caracteres")]
        public string Concepto { get; set; }
        public double PesoTotal { get; set; }
        public int ProductoId { get; set; }
        public double CantidadProducida { get; set; }
        [ForeignKey("EntradaId")]
        public ICollection<EntredasDetalle> EntradasDetalles { get; set; } = new List<EntredasDetalle>(); 
    }
}
