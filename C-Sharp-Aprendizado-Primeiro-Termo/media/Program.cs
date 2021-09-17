using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double resultado = 0;

            Console.WriteLine("digite o 1º numero");
            num1 = double.Parse(Console.ReadLine());

             Console.WriteLine("digite o 2º numero");
            num2 = double.Parse(Console.ReadLine());

              Console.WriteLine("digite o 3º numero");
            num3 = double.Parse(Console.ReadLine());

             Console.WriteLine("digite o 4º numero");
            num4 = double.Parse(Console.ReadLine());
            
            resultado = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("sua media é " + resultado);

          
        }
    }
}
