using ZooLogico.Models;

namespace ZooLogico.Models.Habitats
{
    public abstract class Controle
    {
        private Animal[] animais;
        private int _capacidadeAtual;

        public int capacidadeAtual
        {
            get { return _capacidadeAtual; }
        }
        public Controle()
        {
            this.animais = new Animal[3];
            this._capacidadeAtual = 3;
        }

        public virtual bool alocar(Animal animal)
        {
            if (_capacidadeAtual > 0)
            {
                int contador = 0;
                foreach (Animal animal1 in animais)
                {
                    if (animal1 == null)
                    {
                        this.animais[contador] = animal;
                        this._capacidadeAtual--;
                        break;
                    }
                    contador++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
