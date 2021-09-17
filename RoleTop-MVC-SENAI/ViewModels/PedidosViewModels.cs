using System.Collections.Generic;
using RoletopMvc.Models;

namespace RoletopMvc.ViewModels
{
    public class PedidosViewModels : BaseViewModel
    {
        public List<Som> soms { get; set; }
        public List<Iluminacao> iluminacaos { get; set; }
        public List<Salao> salaos { get; set; }
        public List<string> Opcaos { get; set; }
        public List<string> Opcaos1 { get; set; }
        public List<string> Eventos { get; set; }

        public Cliente cliente { get; set; }
        public string NomeCliente { get; set; }

        public string Pedido { get; set; }


        public PedidosViewModels()
        {
            this.soms = new List<Som>();
            this.iluminacaos = new List<Iluminacao>();
            this.salaos = new List<Salao>();
            this.cliente = new Cliente();
            this.NomeCliente = "Jovem";
            this.Pedido = Pedido;
        }

    }
}