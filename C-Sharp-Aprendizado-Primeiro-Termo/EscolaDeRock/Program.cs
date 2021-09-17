using System;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;
using System.Collections.Generic;

namespace EscolaDeRock
{
    enum FormacaoEnum : int{
        TRIO = 3,
        QUARTETO
    };
    enum InstrumentoEnum : int 
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoraEnum : int
    {
        HARMONIA,
        PERCUSSÃO,
        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            string[]itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[]itensMenuCategoria = Enum.GetNames(typeof(CategoraEnum));

            var opcoesFormacao = new List<string>()
            {
                "     -0                         ",
                "     -1                    "
            };
            int opcoesFormacaoSelecionada = 0;
            string menuBar = "====================";

            bool quersair = false;

            do
            {
                bool FormacaoEscolhida = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("        seja bem vindo           ");
                    Console.WriteLine("        escolha uma  formação    ");
                    Console.ResetColor();
                    Console.WriteLine(menuBar);

                    for (int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if (opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        }else 
                        {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }
                    }
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count -1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        FormacaoEscolhida = true;
                        break;

                    }

                } while (false);
            }while(!quersair);
        }
    }
}
