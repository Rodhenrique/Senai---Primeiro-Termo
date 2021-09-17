using System;
using System.Collections.Generic;
using System.IO; 

namespace exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lista> listaNome = new List<Lista>();

            System.Console.WriteLine("digite 1 para adicionar nomes ou 0 para sair");
            int opcao = int.Parse(Console.ReadLine());
        
            
            switch (opcao)
            {
                case 1:
                AddItem(listaNome);
                break;
            }
        }
          public static void AddItem(List<Lista> listaNome)
        {
            string nome;
            int contagem = -1;
            do{

            Console.Clear();
            System.Console.WriteLine("Novo nome");
            System.Console.WriteLine();
            System.Console.WriteLine("digite o nome ou digite 0: ");

            nome = Console.ReadLine();
            Lista item = new Lista(nome);

            listaNome.Add(item);
            contagem +=1;
            }while(nome != "0");
            System.Console.WriteLine($"nomes que você adicionou {contagem}");
        }

    }
}
