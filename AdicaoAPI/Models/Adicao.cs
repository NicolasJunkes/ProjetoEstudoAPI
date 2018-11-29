using AdicaoAPI.Repository;
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
            var adicaoEntidade = new Entities.Adicao()
            {
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = valor1 + valor2
            };

            using (IRepositorio<Entities.Adicao> repositorio = new Repositorio<Entities.Adicao>(new Controllers.AdicaoContext()))
            {
                repositorio.Adicionar(adicaoEntidade);
            }
            return adicaoEntidade.Resultado;
        }
    }

}