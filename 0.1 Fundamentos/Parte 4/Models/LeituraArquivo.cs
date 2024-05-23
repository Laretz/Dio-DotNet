using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parte_4.Models
{
    public class LeituraArquivo
    {
       
        public (bool Sucesso, string [] Linhas , int QntdLinhas) LerArquivo(string caminho){
             try {
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count());
        }
        catch(Exception e){
            return (false, new string[0], 0);
        }
    }
    }
}