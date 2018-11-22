using AdicaoAPI.Models;
using System.Web.Http;

namespace AdicaoAPI.Controllers
{
    [RoutePrefix("api/adicao")]
    public class AdicaoController : ApiController
    {
        public AdicaoController()
        {
        }

        [HttpPost, Route("adicionar")]
        public double Adicionar([FromBody]string byteContent)
        {
            double resultadoFinal;
            Adicao adicao = new Adicao();
            resultadoFinal = adicao.Calcule();
            return resultadoFinal; 
        }
    }
}