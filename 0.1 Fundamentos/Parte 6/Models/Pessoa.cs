using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_6.Models
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome) {
            Nome = nome;
        }

        public virtual void Apresentar(){
            Console.WriteLine("Oi, meu nome é : " + Nome);
        }
    }
}