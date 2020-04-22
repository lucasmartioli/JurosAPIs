using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculadoraJuros.Domain
{
    public static class TaxasDeJuro
    {
        static string baseUrl = "https://localhost:5001";

        public static async Task<double> RecuperarTaxaAsync()
        {

            using (HttpClient client = new HttpClient())

            using (HttpResponseMessage res = await client.GetAsync(baseUrl + "/taxaJuros"))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    return Double.Parse(data);
                } else
                {
                    throw new Exception();
                }
            }

        }
    }
}
