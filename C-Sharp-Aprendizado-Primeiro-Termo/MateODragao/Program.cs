using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {

        static void Main(string[] args)


        {
            bool jogadorNaoDesistiu = true;

            do {


            Console.Clear();
            System.Console.WriteLine("==============================");
            System.Console.WriteLine("       Mate O Dragão!");
            System.Console.WriteLine("==============================");

            System.Console.WriteLine(" 1 - Iniciar jogo");
            System.Console.WriteLine(" 0 - Sair do jogo");

            string opcaojogador = Console.ReadLine();

            switch(opcaojogador)
                {
                    case "1":
                    Console.Clear();

                Guerreiro guerreiro = CriarGuerreiro();         

                    
                    Dragao dragao = new Dragao();

                    dragao.Nome = "falcor";
                    dragao.Forca = 5;
                    dragao.Destreza = 1;
                    dragao.Inteligencia = 3;
                    dragao.Vida = 300;

                    /* INICIO - PRIMEIRO DIÁLOGO */
                    CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! vim-lhe derrotar-lhe!");
                    CriarDialogo(dragao.Nome, $"Humano tolinho. quem pensas que és?");

                    FinalizarDialogo();

                    /* FIM - PRIMEIRO DIÁLOGO */

                    /* INICIO - SEGUNDO DIÁLOGO */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, Ó criatura morfética");

                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: vim de {guerreiro.CidadeNatal}! para derrota-se e mostar meu valor!");

                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE?bom,vem por combater seu animal");

                        System.Console.WriteLine("BAMBAM: Tá na hora do show");


                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        

                    /* FIM - SEGUNDO DIÁLOGO */

                    Console.Clear();

                    bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                    int poderAtaqueguerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                    bool jogadorNaocorreu = true;

                    if(jogadorAtacaPrimeiro)
                    {
                        System.Console.WriteLine("*** hora do show monstro ***");
                        System.Console.WriteLine(" 1 - Atacar");
                        System.Console.WriteLine(" 2 - fugir");

                        string opcaoBatalhajogador = Console.ReadLine();

                        switch(opcaoBatalhajogador){
                            case "1":

                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatoriojogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezatotal =  guerreiro.Destreza + numeroAleatoriojogador;
                            int dragaoDestrezatotal =  guerreiro.Destreza + numeroAleatorioDragao;

                            if(guerreiroDestrezatotal > dragaoDestrezatotal){
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:  tomar essa, lagarto maldjeeto ");
                                dragao.Vida = dragao.Vida - (poderAtaqueguerreiro + 5);
                                System.Console.WriteLine($"HP Dragao {dragao.Vida} ");
                                System.Console.WriteLine($"HP Dragao {guerreiro.Vida} ");
                            }else 
                            {
                                System.Console.WriteLine($"{dragao.Nome} vish negão perdeu seu mané!!!");
                            }

                            
                            break;
                            case "2":
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: melhor correr na batalha do que perder um dente");
                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ ");
                            jogadorNaocorreu = false;

                            break;
                        }

                    }

                    System.Console.WriteLine();
                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                    Console.ReadLine();

                    while(guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaocorreu)
                    {
                        Console.Clear();
                        System.Console.WriteLine("*** turno dragão ***");

                        Random geradorNumeroAleatorio = new Random();
                            int numeroAleatoriojogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezatotal =  guerreiro.Destreza + numeroAleatoriojogador;
                            int dragaoDestrezatotal =  guerreiro.Destreza + numeroAleatorioDragao;

                            if(guerreiroDestrezatotal < dragaoDestrezatotal){
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:  fritou o forevis, foi? ");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragao {dragao.Vida} ");
                                System.Console.WriteLine($"HP Dragao {guerreiro.Vida} ");
                            }else 
                            {
                                System.Console.WriteLine($"{guerreiro.Nome} puxa não foi dessa vez tente novamente!!!");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();

                            Console.Clear();

                              System.Console.WriteLine("*** hora do show monstro ***");
                        System.Console.WriteLine(" 1 - Atacar");
                        System.Console.WriteLine(" 2 - fugir");

                        string opcaoBatalhajogador = Console.ReadLine();

                        switch(opcaoBatalhajogador){
                            case "1":

                                geradorNumeroAleatorio = new Random();
                                numeroAleatoriojogador = geradorNumeroAleatorio.Next(0, 5);
                                numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                guerreiroDestrezatotal =  guerreiro.Destreza + numeroAleatoriojogador;
                                dragaoDestrezatotal =  guerreiro.Destreza + numeroAleatorioDragao;

                        if(guerreiroDestrezatotal > dragaoDestrezatotal){
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}:  tomar essa, lagarto maldjeeto ");
                            dragao.Vida = dragao.Vida - (poderAtaqueguerreiro + 5);
                            System.Console.WriteLine($"HP Dragao {dragao.Vida} ");
                            System.Console.WriteLine($"HP Dragao {guerreiro.Vida} ");
                        }else 
                        {
                            System.Console.WriteLine($"{dragao.Nome} vish negão perdeu seu mané!!!");
                        }

                        
                            break;
                            case "2":
                            System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: melhor correr na batalha do que perder um dente");
                            System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ ");
                            jogadorNaocorreu = false;

                            break;
                        }


                    }

                    if(guerreiro.Vida <=0)
                    {
                        System.Console.WriteLine("Você perdeu");  
                    }
                    if(dragao.Vida <=0)
                    {
                        System.Console.WriteLine("Você venceu");
                    }
                    

                    break;
                    case "0":
                    jogadorNaoDesistiu = false;
                    System.Console.WriteLine("GAME OVER");
                    break;

                    default:
                        System.Console.WriteLine("Comando inválido!");
                    break;
                }
            } while(jogadorNaoDesistiu);
        }
    
    public static void CriarDialogo(string nome, string frase)
    {
        System.Console.WriteLine($"{nome.ToUpper()}:\n-{frase}");
        
    }

    public static void FinalizarDialogo()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Aperte ENTER para prosseguir");
        Console.ReadLine();
        Console.Clear();
    }

    public static Guerreiro CriarGuerreiro()
    {
        Guerreiro guerreiro = new Guerreiro(); 

        guerreiro.Nome = "Target";
        guerreiro.Sobrenome = "matok";
        guerreiro.CidadeNatal = "Ville Edimburgo";
        guerreiro.DataNascimento = DateTime.Parse("07/09/501");
        guerreiro.FerramentaAtaque = "espada";
        guerreiro.FerramentaProtecao = "escudo";
        guerreiro.Forca = 3;
        guerreiro.Destreza = 2;
        guerreiro.Inteligencia = 3;
        guerreiro.Vida = 20;

        return guerreiro;
    }

    }
}


