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
            Console.WriteLine("TESTANDO O MÉTODO DE SOMA");
            Console.WriteLine();
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

            //Soma de números negativos
            Console.WriteLine();
            Console.WriteLine("Soma de números negativos");

            result = c.Somar(-2, +(-2));

            if (result == -4)
            {
                Console.WriteLine("Soma realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Soma de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Soma de número negativo e positivo");

            result = c.Somar(-2, 5);

            if (result == 3)
            {
                Console.WriteLine("Soma realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("TESTANDO O MÉTODO DE SUBTRAIR");
            Console.WriteLine();
            Console.WriteLine("Subtração de números inteiros");

            result = c.Subtrair(2, 2);
            if (result == 0)
            {
                Console.WriteLine("Subtração realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Subtração de números decimais
            Console.WriteLine();
            Console.WriteLine("Subtração de números decimais");

            result = c.Subtrair(3.7, 2.5);

            if (result == 1.2)
            {
                Console.WriteLine("Subtração realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Subtração de números negativos
            Console.WriteLine();
            Console.WriteLine("Soma de números negativos");

            result = c.Subtrair(-2, (-2));

            if (result == 0)
            {
                Console.WriteLine("Subtração realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Subtração de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Subtração de número negativo e positivo");

            result = c.Subtrair(-2, 5);

            if (result == 3)
            {
                Console.WriteLine("Subtração realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("TESTANDO O MÉTODO DE MULTIPLICAR");
            Console.WriteLine();
            Console.WriteLine("Multiplicação de números inteiros");

            result = c.Multiplicar(2, 2);
            if (result == 4)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Multiplicação de números decimais
            Console.WriteLine();
            Console.WriteLine("Multiplicação de números decimais");

            result = c.Multiplicar(2.5, 2.5);

            if (result == 6.25)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Multiplicação de números negativos
            Console.WriteLine();
            Console.WriteLine("Multiplicação de números negativos");

            result = c.Multiplicar(-2, (-2));

            if (result == 4)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Multiplicação de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Multiplicação de número negativo e positivo");

            result = c.Multiplicar(-2, 5);

            if (result == -10)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Multiplicação por 0
            Console.WriteLine();
            Console.WriteLine("Multiplicação de número negativo e positivo");

            result = c.Multiplicar(2, 0);

            if (result == 0)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("TESTANDO O MÉTODO DE DIVIDIR");
            Console.WriteLine();
            Console.WriteLine("Divisão de números inteiros");

            result = c.Dividir (10, 2);
            if (result == 5)
            {
                Console.WriteLine("Divisão realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Divisão de números decimais
            Console.WriteLine();
            Console.WriteLine("Divisão de números decimais");

            result = c.Dividir(10.5, 2.5);

            if (result == 4.2)
            {
                Console.WriteLine("Multiplicação realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Divisão de números negativos
            Console.WriteLine();
            Console.WriteLine("Divisão de números negativos");

            result = c.Dividir(-10, (-2));

            if (result == 5)
            {
                Console.WriteLine("Divisão realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Divisão de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Divisão de número negativo e positivo");

            result = c.Dividir(-10, 5);

            if (result == -2)
            {
                Console.WriteLine("Divisão realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Divisão de um número 0 por outro
            Console.WriteLine();
            Console.WriteLine("Divisão por 0");

            result = c.Dividir(0, 5);

            if (result == 0)
            {
                Console.WriteLine("Divisão realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Divisão de um número por 0
            Console.WriteLine();
            Console.WriteLine("Divisão de um número por 0");

            result = c.Dividir(5, 0);

            if (result == 0)
            {
                Console.WriteLine("Divisão realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            bool r = true;

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("TESTANDO O MÉTODO DE MENOR QUE");
            Console.WriteLine();
            Console.WriteLine("Divisão de números inteiros");

            result = c.MenorNumero(2, 10);
            if (result == 2)
            {
                Console.WriteLine("Menor que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Menor que números decimais
            Console.WriteLine();
            Console.WriteLine("Menor que de números decimais");

            result = c.MenorNumero(2.5, 10.5);

            if (result == 2.5)
            {
                Console.WriteLine("Menor que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Menor que de números negativos
            Console.WriteLine();
            Console.WriteLine("Menor que de números negativos");

            result = c.MenorNumero(-10 , - 2 );

            if (result == -10)
            {
                Console.WriteLine("Menor que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Menor que de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Menor que de número negativo e positivo");

            result = c.MenorNumero(-10, 5);

            if (result == -10)
            {
                Console.WriteLine("Menor que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("TESTANDO O MÉTODO DE MAIOR QUE");
            Console.WriteLine();
            Console.WriteLine("Maior que de números inteiros");

            result = c.MaiorNumero(2, 10);
            if (result==10)
            {
                Console.WriteLine("Maior que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Maior que de números decimais
            Console.WriteLine();
            Console.WriteLine("Maior que de números decimais");

            result = c.Somar(10.5, 2.5);

            if (result == 10.5)
            {
                Console.WriteLine("Maior que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Maior que de números negativos
            Console.WriteLine();
            Console.WriteLine("Maior que de números negativos");

            result = c.Somar(-10, -2);

            if (result == -2)
            {
                Console.WriteLine("Maior que realizada com sucesso.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
                Console.ReadKey();
            }

            //Maior que de número negativo e positivo
            Console.WriteLine();
            Console.WriteLine("Maior que de número negativo e positivo");

            result = c.Somar(-10, 5);

            if (result == 5)
            {
                Console.WriteLine("Maior que realizada com sucesso.");
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
