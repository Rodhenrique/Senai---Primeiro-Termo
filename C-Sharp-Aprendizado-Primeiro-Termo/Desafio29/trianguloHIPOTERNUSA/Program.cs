using System;

namespace trianguloHIPOTERNUSA
{
    class Program
    {
        static void Main(string[] args)
        {
                int num1,num2,num3;


                System.Console.WriteLine("digite três numeros: ");
                num1 = int.Parse(Console.ReadLine());

                System.Console.WriteLine("digite três numeros: ");
                num2 = int.Parse(Console.ReadLine());

                System.Console.WriteLine("digite três numeros: ");
                num3 = int.Parse(Console.ReadLine());

                if ((num1 == num2) && (num3 == num2) && (num3 == num1))
                {
                    System.Console.WriteLine("esse numeros serve para ser um Triângulo Equilátero!!!");
                }else if((num1 != num3) && (num2 != num3) && (num1 != num2))
                {
                    System.Console.WriteLine("esse numeros serve para ser um Triângulo Escaleno!!!");
                }else 
                {
                    System.Console.WriteLine("esse numeros serve para ser um Triângulo Isósceles!!!");
                }
        }
    }
}
