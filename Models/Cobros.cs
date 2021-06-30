using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Parcial2_aplicada2_2017_0826.Models;

namespace Parcial2_aplicada2_2017_0826.Models
{
    public class Cobros
    {
        [Key]
        public int cobroId { get; set; }

        public DateTime fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe seleccionar un Cliente.")]
        [Range(1,int.MaxValue, ErrorMessage ="Debe seleccionar un Cliente Valido.")]
        public int clienteId { get; set; }

        public int VentaId { get; set; }

        public int TotalPagados { get; set; } = 0;

        public double TotalCobros { get; set; } = 0;

        public string observaciones { get; set; }

        [ForeignKey("cobroId")]
        public virtual List<CobrosDetalle> CobrosDetalles { get; set; } = new List<CobrosDetalle>();
    }
}
