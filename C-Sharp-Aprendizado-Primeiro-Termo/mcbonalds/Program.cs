using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente("pedroke do morro do macaco","11-4002-9822","pedrokedovrau@gmail.com");

            Console.WriteLine("nome: " +cliente1.nome);
            Console.WriteLine("telefone: " +cliente1.telefone);
            Console.WriteLine("email: " + cliente1.email);
        }
        
    }
}
