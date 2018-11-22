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
        public IHttpActionResult Calculo([FromBody] ParametroApiExpressao parametro)
        {
            VerificarExpressao verificarExpressao = new VerificarExpressao();
            verificarExpressao.CalcularExpressao(parametro);
            return null;
        }
    }
}