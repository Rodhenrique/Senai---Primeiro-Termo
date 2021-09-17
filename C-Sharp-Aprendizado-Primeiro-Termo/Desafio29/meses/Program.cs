using System;

namespace meses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;
            int mes2 = 12;
            do{

            System.Console.WriteLine("Digite um entre 1 a 12 para saber o mês do ano: ");
            mes = int.Parse(Console.ReadLine());

            if((mes > 12) || (mes2 < 0)){
                Console.WriteLine("Numero invalido!!!");
            }


            switch (mes)
            {
                case 1:
                System.Console.WriteLine("este mês é Janeiro!!!");
                break;
                 case 2:
                System.Console.WriteLine("este mês é Fevereiro!!!");
                break;
                 case 3:
                System.Console.WriteLine("este mês é Março!!!");
                break;
                 case 4:
                System.Console.WriteLine("este mês é Abril!!!");
                break;
                 case 5:
                System.Console.WriteLine("este mês é Maio!!!");
                break;
                 case 6:
                System.Console.WriteLine("este mês é Junho!!!");
                break;
                 case 7:
                System.Console.WriteLine("este mês é Julho!!!");
                break;
                 case 8:
                System.Console.WriteLine("este mês é Agosto!!!");
                break;
                 case 9:
                System.Console.WriteLine("este mês é Setembro!!!");
                break;
                 case 10:
                System.Console.WriteLine("este mês é Outubro!!!");
                break;
                 case 11:
                System.Console.WriteLine("este mês é Novembro!!!");
                break;
                 case 12:
                System.Console.WriteLine("este mês é Dezembro!!!");
                break;
                default:
                System.Console.WriteLine("Esse dado não consiste ai pedindo!!!");
                break;

                }
            }while((mes > 12) || (mes2 > 0 ));
        }
    }
}
