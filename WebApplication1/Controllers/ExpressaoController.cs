using System.Web.Http;
using WebApplication1.Servicos;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/expressoes")]
    public class ExpressaoController : ApiController
    {
        //// POST: Adição
        [HttpPut]
        [Route("calcularExpressao/{expressao}")]
        public IHttpActionResult Calculo(string expressao)
        {
            VerificarExpressao verificarExpressao = new VerificarExpressao();
            verificarExpressao.CalcularExpressao(expressao);

            return Ok();
        }

        // POST: Adição

        [HttpGet]
        [Route("teste/{expressao}")]
        public IHttpActionResult Teste(string expressao)
        {
            return Ok(expressao);
        }

        [HttpGet]
        [Route("testeok")]
        public IHttpActionResult TesteOk() =>
            Ok("Deu bom");
    }
}