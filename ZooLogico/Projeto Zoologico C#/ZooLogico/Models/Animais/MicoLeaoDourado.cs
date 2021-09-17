using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class MicoLeaoDourado : Animal,IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
    }
}