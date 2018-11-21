using Contrato.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdicaoAPI.Models
{
    public class Adicao : ICalcular
    {
        public double Calcule(double valor1, double valor2)
        {
            double resultado;
            return resultado = valor1 + valor2;
        }
    }

}