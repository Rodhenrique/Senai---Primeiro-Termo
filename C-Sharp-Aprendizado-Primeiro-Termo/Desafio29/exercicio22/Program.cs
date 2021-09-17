using System;

namespace exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper;
            var vetor = new byte [9];
            Random rand = new Random();
            rand.Next();
            
            System.Console.WriteLine("deseja gerar um vetor digite S ou n para sair: ");
            oper = Console.ReadLine();
            
            switch (oper)
            {
                case "s":
                foreach (var item in vetor)
                {
                    if (BitConverter.IsLittleEndian)
                        Array.Reverse(vetor);
                        rand.NextBytes(vetor);
                    int i = BitConverter.ToInt32(vetor, 0);

                      int resu = vetor[0] += vetor[1] += vetor[2] += vetor[3] += vetor[4] += vetor[5] += vetor[6] += vetor[7] += vetor[8];

                    Console.WriteLine(resu);                
                    
                }

                 break;

                case "n":
                System.Console.WriteLine("tchau até a proxima");
                break;
                }
            }
        }
    }

