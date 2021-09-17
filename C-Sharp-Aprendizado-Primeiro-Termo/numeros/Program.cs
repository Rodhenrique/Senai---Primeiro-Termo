using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do{

                Console.WriteLine("digite o numero ou zero para parar: ");
                    num = int.Parse(Console.ReadLine());


                    if((num % 2) == 0){
                        Console.WriteLine("esse numero e par");
                    }else {
                            Console.WriteLine("esse numero e impar");
                    }
             }while(num != 0);
        }
    }
}
