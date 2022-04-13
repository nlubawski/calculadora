using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicao();

        }
        static void Menu()
        {
            
        }
        static void Soma()
        {
        Console.Clear();
        Console.WriteLine("Primeiro valor ");
        var primeiroValor = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor ");
        var segundoValor = float.Parse(Console.ReadLine());
        var resultado = primeiroValor + segundoValor;

        Console.WriteLine();
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor ");
            var primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ");
            var segundoValor = float.Parse(Console.ReadLine());

            var resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();

        }
        static void Multiplicao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor ");
            var primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ");
            var segundoValor = float.Parse(Console.ReadLine());

            var resultado = primeiroValor * segundoValor;

            Console.WriteLine($"O resultado é {resultado}");
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor ");
            var primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ");
            var segundoValor = float.Parse(Console.ReadLine());

            var resultado = primeiroValor/segundoValor;

            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();

        }
    }
}
