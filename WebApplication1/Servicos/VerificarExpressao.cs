using Contrato;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Servicos
{
    public class VerificarExpressao
    {
        public double CalcularExpressao(ParametroApiExpressao parametro)
        {
            var operador = "";
            if (parametro.Expressao.Contains(Operador.ADICAO)) { operador = Operador.ADICAO; }
            else if (parametro.Expressao.Contains(Operador.SUBTRACAO)) { operador = Operador.SUBTRACAO; }

            if (operador.Contains('+'))
            {
                var resposta = SendRequest(parametro, operador);
                var respostaFinal = resposta.Content.ReadAsStringAsync().Result;
                var resultadoFinal = respostaFinal.Replace(".", ",");
                return Convert.ToDouble(resultadoFinal);

            }
            else
            {
                var resposta = SendRequest(parametro, operador);
                var respostaFinal = resposta.Content.ReadAsStringAsync().Result;
                var resultadoFinal = respostaFinal.Replace(".", ",");
                return Convert.ToDouble(resultadoFinal);
            }
        }

        public Valor MontaExpressao(ParametroApiExpressao parametro, string operador)
        {
            int indexOperador = parametro.Expressao.IndexOf(operador);
            int indexOperadorCalculado = indexOperador + 1;
            var valor1 = parametro.Expressao.Substring(0, indexOperador);
            var valor2 = parametro.Expressao.Substring(indexOperadorCalculado, (parametro.Expressao.Length - indexOperadorCalculado));
            Valor valores = new Valor
            {
                Valor1 = Convert.ToDouble(valor1),
                Valor2 = Convert.ToDouble(valor2)
            };
            return valores;
        }

        public HttpResponseMessage SendRequest(ParametroApiExpressao parametro, string operador)
        {
            HttpClient client = new HttpClient();
            var myContent = JsonConvert.SerializeObject(MontaExpressao(parametro, operador));
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var endereco = "http://localhost";
            var porta = string.Empty;
            var url = string.Empty;
            if (operador.Contains("+"))
            {
                porta = "51266"; //Porta para aplicação de soma
                url = "/api/adicao/adicionar";
            }
            else
            {
                porta = "54496"; //Porta para aplicação de subtração
                url = "/api/subtracao/subtrair";
            }

            client.BaseAddress = new Uri($"{endereco}:{porta}/");
            return client.PostAsync(url, byteContent).Result;
        }
    }
}

