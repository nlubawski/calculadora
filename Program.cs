using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Olá, o que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção: ");
            short resultado = short.Parse(Console.ReadLine());

            switch(resultado){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;
            }


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
        Menu();
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
            Menu();

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
            Menu();
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
            Menu();

        }
    }
}
