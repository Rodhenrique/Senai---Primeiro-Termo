using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Chimpanze : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
    }
}