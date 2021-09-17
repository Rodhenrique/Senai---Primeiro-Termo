using System;

namespace RoletopMvc.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string SenhaConfirmar { get; set; }
        public uint TipoUsuario { get; set; }
        public string URLFotoPerfil {get;set;}  
        
        public Cliente()
        {

        }
        public Cliente(string nome, string email, string telefone, DateTime dataNascimento, string cpf, string senha, string senhaConfirmar)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.SenhaConfirmar = senhaConfirmar;
        }

    }
}