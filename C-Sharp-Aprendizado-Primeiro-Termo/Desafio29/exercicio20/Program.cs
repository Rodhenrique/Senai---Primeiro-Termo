using System;

namespace exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper;
            Random rand = new Random();
            var vetor = new byte[10];
            rand.NextBytes(vetor);

            Console.Clear();    
            Console.WriteLine("Digite S para gera 10 numeroas aleatorios ou N para sair");
            oper = Console.ReadLine();

            oper.ToLower();
            string menu = "==============================";
            
            if (oper == "s")
            {
                System.Console.WriteLine(menu);
                System.Console.WriteLine("      listar de pares");
                System.Console.WriteLine(menu);

                foreach (var item in vetor)
                {
                if((item % 2) ==0){
                    System.Console.WriteLine("esse numeros é par: " + item);
                }
                }
                System.Console.WriteLine(menu);
                System.Console.WriteLine("     listar de impares");
                System.Console.WriteLine(menu);

                foreach (var item in vetor)
                {
                 if((item % 2) !=0)
                {      
                    System.Console.WriteLine(" esse numero é impar: " + item);
                }
                    
                }

            }else if(oper == "n")
            {
                System.Console.WriteLine("tchau até a proxima!!!");
            }else
            {
                System.Console.WriteLine("opção incorreta!!!");
            }
        }
    }
}
