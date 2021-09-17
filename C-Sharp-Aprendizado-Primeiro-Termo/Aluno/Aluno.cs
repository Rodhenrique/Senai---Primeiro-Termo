using System;

namespace Aluno
{
   public class Aluno{
        //propriedade
       public string nome{get;set;}
       public string curso{get;set;}
       public string cpf{get;set;}
       public int[] notas{get;set;}

    //construtor

    public Aluno(string nome, string cpf){
        this.nome = nome;
        this.cpf = cpf;
        notas = new int [4];
    }
    public Aluno(string nome, string cpf, string curso){
        this.nome = nome;
        this.cpf = cpf;
        this.curso = curso;
    }
    public int[] getnotas(){return notas;}

    public void setnotas(int bi, int nota){
        int i = bi -1;
        int Value = 0;
        if((i < 0) || (i > 3)){
            //condição de erro

            throw new ArgumentOutOfRangeException($"{nameof(Value)} must be between 1 and 4");
        }else if(nota < 0 || nota > 10){
            //condição de erro
            throw new ArgumentOutOfRangeException($"{nameof(Value)} must be between 1 and 4");
        }
    }

    }

}