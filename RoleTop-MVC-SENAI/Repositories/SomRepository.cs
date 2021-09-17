using System;
using System.Collections.Generic;
using System.IO;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories
{
    public class SomRepository
    {
        private const string PATH = "Database/Som.csv";
        private const string Opcao = "Database/Opcao.csv";

        public List<string> ObterValor()
        {
            List<string> Opcaos1 = new List<string>();

            string[] linhas = File.ReadAllLines(Opcao);
            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(";");
                Opcaos1.Add(dados[0]);
                Opcaos1.Add(dados[1]);
            }
            return Opcaos1;
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