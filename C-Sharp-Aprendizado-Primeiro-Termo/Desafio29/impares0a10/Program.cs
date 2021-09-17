using System;

namespace impares0a10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("digite até o numero que vai sequencia de impares");
            int num = int.Parse(Console.ReadLine());

            for(int i= 0 ; i <= num; i++)
            {
                    if((i % 2) !=0){
                        Console.WriteLine($"esse numero são impares: {i} ");
                        i++;
                    }
            }
        }
    }
}
