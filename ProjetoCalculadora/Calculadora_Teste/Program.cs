using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClasses;

namespace Calculadora_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Calculadora c = new Calculadora();

            result = c.Somar(2,2);

            Console.WriteLine("O resultado é: " + result);
            Console.ReadKey();

        }
    }
}
