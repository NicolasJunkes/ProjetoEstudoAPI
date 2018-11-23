using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Servicos;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/expressoes")]
    public class ExpressaoController : ApiController
    {
        //// POST
        [HttpPost]
        [Route("calcularExpressao")]
        public HttpResponseMessage Calculo([FromBody] ParametroApiExpressao parametro)
        {
            VerificarExpressao verificarExpressao = new VerificarExpressao();
            var resultado = verificarExpressao.CalcularExpressao(parametro);

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, resultado );
        }
    }
}