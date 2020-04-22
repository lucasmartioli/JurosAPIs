using System;
using System.Threading.Tasks;
using CalculadoraJuros.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private async Task<double> RecuperarTaxaDeJurosAsync() => await TaxasDeJuro.RecuperarTaxaAsync();

        [HttpGet]
        public async Task<double> GetAsync([FromQuery(Name = "valorinicial")] double? valorInicial,
            [FromQuery(Name = "meses")] int? meses)
        {

            if (valorInicial == null)
            {
                throw new ArgumentNullException("valorinicial");
            }

            if (meses == null)
            {
                throw new ArgumentNullException("meses");
            }

            double result = JurosCompostos.Calcular(valorInicial.Value, await RecuperarTaxaDeJurosAsync(), meses.Value);
            result = Math.Truncate(100 * result) / 100;
            
            return result;
        }
    }
}