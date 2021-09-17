using System.Collections.Generic;
using RoletopMvc.Models;

namespace RoletopMvc.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public List<Alugar> alugars { get; set; }
        public string URLFoto { get; set; }
        public Cliente cliente { get; set; }
        public Mensagem Mensagem{ get; set; }

        public HistoricoViewModel()
        {
            this.cliente = new Cliente();
            this.Mensagem = new Mensagem();
        }
    }
}