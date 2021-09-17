using System;

namespace alfabeto
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string[] nomes = new string[4];

            for (int i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Digite um nome");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);

            for (int i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine($"pela ordem vê: " + nomes[i]);
            }
        }
    }
}
