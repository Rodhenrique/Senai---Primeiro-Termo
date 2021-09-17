namespace RoletopMvc.Models
{
    public class Som : Servico
    {
        public Som(string nome,double preco)
        {
            this.Preco = preco;
            this.Nome = nome;
        }
        public Som()
        {

        }
    }
}