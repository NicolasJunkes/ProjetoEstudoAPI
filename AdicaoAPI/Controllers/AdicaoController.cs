using AdicaoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdicaoAPI.Controllers
{
    public class AdicaoController : Controller
    {
        // GET: Adicao
        [HttpPost]
        public double Adicionar(double valor1, double valor2)
        {
            Adicao adicao = new Adicao();
            return adicao.Calcule(valor1,valor2);
        }
    }
}