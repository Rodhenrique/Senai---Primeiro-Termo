using System;

namespace firenight
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 0;
            double resultado = 0;

            Console.WriteLine("digite a temperatura para converter: ");
            temperatura = double.Parse(Console.ReadLine());
            
            resultado = 1.8 * temperatura + 32;
            System.Console.WriteLine($"sua temperatura em  Fahrenheit {resultado} ªF ");
        }
    }
}
