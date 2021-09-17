using System;
using Reciclagem.Interfaces;
using System.Collections.Generic;
using Reciclagem.Models;

namespace Reciclagem
{
    enum Materiais : uint
    {
        CascaBanana,
        Latinha,
        Papalão,
        GuardaChuva,
        Garrafa,
        GarrafaPet,
        PoteManteiga

    }
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "==========================================================";
            int latas = 0;

            do{
            Console.Clear();
            Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("                    seja bem vindo           ");
            Console.WriteLine("        escolha uma  formação de Reciclagem!!!    ");
            Console.ResetColor();
            Console.WriteLine(menuBar);

            ExibirMenuDeLixos();
            System.Console.WriteLine("Digite o codigo do lixo ou digite 0 para sair");
            latas = int.Parse(Console.ReadLine());

            switch (latas)
                {
                    case 1:
                    var recicla = Deposito.lixo[latas];       
                    Type interfaceEncontrada = recicla.GetType().GetInterface("lixeiraVerde");

                        if(interfaceEncontrada != null)
                        {
                            JogarLixo((ILixeiraVerde)recicla);
                        }
                    break;
                    
                    case 2:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraVermelho");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraVermelho)recicla);
                            }
                    break;

                    case 3:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraCinza");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraCinza)recicla);
                            }
                    break;
                    
                    case 4:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraVermelho");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraVermelho)recicla);
                            }
                    break;

                    case 5:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraAmarelo");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraAmarelo)recicla);
                            }
                    break;

                    case 6:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraAzul");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraAzul)recicla);
                            }
                    break;

                    case 7:
                        recicla = Deposito.lixo[latas];       
                        interfaceEncontrada = recicla.GetType().GetInterface("lixeiraPreta");

                            if(interfaceEncontrada != null)
                            {
                                JogarLixo((ILixeiraPreta)recicla);
                            }
                    break;

                    case 0:
                    Console.WriteLine("tchau até a proxima");
                    Console.ReadLine();
                    break;

                    default:
                    Console.WriteLine("Não foi possivel identificar esse material.");
                    Console.ReadLine();
                    
                    break;
                }

            }while(latas !=0);

        }
        public static void ExibirMenuDeLixos()
        {
            var lixos = Enum.GetNames(typeof(Materiais));
            int codigo = 1;

            foreach(var lixo in lixos)
            {
                System.Console.WriteLine($"  {codigo++}.{lixo}");
            }
        }
        public static void JogarLixo(ILixeiraVerde lixeiraVerde)
        {
            lixeiraVerde.RecicladoVidro();
            System.Console.WriteLine("Essa garrafa foi reciclada para lixeira verde");
            Console.ReadLine();          
        }

        public static void JogarLixo(ILixeiraAzul lixeiraAzul)
        {
                lixeiraAzul.GetType();
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixeiraAzul.RecicladoPapel()} deve ir para a lixeira Azul");
        }
        public static void JogarLixo(ILixeiraAmarelo lixeiraAmarelo)
        {
            lixeiraAmarelo.RecicladoMetal();
            System.Console.WriteLine("A latinha foi reciclada para lixeira amarela");
            Console.ReadLine();
        }
        public static void JogarLixo(ILixeiraVermelho lixeiraVermelho)
        {         
            lixeiraVermelho.RecicladoPlastico();
            System.Console.WriteLine("A garrafaPet foi reciclada para lixeira vermelha");
            Console.ReadLine();
        }
        public static void JogarLixo(ILixeiraCinza lixeiraCinza)
        {
            lixeiraCinza.RecicladoIndefinidos();
            System.Console.WriteLine($"o  foi reciclado para lixeira cinza");
            Console.ReadLine();
        }
        public static void JogarLixo(ILixeiraPreta lixeiraPreta)
        {
            lixeiraPreta.RecicladoMaterialOrgânico();
            System.Console.WriteLine(lixeiraPreta.GetType().BaseType + "foi para composteira");
            Console.ReadLine();
        }
    }
}
