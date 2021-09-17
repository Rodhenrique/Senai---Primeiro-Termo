using System;

namespace calculadora2
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

             if(oper == "+"){
                 Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
             } else if(oper =="-"){
                    Console.WriteLine($"{num1} - {num2} =  {num1 - num2}");
             } else if(oper =="*"){

                    Console.WriteLine($"{num1} * {num2} =  {num1 * num2}");
             }else if(oper == "/"){
                    Console.WriteLine($"{num1} / {num2} =  {num1 / num2}");
             }else if (oper == "%"){
                    Console.WriteLine($"{num1} % {num2} =  {num1 % num2}");
             }else {
                 Console.WriteLine("operação invalida");
             }
             } 
            

        }
    }

