using RoletopMvc.Models;
namespace RoletopMvc.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}
        public Cliente cliente{get;set;}

        public RespostaViewModel()
        {

        }
        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
            this.cliente = new Cliente();
        }
    }
}