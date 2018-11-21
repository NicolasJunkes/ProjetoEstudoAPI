using Contrato;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebApplication1.Servicos
{
    public class VerificarExpressao
    {
        public void CalcularExpressao(string expressao)
        {
            var operador = "";
            if (expressao.Contains(Operador.ADICAO)) { operador = Operador.ADICAO; }
            else if (expressao.Contains(Operador.SUBTRACAO)) { operador = Operador.SUBTRACAO; }

            if (operador.Contains('+'))
            {
                int indexOperador = expressao.IndexOf(operador);
                var valor1 = expressao.Substring(0, indexOperador);
                var valor2 = expressao.Substring((indexOperador + 1), expressao.Length);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:50495/Adicao");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
            else
            {
                int indexOperador = expressao.IndexOf(operador);
                var valor1 = expressao.Substring(0, indexOperador);
                var valor2 = expressao.Substring((indexOperador + 1), expressao.Length);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:50495/Subtracao");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
    }
}