using System;

namespace senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            int totalAluno = 100;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            //bool querSair ;

            string oper;

            do{
            Console.Clear();
            System.Console.WriteLine("==============================");
            System.Console.WriteLine("  Bem-Vindo ao Senaizinho");
            System.Console.WriteLine("==============================");

            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Cadastrar Sala");
            System.Console.WriteLine("3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            System.Console.WriteLine("5 - Verificar Salas");
            System.Console.WriteLine("6 - Verificar Alunos");
            System.Console.WriteLine("0 – Sair");

            System.Console.WriteLine("Digite a Opção");
            oper = Console.ReadLine();


                switch (oper)
                {
                    case "1":
                    CadastrarAluno(alunos);
                    break;
                    case "2":
                        Console.Write("não sei");
                    break;
                    case "3":
                    Console.Write("não sei");
                    break;
                    case "4":
                    Console.Write("não sei");
                    break;
                    case "5":
                    Console.Write("não sei");
                    break;
                    case "6":
                    Console.Write("não sei");
                    break;
                    case "0":
                    Console.Write("não sei");
                    break;

                    default:
                    System.Console.WriteLine("Opção invalida");
                        Console.ReadLine();
                        break;
                }
            }while(oper != "0");
        }
    
    public void CadastrarAluno(Aluno[] alunos, int totalAluno, int alunosCadastrados)
    {
        if(alunosCadastrados < totalAluno)
        {
            Console.WriteLine("Cadastro de Alunos");
            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            Aluno novoAluno = new Aluno();
            novoAluno.Nome = nome;
            novoAluno.DataNascimento = dtNascimento;
            int index = 0;
            foreach (Aluno  aluno in alunos)
            {
                if(aluno == null)
                {
                    alunos[index] = novoAluno;
                    break;
                }
                index ++;
            }
            
        }
    }

    public void CadastrarSala(Sala[] salas, int totalSala, int salascadastradas)
    {
    }
    public void AlocarAluno()
    {
        
    }
    public void RemoverAluno()
    {

    }
    public void VerificarSalas()
    {

    }
    public void VerificarAlunos()
    {

    }

    }
}
