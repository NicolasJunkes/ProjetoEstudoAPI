using Contrato.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdicaoAPI.Models
{
    public class Adicao : ICalcular
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }

}