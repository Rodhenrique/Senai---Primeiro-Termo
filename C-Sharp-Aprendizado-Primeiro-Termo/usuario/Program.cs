using System;

namespace usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            string admin = "admin";
            string admin2 = "admin@132";

            


            Console.Write("digite seu email ");
            admin = Console.ReadLine();

            Console.Write("digite sua senha ");
            admin2 = Console.ReadLine();



             if((admin == admin) && admin2 == admin2){
                Console.WriteLine("bem vindo admin");

            }else {
                Console.WriteLine("olá usuario");
            }

        }
    }
}
