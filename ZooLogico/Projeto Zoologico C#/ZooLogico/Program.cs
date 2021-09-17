using System;
using System.Linq;
using ZooLogico.Models;
using ZooLogico.Models.Habitats;
using ZooLogico.Interfaces;
using System.Collections.Generic;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;
            do
            {
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("|  Bem- vindo ao Zoo Lógico!  |");
                System.Console.WriteLine("===============================");

                foreach (var item in Models.Animais.Arca.Animais.Values)
                {
                    System.Console.WriteLine($"{"",4}{++codigo}. {item.GetType().Name}");
                }
                System.Console.Write($"\n{"",2}Digite o código do animal ou aperte 0 para sair: ");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    var animal = Models.Animais.Arca.Animais[opcao];
                    Models.Animais.Arca.Animais.Remove(codigo);

                    mostra(animal);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();

                }

            } while (opcao != 0);

        }
        public static void mostra(Animal animal)
        {
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();
         
            //Aquario aquario = new Aquario();
            //aquario.alocar()

            if ((typeof(IAquatico)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina:::");
                if (true)
                {
                    IAquatico aquatico = (IAquatico)animal;
                    System.Console.WriteLine($"Não foi possível alocar {aquatico.Nadar()} na piscina.");
                    System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
                }
            }

            else if ((typeof(IArboricula)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore:::");
                if (true)
                {
                    IArboricula arboricula = (IArboricula)new Animal();
                    System.Console.WriteLine($"Não foi possível alocar {arboricula.EscalarArvores()} na Casa da Arvore.");
                    System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
                }
            }

            else if ((typeof(IBranquiado)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para o Aquário:::");
                if (true)
                {
                    IBranquiado branquiado = (IBranquiado)new Animal();
                    System.Console.WriteLine($"Não foi possível alocar {branquiado.RespirarDebaixoDAgua()} no aquario.");
                    System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
                }
            }

            else if ((typeof(IQuionofilo)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina Gelada:::");
            if(true)
            {
                IQuionofilo quionofilo = (IQuionofilo)new Animal();
                System.Console.WriteLine($"Não foi possível alocar {quionofilo.ResistirAoFrio()} na piscina gelada");
                System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
            }
            }

           else if ((typeof(ITerrestre)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
            }
            if(true)
            {
                ITerrestre terrestre = (ITerrestre)new Animal();
                System.Console.WriteLine($"Não foi possível alocar {terrestre.Andar()} na Caverna de Pedra.");
                System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
            }

            if ((typeof(IVoador)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola:::");
            }
            else
            {
                IVoador voador = (IVoador)new Animal();
                System.Console.WriteLine($"Não foi possível alocar {voador.Voar()} na gaiola.");
                System.Console.WriteLine("O habitat atingiu sua capacidade máxima.");
            }

            Console.ReadLine();

        }

    }
}
