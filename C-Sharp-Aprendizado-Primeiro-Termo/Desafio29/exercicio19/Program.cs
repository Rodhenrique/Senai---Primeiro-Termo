using System;

namespace exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            int j = 1;

            do{
            System.Console.WriteLine("Digite quantas posiçoes você precisar ou digite zero para sair: ");
            num = int.Parse(Console.ReadLine());

            int[] vetor = new int[num];
                for (int i = 0; i < num; i++)
                {
                    System.Console.WriteLine("Digite os numeros: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < num; i++)
            {
                System.Console.WriteLine($"{j}ª do seu vetor é {vetor[i]}");
                j++;
            }
            }while(num != 0);
            
        }
    }
}
