using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Condor : Animal,IVoador
    {
         public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}