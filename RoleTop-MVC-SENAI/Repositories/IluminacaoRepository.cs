using System;
using System.Collections.Generic;
using System.IO;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories
{
    public class IluminacaoRepository
    {
        private const string PATH = "Database/Iluminacao.csv";
        private const string Opcao = "Database/Opcao.csv";


        public List<string> ObterValor()
        {
            List<string> Opcaos = new List<string>();

            string[] linhas = File.ReadAllLines(Opcao);
            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(";");
                Opcaos.Add(dados[0]);
                Opcaos.Add(dados[1]);
            }
            return Opcaos;
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