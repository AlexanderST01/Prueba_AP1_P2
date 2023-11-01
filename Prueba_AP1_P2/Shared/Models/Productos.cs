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
        public int ProductoId { get; set; }

        public string? Descripcion { get; set; }

        public int Tipo { get; set; }

        public double Existencia { get; set; }   
    }
}
