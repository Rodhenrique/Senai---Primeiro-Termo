using System;

namespace velocidademedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0;
            double v = 0;
            double r = 0;
            double r2 = 0;


            Console.WriteLine("digite o tempo: ");
            d = double.Parse(Console.ReadLine());

             Console.WriteLine("digite a velocidade: ");
            v = double.Parse(Console.ReadLine());

            
            r = (d * v) / 12 ;
            r2 = d * v;


            System.Console.WriteLine($"seu carro gastou de gasolina {r} litros e velocidade de {r2}km/h");
        }
    }
}
