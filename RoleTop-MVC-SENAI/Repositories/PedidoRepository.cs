using System;
using System.Collections.Generic;
using System.IO;
using RoletopMvc.Enums;
using RoletopMvc.Models;

namespace RoletopMvc.Repositories {
    public class PedidoRepository : RepositoryBase {
        public const string PATH = "Database/Pedido.csv";

        public PedidoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Alugar alugar) {
            var quantidadePedidos = File.ReadAllLines (PATH).Length;
            alugar.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] { PrepararPedidoCSV (alugar) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public List<Alugar> ObterTodosPorCliente (string emailCliente) {
            var alugues = ObterTodos ();
            List<Alugar> pedidosCliente = new List<Alugar> ();

            foreach (var pedido in alugues) {
                if (pedido.cliente.Email.Equals (emailCliente)) {
                    pedidosCliente.Add (pedido);
                }
            }
            return pedidosCliente;
        }
        public List<Alugar> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            Cliente cliente = new Cliente ();
            List<Alugar> alugars = new List<Alugar> ();

            foreach (var linha in linhas) {
                Alugar alugar = new Alugar ();

                alugar.Id = ulong.Parse (ExtrairValorDoCampo ("id", linha));
                alugar.Status = uint.Parse (ExtrairValorDoCampo ("status_pedido", linha));
                alugar.DataDoPedido = DateTime.Parse (ExtrairValorDoCampo ("cliente_dataDoEvento", linha));
                alugar.TipoEvento = ExtrairValorDoCampo ("cliente_tipoEvento", linha);
                alugar.Descricao = ExtrairValorDoCampo ("cliente_descricao", linha);
                alugar.Pagamento = ExtrairValorDoCampo ("cliente_formaDePg", linha);
                alugar.organizado = ExtrairValorDoCampo ("cliente_nome", linha);
                alugar.som.Nome = ExtrairValorDoCampo ("cliente_som", linha);
                alugar.iluminacao.Nome = ExtrairValorDoCampo ("cliente_iluminacao", linha);
                alugar.PrecoTotal = double.Parse (ExtrairValorDoCampo ("cliente_precoTotal", linha));
                alugar.selecionaIlumina = ExtrairValorDoCampo ("imgDaLuz", linha);
                alugar.selecionaSom = ExtrairValorDoCampo ("imgDaSom", linha);
                alugar.StatusNome = ExtrairValorDoCampo ("status_nome", linha);
                cliente.Email = ExtrairValorDoCampo ("email", linha);
                
                switch (alugar.Status) {
                    case (uint) StatusPedido.APROVADO:
                        alugar.StatusNome = "APROVADO";
                        break;
                    case (uint) StatusPedido.REPROVADO:
                        alugar.StatusNome = "REPROVADO";
                        break;
                    case (uint) StatusPedido.PENDENTE:
                        alugar.StatusNome = "PENDENTE";
                        break;
                }

                ClienteRepository clienteRepository = new ClienteRepository ();
                alugar.cliente = clienteRepository.ObterPor (cliente.Email);

                alugars.Add (alugar);
            }
            return alugars;
        }
        public Alugar ObterPor (ulong id) {
            var pedidosTotais = ObterTodos ();
            foreach (var pedido in pedidosTotais) {
                if (id.Equals (pedido.Id)) {
                    return pedido;
                }
            }
            return null;
        }
        public bool Atualizar (Alugar alugar) {
            var pedidosTotais = File.ReadAllLines (PATH);
            var pedidoCSV = PrepararPedidoCSV (alugar);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosTotais.Length; i++) {
                var idConvertido = ulong.Parse (ExtrairValorDoCampo ("id", pedidosTotais[i]));
                if (alugar.Id.Equals (idConvertido)) {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            if (resultado) {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines (PATH, pedidosTotais);
            }

            return resultado;
        }
        private string PrepararPedidoCSV (Alugar alugar) {
            Cliente c = alugar.cliente;
            Som s = alugar.som;
            Iluminacao i = alugar.iluminacao;

            return $"id={alugar.Id};status_nome={alugar.StatusNome};status_pedido={alugar.Status};email={c.Email};cliente_dataDoEvento={alugar.DataDoPedido};cliente_tipoEvento={alugar.TipoEvento};cliente_descricao={alugar.Descricao};cliente_formaDePg={alugar.Pagamento};cliente_nome={alugar.organizado};cliente_som={s.Nome};cliente_iluminacao={i.Nome};cliente_precoTotal={alugar.PrecoTotal};imgDaLuz={alugar.selecionaIlumina};imgDaSom={alugar.selecionaSom}";
        }
    }
}