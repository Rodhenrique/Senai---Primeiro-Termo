using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Pinguim : Animal, IQuionofilo
    {
        public string ResistirAoFrio()
        {
            return this.GetType().Name + " consegue aguentar um frio brabo!";
        }
    }
}