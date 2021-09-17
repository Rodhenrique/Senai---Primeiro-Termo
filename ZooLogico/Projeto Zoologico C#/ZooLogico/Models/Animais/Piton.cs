using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Piton : Animal,ITerrestre,IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}