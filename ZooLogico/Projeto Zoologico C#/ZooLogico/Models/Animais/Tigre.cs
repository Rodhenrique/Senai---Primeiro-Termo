using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Tigre : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}