using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
   public class Tartaruga : Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " consegue nadar!";
        }
    }
}