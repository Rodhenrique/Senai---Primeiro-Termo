using System;

namespace conjugação
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper;

            System.Console.WriteLine("Digite seu verbo no infinitivo: ");
            oper = Console.ReadLine();

            oper.ToLower();

            if (oper.EndsWith("ar"))
            {
                System.Console.WriteLine($"esse verbo {oper} está em 1ª Conjugação");
            }else if (oper.EndsWith("er"))
            {
                System.Console.WriteLine($"esse verbo {oper} está em 2ª Conjugação");
            }else if(oper.EndsWith("ir"))
            {
                System.Console.WriteLine($"esse verbo {oper} está em 3ª Conjugação");
            }else 
            {
                System.Console.WriteLine($"isso não é {oper} não corresponde a verbo!!!");
            }
            
        }
    }
}
