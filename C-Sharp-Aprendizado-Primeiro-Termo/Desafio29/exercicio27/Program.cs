using System;
using System.Collections.Generic;
using System.IO;

namespace exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "========================================";
            int opcao = 0;

            List<Listar> listars = new List<Listar>();
            string fileName = "agenda.csv";
            string filePath = ".\\" + fileName;

             try
            {
                string[] todofile = File.ReadAllLines(filePath);
                foreach (string line in todofile)
                {
                    string[] itens = line.Split(",");
                    string Nome = itens[0].Replace("\"", "");
                    string DataNc = itens[1].Replace("\"", "");

                    Listar agendaItem = new Listar(Nome, DataNc);
                    listars.Add(agendaItem);
                }
            }
            catch (IOException ioe)
            {
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }


            do{

            Console.Clear();
            System.Console.WriteLine(menu);
            System.Console.WriteLine(" Bem-Vindo ao seu calendario de nivel");
            System.Console.WriteLine(menu);
            System.Console.WriteLine();

            System.Console.WriteLine("1-Cadastra na agenda");
            System.Console.WriteLine("2-Remove da agenda");
            System.Console.WriteLine("3-Procurar por alguem");
            System.Console.WriteLine("4-Listar cadastros");
            System.Console.WriteLine("0-Sair");
            opcao = int.Parse(Console.ReadLine());
             if ((opcao > 4) || (opcao < 0))
            {
                System.Console.WriteLine("Opção invalida digite novamente!!!");
                Console.ReadLine();
            }
           
            switch (opcao)
            {
               case 1:
               Cadastra(listars);
               break;
               case 2:
               remove(listars);

               break;
               case 3:

               break;
               case 4:

               break;

            }

            }while(opcao !=0);
        }
         public static void ListaItens(List<Listar> listars)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine(" Agenda ");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Nome{"",12}Data de Nascimento");
            foreach (Listar item in listars)
            {
                System.Console.WriteLine($"{count,3}: {item.Nome,-15} - {item.DataNc}");
                count++;
            }
        }
        public static void Cadastra(List<Listar> listars)
        {
            string Nome;
            string date;
            do{

            Console.Clear();
            System.Console.WriteLine("Novo nome");
            System.Console.WriteLine();
            System.Console.WriteLine("digite o nome ou digite 0 para sair: ");
            Nome = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine("digite a Data de Nascimento: ");
            date = Console.ReadLine();
    
            Listar item = new Listar(Nome,date);
            listars.Add(item);
            }while(Nome != "0");
        }
        public static void remove(List<Listar> listars)
        {
             int index = 0;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Remove item");
                System.Console.WriteLine();
                ListaItens(listars);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID ou x para terminar");
                System.Console.Write("ID: ");
                string id = Console.ReadLine();

                if (id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > listars.Count - 1))
                {
                    System.Console.WriteLine("ID invalido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                }
                else
                {
                    listars.RemoveAt(index);
                }
            } while (true);
        }
    }
}
