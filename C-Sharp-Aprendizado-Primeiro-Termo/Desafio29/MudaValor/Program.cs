using System;

namespace MudaValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            int num3;

            Console.WriteLine("Digite o primeiro valor: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            num3 = num;
            num = num2;
            num2 = num3;

            System.Console.WriteLine($"valor da variavel 1: {num}");
            System.Console.WriteLine($"valor da variavel 2: {num2}");

        }
    }
}
