using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SubtracaoAPI.Entities
{
    public class Subtracao
    {
        [Key]
        public int Id { get; set; }
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }

    }
}