using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProjetoEmpresa
{
    public static class OrigemDados
    {
        public static HttpClient WebApiClient = new HttpClient();

        static OrigemDados()
        {
            WebApiClient.BaseAddress = new Uri("https://localhost:44346/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
