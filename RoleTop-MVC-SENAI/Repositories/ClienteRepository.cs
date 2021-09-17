using System;
using System.IO;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if (ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("Tipo_usuario", item));
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data-nascimento", item));
                    c.Cpf = ExtrairValorDoCampo("Cpf", item);
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);
                    c.URLFotoPerfil = ExtrairValorDoCampo("Url-Perfil",item);

                    return c;
                }

            }
            return null;
        }

        private string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";

            if (indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"Tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};Cpf={cliente.Cpf};telefone={cliente.Telefone};data-nascimento={cliente.DataNascimento};Url-Perfil={cliente.URLFotoPerfil}";
        }
    }
}