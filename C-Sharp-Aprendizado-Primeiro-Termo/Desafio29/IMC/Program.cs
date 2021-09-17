using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso,altura,resu;

          
            
            System.Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu altura: ");
            altura = double.Parse(Console.ReadLine());

            resu = peso / (altura * altura);

            if ((resu < 18.5) && (resu < 19.9))
            {
                System.Console.WriteLine(resu + "seu IMC abaixo do peso ");
            }else if((resu > 20) && (resu < 24.9))
            {
                System.Console.WriteLine(resu +" seu IMC um peso normal para seu peso ");
            }else if((resu > 25) && (resu < 29.9))
            {
                System.Console.WriteLine(resu +"{seu está e, sobrepeso");

            }else if((resu > 30) && (resu < 34.9))
            {
                System.Console.WriteLine(resu +" seu IMC está obesidade grau 1ª");
            }else if((resu > 35) && (resu < 40))
            {
                System.Console.WriteLine(resu +" seu IMC está obesidade grau 2ª ");
            }else if(resu > 40)
            {
                System.Console.WriteLine(resu +" seu IMC está obesidade grau 3ª ");
            }

        }
    }
}
