using System;

namespace multiploDE3
{
    class Program
    {
        static void Main(string[] args)
        {
            int oper = 0;
            Console.WriteLine("Digite um numero: ");
            oper = int.Parse(Console.ReadLine());

            if((oper % 3)==0)
            {
                System.Console.WriteLine($"o numero {oper} e multiplicavel por 3");
            }else
            {
                System.Console.WriteLine($"esse numero {oper} não é multiplicavel por 3");
            }

        }
    }
}
