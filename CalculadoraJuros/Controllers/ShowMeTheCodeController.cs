using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculadoraJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "https://github.com/lucasmartioli/JurosAPIs";
        }
    }
}
