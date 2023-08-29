using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    public class Moneda
    {
        public string Nombre { get; set; }
    }
    //++1. Ruta
    //[Route("api/[controller]")]
    [Route("api/monedas")]

    //++2. Controlador tipo API
    [ApiController]


    public class MonedasController : ControllerBase //+3. Hereda de controllador api
    {
        [HttpGet]
        public ActionResult<IEnumerable<Moneda>> ObtenerMonedas() 
        {
            var lista = new List<Moneda>()
            {
                new Moneda
                {
                    Nombre = "Euro"
                }
            };

            return Ok(lista);
        }
    }
}
