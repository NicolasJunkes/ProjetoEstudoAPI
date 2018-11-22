using Contrato;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Servicos
{
    public class VerificarExpressao
    {
        public void CalcularExpressao(ParametroApiExpressao parametro)
        {
            var operador = "";
            if (parametro.Expressao.Contains(Operador.ADICAO)) { operador = Operador.ADICAO; }
            else if (parametro.Expressao.Contains(Operador.SUBTRACAO)) { operador = Operador.SUBTRACAO; }

            if (operador.Contains('+'))
            {
                int indexOperador = parametro.Expressao.IndexOf(operador);
                int indexOperadorCalculado = indexOperador + 1;
                var valor1 = parametro.Expressao.Substring(0, indexOperador);
                var valor2 = parametro.Expressao.Substring(indexOperadorCalculado, (parametro.Expressao.Length - indexOperadorCalculado));

                HttpClient client = new HttpClient();
                var myContent = JsonConvert.SerializeObject(parametro);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                client.BaseAddress = new Uri("http://localhost:51266");
                var result = client.PostAsync("/api/adicao/adicionar", byteContent).Result;
                
            }
            else
            {
                int indexOperador = parametro.Expressao.IndexOf(operador);
                int indexOperadorCalculado = indexOperador + 1;
                var valor1 = parametro.Expressao.Substring(0, indexOperador);
                var valor2 = parametro.Expressao.Substring(indexOperadorCalculado, (parametro.Expressao.Length - indexOperadorCalculado));

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:50495/Subtracao");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }


        }
            //public void Test()
            //{
            //    using (var client = new HttpClient())
            //    {
            //        var response = client.PostAsync("http://localhost:51266",).GetAwaiter().GetResult();
            //
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var responseContent = response.Content;
            //
            //            // by calling .Result you are synchronously reading the result
            //            string responseString = responseContent.ReadAsStringAsync().Result;
            //
            //            Console.WriteLine(responseString);
            //        }
            //    }
            //}

    }
}
