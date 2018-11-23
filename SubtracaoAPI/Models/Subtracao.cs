using Contrato.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Models
{
    public class Subtracao : ICalcular
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}