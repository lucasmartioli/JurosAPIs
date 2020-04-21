using Microsoft.AspNetCore.Mvc;

namespace TaxaJurosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public double Get()
        {
            return TaxasDeJuro.TaxaFixa;
        }
    }
}
