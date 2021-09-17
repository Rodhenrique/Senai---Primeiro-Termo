using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            string oper;

            do{


            Console.WriteLine("quadrado");
            Console.WriteLine("retangulo");
            Console.WriteLine("circulo");
            Console.WriteLine("losango");
            Console.WriteLine("trapezio");
            Console.WriteLine("triangulo");

            Console.WriteLine(" selecione uma forma geometrica ou digite parar: ");
            oper = Console.ReadLine();

switch (oper){
            case "quadrado":
              
              Console.WriteLine("digite o lado superior");
              num1 = double.Parse(Console.ReadLine());

              Console.WriteLine("digite o lado");
              num2 = double.Parse(Console.ReadLine());

              Console.WriteLine($"{num1} * {num2} =  {num1 * num2}");

                                                                    break;

                case "retangulo":

                  Console.WriteLine("digite a base do retangulo");
                  num1 = double.Parse(Console.ReadLine());

                  Console.WriteLine("digite a altura do retangulo");
                  num2 = double.Parse(Console.ReadLine());

                  Console.WriteLine($"{num1} * {num2} =  {num1 * num2}");

                                                                      break;

                    case "triangulo":
                      
                      Console.WriteLine("digite a base do triangulo");
                      num1 = double.Parse(Console.ReadLine());

                      Console.WriteLine("digite a altura do triangulo");
                      num2 = double.Parse(Console.ReadLine());

                      Console.WriteLine($"{num1} * {num2} / {2} =  {(num1 * num2) /2}");

                                                                        break;

                      case "trapezio":

                        Console.WriteLine("digite a base do trapezio");
                        num1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite a base menor do trapezio");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("digite a altura do trapezio");
                        num3 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{num1} + {num2} * {num3} / {2} =  {(num1 + num2 * num3) /2}");

                                                                        break;

                          case "losango":

                            Console.WriteLine("digite a diagonal maior do losango");
                            num1 = double.Parse(Console.ReadLine());

                            Console.WriteLine("digite a diagonal menor do losango");
                            num2 = double.Parse(Console.ReadLine());


                            Console.WriteLine($"{num1} * {num2} / {2} =  {(num1 * num2) /2}");

                                                                                  break;

                              case "circulo":

                              Console.WriteLine("digite o raio do circulo");
                              num2 = double.Parse(Console.ReadLine());

                              Console.WriteLine($"{3.14} * {num2 * num2} =  {3.14 * (num2 * num2)}");

                                                                                        break;
            }
         }while(oper != "parar");
      }
    }
}
