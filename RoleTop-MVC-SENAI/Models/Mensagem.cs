using System;

namespace RoletopMvc.Models {
    public class Mensagem {
        public string MensagemDoCliente { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public string Objetivo { get; set; }
        public Cliente cliente { get; set; }
        public uint Id{ get; set; }
        
        public Mensagem () {
            this.Email = Email;
            this.MensagemDoCliente = MensagemDoCliente;
            this.Data = Data;
            this.Objetivo = Objetivo;
            this.Id = Id;
            this.cliente = new Cliente ();

        }
    }
}