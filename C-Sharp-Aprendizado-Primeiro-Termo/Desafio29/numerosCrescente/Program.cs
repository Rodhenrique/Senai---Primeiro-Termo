using System;

namespace numerosCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine("digite três numeros: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine($"numeros em ordem crescente: " + numeros[i]);
            }
        }
    }
}
