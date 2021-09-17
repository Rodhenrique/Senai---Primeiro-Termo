using System;

namespace calculadora6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double media = 0;
          

            Console.Write("digite o 1º numero ");
            num1 = double.Parse(Console.ReadLine());

             Console.Write("digite o 2º numero ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("digite o 1º numero ");
            num3 = double.Parse(Console.ReadLine());

             Console.Write("digite o 2º numero ");
            num4 = double.Parse(Console.ReadLine());

             media = (num1 + num2 + num3 + num4) /4;

             Console.WriteLine("e sua media " + media);

             if(media > 9.0){
                 Console.WriteLine("parabéns você passou!");
             }else if ((media >= 7.0) && (media < 9.0)) {
                 Console.WriteLine("aee... passou na casca né!");
             }else {
                 Console.WriteLine("que pena, você reprovou.estude mais da proxima vez");
             }

        }
    }
}
