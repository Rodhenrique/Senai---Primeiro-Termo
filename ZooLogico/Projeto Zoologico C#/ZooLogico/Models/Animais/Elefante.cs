using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Elefante : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}