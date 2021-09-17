using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Ra : Animal,IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " consegue nadar!";
        }
    }
}