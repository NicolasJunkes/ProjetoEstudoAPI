
using Contrato.Interfaces;

namespace Subtracao
{
    public class Subtracao : ICalcular
    {
        public double Calcule(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}
