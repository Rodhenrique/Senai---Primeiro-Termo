using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
   public class Tucano : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}