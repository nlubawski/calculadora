using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();

        }
        static void Soma(){
            
            Console.Clear();
            Console.WriteLine("Primeiro valor ");
            var primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ");
            var segundoValor = float.Parse(Console.ReadLine());
            var resultado = primeiroValor + segundoValor;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é {resultado}");
        }
    }
}
