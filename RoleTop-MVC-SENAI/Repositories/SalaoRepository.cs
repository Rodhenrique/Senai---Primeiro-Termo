using System;
using System.Collections.Generic;
using System.IO;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories
{
    public class SalaoRepository
    {
        private const string PATH = "Database/Salao.csv";
        private const string Opcao = "Database/Eventos.csv";
       
        public List<string> ObterValor()
        {
            List<string> Opcaos2 = new List<string>();

            string[] linhas = File.ReadAllLines(Opcao);
            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(";");
                foreach (var item in dados)
                {
                    Opcaos2.Add(item);
                }
            }
            return Opcaos2;
        }

        public double valor()
        {
            string[] lista = File.ReadAllLines(PATH);
            double preco = 0.0;
            
            preco = Double.Parse(lista[0]);
            System.Console.WriteLine($"Preco: {preco}");
            return preco;
        }
    }
}