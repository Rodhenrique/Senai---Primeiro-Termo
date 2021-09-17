using System;

namespace piramideinvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;

            Console.WriteLine("digite a altura da piramide");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                for (int j = altura; j > i; j--)  
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
