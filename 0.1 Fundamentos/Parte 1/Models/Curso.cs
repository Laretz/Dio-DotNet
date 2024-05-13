using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0._8_.NET.Models
{
    public class Curso
    {
        public string nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos(){
            int quantidade  =  Alunos.Count();
                return quantidade;
        }

        public bool RemoverAlunos(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N¹ " + count + " -" + Alunos[count].NomeCompleto;
                string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
        }
    }
}