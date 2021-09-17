using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double aumento = 0;
            double resultado = 0;

            Console.WriteLine("digite o salario do funcionario");
            salario = double.Parse(Console.ReadLine());

                        aumento = (salario * 0.3);
                        resultado = (aumento + salario);


            
            if(salario == 500){
                Console.WriteLine("seu salario não pode ser aumentando");
            }else if(salario < 499.9){
                Console.WriteLine("parabens seu salario foi aumentando para " + resultado);
            }else if(salario > 501){
                Console.WriteLine("seu salario e muito alto para o aumento de salario");
            }
            
        }
    }
}
