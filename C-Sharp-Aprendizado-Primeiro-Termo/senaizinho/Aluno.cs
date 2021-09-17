using System;

namespace senaizinho
{
    public class Aluno
    {
        public string Nome{get;set;}
        public DateTime DataNascimento{get;set;}
        public string Curso{get;set;}
        public int NumeroSala{get;set;}
        
        public Aluno(string Nome, DateTime DataNascimento)
        {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
        }
    }
}