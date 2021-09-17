using System;

namespace planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double planetaJUPITER, planetaMERCURIO,planetaVENUS,planetaMARTE,planetaSATURNO,planetaURANO;
           
            double peso = 0;

            Console.WriteLine("Digite o seu peso: ");
            peso = float.Parse(Console.ReadLine());

            planetaJUPITER = (peso / 10) * 2.64 * 10;
            planetaVENUS = (peso / 10) * 0.88 * 10;
            planetaURANO = (peso / 10) * 1.17 * 10;
            planetaSATURNO = (peso / 10) * 1.15 * 10;
            planetaMARTE = (peso / 10) * 0.38 * 10;
            planetaMERCURIO = (peso / 10) * 0.37 * 10;

            System.Console.WriteLine($"seu peso em Júpiter é {planetaJUPITER} kg");
            System.Console.WriteLine($"seu peso em Marte é {planetaMARTE} kg");
            System.Console.WriteLine($"seu peso em Vênus é {planetaVENUS} kg");
            System.Console.WriteLine($"seu peso em Saturno é {planetaSATURNO} kg");
            System.Console.WriteLine($"seu peso em Urano é {planetaURANO} kg");
            System.Console.WriteLine($"seu peso em Mercúrio é {planetaMERCURIO} kg");

        }
    }
}
