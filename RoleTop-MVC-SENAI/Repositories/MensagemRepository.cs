using System;
using System.Collections.Generic;
using System.IO;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories {
    public class MensagemRepository {
        private const string PATH = "Database/Mensagens.csv";

        public MensagemRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Mensagem mensagem) {
            var linha = new string[] { PrepararRegistroCSV (mensagem) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Mensagem> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            Cliente cliente = new Cliente();
            ClienteRepository clienteRepository = new ClienteRepository();
            List<Mensagem> mensagems = new List<Mensagem> ();

            foreach (var item in linhas) {
                Mensagem m = new Mensagem ();

                m.Email = ExtrairValorDoCampo ("email", item);
                m.MensagemDoCliente = ExtrairValorDoCampo ("mensagem", item);
                m.Data = DateTime.Parse (ExtrairValorDoCampo ("data", item));
                m.Objetivo = ExtrairValorDoCampo ("objetivo", item);
                m.Id = uint.Parse (ExtrairValorDoCampo ("id", item));

                cliente = clienteRepository.ObterPor(m.Email);
                m.cliente = cliente;

                mensagems.Add (m);

            }
            return mensagems;
        }
        public Mensagem ObterPor (ulong id) {
            var mensagensTotais = ObterTodos ();
            foreach (var pedido in mensagensTotais) {
                if (id.Equals (pedido.Id)) {
                    return pedido;
                }
            }
            return null;
        }

        private string ExtrairValorDoCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf (chave);

            var indiceTerminal = linha.IndexOf (";", indiceChave);

            var valor = "";

            if (indiceTerminal != -1) {
                valor = linha.Substring (indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring (indiceChave);
            }
            System.Console.WriteLine ($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace (nomeCampo + "=", "");
        }
        private string PrepararRegistroCSV (Mensagem mensagem) {
            return $"id={mensagem.Id};email={mensagem.Email};mensagem={mensagem.MensagemDoCliente};data={mensagem.Data};objetivo={mensagem.Objetivo}";
        }
    }
}