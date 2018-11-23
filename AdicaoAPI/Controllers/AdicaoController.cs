using AdicaoAPI.Models;
using System.Net.Http;
using System.Web.Http;

namespace AdicaoAPI.Controllers
{
    [RoutePrefix("api/adicao")]
    public class AdicaoController : ApiController
    {
        public AdicaoController(){
        }

        [HttpPost]
        [Route("adicionar")]
        public HttpResponseMessage Adicionar([FromBody]AdicaoParametro parametroAdicao)
        {
            var resultado = new Adicao().Calcular(parametroAdicao.Valor1, parametroAdicao.Valor2);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, resultado);
        }
    }
}