using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_aplicada2_2017_0826.Models
{
    public class CobrosDetalle
    {
        [Key]
        public int id { get; set; }

        public int cobroId { get; set; }

        public int ventaId { get; set; }

        public double cobrado { get; set; }

        public bool fuePagado { get; set; }
    }
}
