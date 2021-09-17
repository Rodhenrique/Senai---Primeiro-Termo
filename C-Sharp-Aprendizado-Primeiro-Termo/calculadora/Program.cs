using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
             double num1 = 0;
            double num2 = 0;
          
            string oper;

            Console.WriteLine("digite o 1º numero");
            num1 = double.Parse(Console.ReadLine());

             Console.WriteLine("digite o 2º numero");
            num2 = double.Parse(Console.ReadLine());

             Console.WriteLine("digite a formular de calculo");
             oper = Console.ReadLine();

            
            switch (oper) {
                case "+":
                 Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
                 break;

                 case "-":
                    Console.WriteLine($"{num1} - {num2} =  {num1 - num2}");
                  break;

                 case "/":
                        Console.WriteLine($"{num1} / {num2} =  {num1 + num2}");
                  break;

                 case "*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                  break;   

                  default:
                   Console.WriteLine("operação invalida!");
                   break;
            }
        }
    }
}
