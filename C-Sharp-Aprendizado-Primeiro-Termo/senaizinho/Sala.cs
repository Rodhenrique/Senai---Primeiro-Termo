namespace senaizinho
{
    public class Sala
    {
        public int CapacidadeAtual;
        public int CapacidadeTotal;
        public int NumeroSala;
        public string[] Alunos;
        public Sala(int NumeroSala, int CapacidadeTotal)
        {
            this.NumeroSala = NumeroSala;
            this.CapacidadeTotal = CapacidadeTotal;
            this.CapacidadeAtual = this.CapacidadeTotal;
            this.Alunos = new string[CapacidadeTotal];
        }
        public string AlocarAluno(string NomeAluno)
        {
            int index = 0;
                if(aluno == "")
                {
                foreach (string aluno in this.Alunos)
                {
                    this.Alunos[index] = NomeAluno;
                    break;
                }

                index ++;
                this.CapacidadeAtual --;
                return "Ok";

                }else{
                    return "puxa nã foi dessa vez tente novamente!!";
                }
        }
        public string RemoverAluno(string NomeAluno)
        {
            int index = 0;


            foreach (string aluno in this.Alunos)
            {
                if(NomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "Ok";
                }
                index ++;
            }
            return "procurei mais não achei,ser eu foi ai e achar vou tem bater,procura denovo";
        }
        public string MostrarAlunos()
        {
            string listaAlunos = "";
            foreach (string aluno in this.Alunos)
            {
                if(aluno !=""){
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }


    }
}