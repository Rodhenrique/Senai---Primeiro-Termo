using System;

namespace mcbonalds
{
    public class cliente
    {
        //propriedades

        public string nome;
        public string endereço;
        public string telefone;
        public string senha;
        public string email;
        public DateTime DataNascimento;


        //construtores

        public cliente(string nome, string telefone, string email){
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }
}