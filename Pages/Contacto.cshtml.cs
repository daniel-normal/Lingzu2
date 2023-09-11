using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lingzu.Pages
{
    public class ContactoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string GitHub { get; set; }
        public string CorreoElectronico { get; set; }
    }

}
