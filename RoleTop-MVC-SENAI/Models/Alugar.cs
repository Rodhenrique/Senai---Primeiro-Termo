using System;
using RoletopMvc.Enums;

namespace RoletopMvc.Models {
    public class Alugar {
        public Cliente cliente { get; set; }
        public Som som { get; set; }
        public Iluminacao iluminacao { get; set; }
        public DateTime DataDoPedido { get; set; }
        public double PrecoTotal { get; set; }
        public string TipoEvento { get; set; }
        public string Descricao { get; set; }
        public string Pagamento { get; set; }

        public string organizado { get; set; }
        public ulong Id { get; set; }
        public uint Status { get; set; }
        public string selecionaSom { get; set; }
        public string selecionaIlumina { get; set; }
        public string email { get; set; }
        public string StatusNome { get; set; }

        public Mensagem mensagem{ get; set; }

        public Alugar () {
            this.cliente = new Cliente ();
            this.som = new Som ();
            this.iluminacao = new Iluminacao ();
            this.TipoEvento = TipoEvento;
            this.Descricao = Descricao;
            this.Pagamento = Pagamento;
            this.organizado = organizado;
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
            this.selecionaSom = selecionaIlumina;
            this.selecionaSom = selecionaSom;
            this.email = email;
            this.StatusNome = StatusNome;
            this.mensagem = new Mensagem();
        }
    }
}