using System;

namespace RetanguloAreaEperimento
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double resultadoArea = 0;
            double resultadoPerimetro = 0;
            double resultadoDiagonal = 0;




            System.Console.WriteLine("Digite a base do retangulo");
            num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o lado do retangulo");
            num2 = double.Parse(Console.ReadLine());

            resultadoArea = (num1 * num2);
            resultadoPerimetro = 2 * (num1 + num2);
            resultadoDiagonal = (num1 * num1) + (num2 * num2);



            System.Console.WriteLine($"a area do retangulo é {resultadoArea}");
            System.Console.WriteLine($"o perimetro do retangulo é {resultadoPerimetro}");
            System.Console.WriteLine($"a sua diagonal do retangulo é {resultadoDiagonal}");




        }
    }
}
