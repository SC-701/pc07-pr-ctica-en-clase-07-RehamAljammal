using Abstracciones.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IList<ProductoResponse> productos { get; set; } = default!;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            //string endpoint = _configuration.ObtenerMetodo("ApiEndPoints", "ObtenerProducto"; 


        }
    }
}
