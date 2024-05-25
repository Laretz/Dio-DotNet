using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_6.Models
{
    public class Diretor : Professor
    {
          public Diretor (string nome) : base(nome){
        }
         public override void Apresentar(){
            Console.WriteLine("Oi, sou DIRETOR e meu nome é : " + Nome);
        }
    }
}