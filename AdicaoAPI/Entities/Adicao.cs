using System.ComponentModel.DataAnnotations;

namespace AdicaoAPI.Entities
{
    public class Adicao
    {
        [Key]
        public int Id { get; set; }
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }
    }
}