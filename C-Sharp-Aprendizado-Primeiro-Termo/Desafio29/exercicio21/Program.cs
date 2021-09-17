using System;

namespace exercicio21
{
    class Program
    {

        static void Main(string[] args)
        {
        int num = 0;
        int valor = 0;
        int num1 = 5;
        int num2 = 10;
        int num3 = 20;
        int num4 = 50;
        int num5 = 100;

            System.Console.WriteLine("valor que desejar sacar: ");
            num = int.Parse(Console.ReadLine());

            if (num > valor)
            {
                int contagem = 0;
                for (int i = num; i < valor; i++)
                {
                    num2 += valor;
                    contagem += 1;
                    System.Console.WriteLine(contagem + "notas de " + valor);
                }   
            }
        }
    }
}
