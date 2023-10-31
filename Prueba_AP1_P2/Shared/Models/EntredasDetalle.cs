using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_AP1_P2.Shared.Models
{
    public class EntredasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
       
        public int EntradaId { get; set; }
     
        public int ProductoId { get; set; }
        
        public double CantidadUtilizada { get; set; }
    }
}
