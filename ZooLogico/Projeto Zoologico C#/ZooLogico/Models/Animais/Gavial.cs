using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Gavial : Animal,IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " sabe nadar!";
        }
    }
}