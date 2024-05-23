using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_3.Models
{
    public class ExemploExcecao
    {
        public void Metodo1(){
             try{
            Metodo2();
            }catch (Exception ){
                Console.WriteLine("Exceção tratada no metodo 2");
            }
        }
        public void Metodo2(){
            Metodo3();
        }
        public void Metodo3(){
         

            
            Metodo4();
            
        }
        public void Metodo4(){
            throw new Exception ("Ocorreu uma exceção DXDX");
        }
    }
}