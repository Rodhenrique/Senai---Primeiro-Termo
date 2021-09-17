using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
              double[] temperatura = new double[12];
              double maior = 0;
              double menor = 0;
          
            for(int i = 0; i < 12; i++) 
            {
                Console.WriteLine($"Digite a temperatura do mês {i + 1}: ");
                temperatura[i] = double.Parse(Console.ReadLine());
            }

            maior = temperatura[0];
            menor = temperatura[0];

            foreach(double temp in temperatura)
            {
                if(temp > maior)
                {
                    maior = temp;
                }else if(temp < menor)
                {
                    menor = temp;
                }

            }
            Console.WriteLine($"A maior temperatura é {maior}. ");

            Console.WriteLine($"A menor temperatura é {menor}. ");
        }
    }
}
