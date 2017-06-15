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

            Console.WriteLine("Soma de números inteiros");
            result = c.Somar(2, 2);

            if (result == 4)
            {
                Console.WriteLine("Soma realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Soma de números decimais
            Console.WriteLine();
            Console.WriteLine("Soma de números decimais");

            result = c.Somar(2.5, 2.5);

            if (result == 5)
            {                
                Console.WriteLine("Soma realizada com sucesso.");
                Console.ReadKey();            
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }





        }
    }
}
