using Contrato.Interfaces;
using SubtracaoAPI.Context;
using SubtracaoAPI.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Models
{
    public class Subtracao : ICalcular
    {
        
        public double Calcular(double valor1, double valor2)
        {
            var subtracaoEntidade = new Entities.Subtracao()
            {
                Valor1 = valor1,
                Valor2 = valor2,
                Resultado = valor1 - valor2
            };

            using (IRepositorio<Entities.Subtracao> repositorio = new Repositorio<Entities.Subtracao>(new SubtracaoContext()))
            {
                repositorio.Adicionar(subtracaoEntidade);
            }

            return subtracaoEntidade.Resultado;
        }

    }
}