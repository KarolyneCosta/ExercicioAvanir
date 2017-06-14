using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClasses
{
    public class Calculadora
    {
        private double resultado;

        public double Somar(double n1, double n2)
        {
            resultado = n1 + n2;

            return resultado;
        }

        public double Multiplicar(double n1, double n2)
        {
            resultado = n1 * n2;

            return resultado;
        }

        public double Dividir(double n1, double n2)
        {
            resultado = n1 / n2;

            return resultado;
        }

        public double Subtrair(double n1, double n2)
        {
            resultado = n1 - n2;

            return resultado;
        }

    }
}
