using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Morcego : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}