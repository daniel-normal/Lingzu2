using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lingzu.Models
{
    public class Venta
    {
        public int VentaId { get; set; }

        [Display(Name = "Fecha")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Número de Factura")]
        [Required]
        [StringLength(35, MinimumLength = 1)]
        [RegularExpression(@"^\d+$")]
        public string NumeroVenta { get; set; } = string.Empty;

        
      

        //agregar propiedad de ralacion
        public Cliente? Clientes { get; set; }
    }
}