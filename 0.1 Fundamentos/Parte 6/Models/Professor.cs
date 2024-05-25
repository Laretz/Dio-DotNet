using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Parte_6.Models
{
    public  class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public Professor (string nome) : base(nome){
        }

        public  override void Apresentar(){
            Console.WriteLine("Oi, sou professor e meu nome é : " + Nome);
        }
    }
}