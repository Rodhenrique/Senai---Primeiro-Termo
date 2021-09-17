using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Crocodilo : Animal,IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " sabe nadar!";
        }
    }
}