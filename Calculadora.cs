using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double resultado = 0;

                Console.WriteLine("Programa de Calculadora");
                Console.WriteLine("_______________________");

                Console.Write("Ingrese el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese una opcion: ");
                Console.WriteLine("\t + : Sumar");
                Console.WriteLine("\t - : restar");
                Console.WriteLine("\t * : multiplicar");
                Console.WriteLine("\t / : Dividir");

                switch (Console.ReadLine())
                {
                    case "+":
                        resultado = num1 + num2;
                        Console.WriteLine($"Tu resultado {num1} + {num2} = {resultado}");
                        break;

                    case "-":
                        resultado = num1 - num2;
                        Console.WriteLine($"Tu resultado {num1} - {num2} = {resultado}");
                        break;

                    case "*":
                        resultado = num1 * num2;
                        Console.WriteLine($"Tu resultado {num1} * {num2} = {resultado}");
                        break;

                    case "/":
                        resultado = num1 / num2;
                        Console.WriteLine($"Tu resultado {num1} / {num2} = {resultado}");
                        break;

                    default:
                        Console.WriteLine("Esa no es una opcion valida");
                        break;
                }

                Console.Write("Te gustaria continuar? S/N: ");
            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Adios!");
            Console.ReadKey();
        }
    }
}
