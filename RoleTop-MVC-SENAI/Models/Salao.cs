namespace RoletopMvc.Models
{
    public class Salao : Servico
    {
         public Salao()
        {

        }
        public Salao(double preco, string nome)
        {
            this.Preco = preco;
            this.Nome = nome;
        }
      
    }
}