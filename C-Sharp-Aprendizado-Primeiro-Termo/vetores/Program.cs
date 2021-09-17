using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            int par = 0;
            int impar = 0;

            for(int i = 0; i < 6
            ; i++) {

            Console.WriteLine($"digite o {i+1}ª número: ");
            numeros [i] = int.Parse(Console.ReadLine());
            }

            foreach(int  num in numeros){
                 if(num % 2 == 0){
                    par++;
                }else{
                    impar++;
                }
            }
            Console.WriteLine($"Você tem {par} números pares e {impar} números impares");
        }
    }
}
