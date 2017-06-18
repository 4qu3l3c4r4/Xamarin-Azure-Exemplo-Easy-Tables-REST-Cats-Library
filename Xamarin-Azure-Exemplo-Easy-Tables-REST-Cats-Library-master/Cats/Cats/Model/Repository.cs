using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Model
{
    public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            List<Cat> Cats;
            var URLWebAPI = "http://demos.ticapacitacion.com/cats";
            using (var Client = new System.Net.Http.HttpClient())
            {
                var JSON = await Client.GetStringAsync(URLWebAPI);
                Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(JSON);
            }
            return Cats;
        }

        public async Task<List<Cat>> GetCatsAzure()
        {
            //Instancia serviço do azure
            var AzureServices = new Services.AzureServices<Cat>();
            //Espera pegar os valores de tabelas
            var AzureItems = await AzureServices.GetTable();
            //retorna os valores de tabela como List<T>
            return AzureItems.ToList();
        }

    }
}
