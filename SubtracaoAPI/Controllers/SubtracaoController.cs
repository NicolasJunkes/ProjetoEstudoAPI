using SubtracaoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SubtracaoAPI.Controllers
{
    [RoutePrefix("api/subtracao")]
    public class SubtracaoController : ApiController
    {
        [HttpPost]
        [Route("subtrair")]
        public HttpResponseMessage Subtrair([FromBody] SubtracaoParametro parametroSubtracao)
        {
            var resultado = new Subtracao().Calcular(parametroSubtracao.Valor1, parametroSubtracao.Valor2);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, resultado);
        }
    }
}