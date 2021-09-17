using System.Collections.Generic;
using RoletopMvc.Models;

namespace RoletopMvc.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Alugar> Pedidos { get; set; }
        public List<Mensagem> Mensagem{get;set;}

        public uint PedidosAprovados { get; set; }
        public uint PedidosReprovados { get; set; }

        public uint PedidosPendentes { get; set; }

        public DashboardViewModel()
        {
            this.Pedidos = new List<Alugar>();
            this.Mensagem = new List<Mensagem>();
        }
    }
}