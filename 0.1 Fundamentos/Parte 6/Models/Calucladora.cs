using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parte_6.Models.Interfaces;

namespace Parte_6.Models
{
    public class Calucladora : ICalculadora
    {
        public int Somar(int num1, int num2){
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2){
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2){
            return num1*num2;
        }
      

    }
}