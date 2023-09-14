using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lingzu.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string NombreProducto { get; set; } = string.Empty;

        [Display(Name = "Precio")]
        [Required]
        [RegularExpression(@"^\d+$")]
        public decimal PrecioProducto { get; set; }

        [Display(Name = "Cantidad")]
        [Required]
        [RegularExpression(@"^\d+$")]
        public int CantidadProducto { get; set; }

        
    }
}