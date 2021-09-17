namespace RoletopMvc.Models
{
    public class Iluminacao : Servico
    {
        public Iluminacao()
        {

        }
        public Iluminacao(string nome,double preco)
        {
            this.Preco = preco;
            this.Nome = nome;
        }
    }
}