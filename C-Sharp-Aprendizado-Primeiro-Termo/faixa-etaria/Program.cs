using System;

namespace faixa_etaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int ano = 2019;

            do{

            Console.Write("digite seu ano de nascimento? ");
            idade = int.Parse(Console.ReadLine());

            if((idade > 2021) || (ano < 0)){
                Console.WriteLine("data invalida");
            }

            } while((idade > 2021) || (ano < 0));

            idade = (ano - idade);

           
             if ((idade >= 0) && (idade < 2.9)) {
                 Console.WriteLine("recém nascido");
             }else if ((idade >= 3) && (idade < 11)) {
                 Console.WriteLine("você é uma criança");
             }else if ((idade >= 12) && (idade < 19)){
                Console.WriteLine("você é um adolescente");
             }else if ((idade >= 19) && (idade < 65)){
                 Console.WriteLine("você é um adulto");
             }else if ((idade >= 65) && (idade < 180)){
                 Console.WriteLine("você é idoso");
             }else if(idade >=181){
                 Console.WriteLine("você é um vampiro sair daqui demonio");
             }


        }
    }
}
