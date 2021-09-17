using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");
            ContaEspecial contaCorrente2 = new ContaEspecial(1, 2, "Cesar");

            DepositarConta(contaCorrente1);
            DepositarConta(ContaEspecial1);
            SacarConta(contaCorrente1);

            
            DepositarConta(contaCorrente2);
            DepositarConta(ContaEspecial2);
            SacarConta(contaCorrente2);

            ContaEspecial contaEspecial1 = new ContaEspecial(1, 2, "Alexandre");
            ContaEspecial.SetLimite(Saldo);

            ContaEspecial ContaEspecial2 = new ContaEspecial(1, 2, "Cesar");

            
            #region deposito
            Console.WriteLine("ByteBank - Deposito");
            Cliente usuario = contaCorrente.Titular;
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());

            if(contaCorrente.Deposito(valor)){
                Console.WriteLine("deposito com sucesso");
            }else {
                Console.WriteLine("valor deve ser positivo");
            }
            
            Console.WriteLine($"Saldo atual: {saldo}");
            Console.WriteLine();
            
            #endregion

            #region saque
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Qual o valor do Saque? ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                Console.WriteLine("Saque realizado com sucesso. Retire as notas");
            } else {
                Console.WriteLine("Não foi possivel realizar a operação");

            }
            Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");
            Console.WriteLine();

            #endregion

            #region transferencia

            Cliente cliente2 = new Cliente("Alexandre","123.321.123-12","a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,132,cliente2);
            Console.WriteLine("ByteBank - Transferencia");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo destino: {contaCorrente2.Saldo}");
            Console.Write("Digite o valor da tranferência: ");
            valor = double.Parse(Console.ReadLine());
        
            if (contaCorrente.Transferencia(contaCorrente2,valor)){
                Console.WriteLine("Tranferencia efetuada com sucesso.");
            } else {
                Console.WriteLine("Operação não pode ser realizada.");
            }
            Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo destino: {contaCorrente2.Saldo}");

            #endregion
        }
    }
}
