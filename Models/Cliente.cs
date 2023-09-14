using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lingzu.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Display(Name = "Apellido Paterno")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(35, MinimumLength = 1)]
        [Required]
        public string ApellidoP { get; set; } = string.Empty;

        [Display(Name = "Apellido Materno")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(35, MinimumLength = 1)]
        public string ApellidoM { get; set; } = string.Empty;

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(35, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "NIT")]
        [StringLength(35, MinimumLength = 4)]
        [RegularExpression(@"^\d+$")]
        public string Nit { get; set; } = string.Empty;

        // Agregar una colección de ventas relacionadas
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
