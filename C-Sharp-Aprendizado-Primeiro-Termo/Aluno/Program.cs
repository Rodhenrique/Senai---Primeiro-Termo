using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("alexandre","123456789-00");
            Aluno aluno2 = new Aluno("cesar","987654321-11","prog1");

                Console.WriteLine("nome: " + aluno1.nome);
                Console.WriteLine("cpf: " + aluno1.cpf);
                Console.WriteLine("curso: " + aluno1.curso);

                Console.WriteLine("nome: " + aluno2.nome);
                Console.WriteLine("cpf: " + aluno2.cpf);
                Console.WriteLine("curso: " + aluno2.curso);

            Console.Write("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o cpf: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre com o nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre =  int.Parse(Console.ReadLine());

            Aluno aluno = aluno2 = new Aluno(nome,cpf,curso);
            aluno2.setnotas(bimestre,nota);

             Console.WriteLine("nome: " + aluno2.nome);
                Console.WriteLine("cpf: " + aluno2.cpf);
                Console.WriteLine("curso: " + aluno2.curso);
                Console.WriteLine("notas: ");
                foreach(int n in aluno2.getnotas()){
                    Console.WriteLine(n + " ");
                }
        }
    }
}
