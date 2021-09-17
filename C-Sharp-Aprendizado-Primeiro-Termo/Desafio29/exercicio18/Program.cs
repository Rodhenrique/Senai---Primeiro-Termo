using System;

namespace exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            
            do{
            Console.Clear();
            Console.WriteLine("Digite um número impar ou aperte 0 para sair:");
            num = int.Parse(Console.ReadLine());

            if((num % 2) ==0){
                System.Console.WriteLine("esse numero não e impar digite novamente");    
                Console.ReadLine();
                
            }else
            {
                for(int i= 1 ; i < num; i+=2)
                {
                    Console.Write($" {i} ");
                } 
                    Console.ReadLine();
            }
            }while (num !=0);
        }
    }
}
