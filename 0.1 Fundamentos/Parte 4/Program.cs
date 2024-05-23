using System.Runtime.InteropServices;
using Parte_4.Models;


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + QntdLinhas);
    foreach(string linha in linhasArquivos){
        Console.Write(linha);
    }
}else{
    Console.WriteLine("Não foi possível ler o arquivo");
}




/*   Criando tupla e testando 
(int, string, string, decimal) tupla = (1, "Renato", "Ramon", 1.65M);  //ex1  -> consegue nomear os items
ValueTuple<int, string, string, decimal> outroExemploTupla =  (1, "Renato", "Ramon", 1.65M);  //ex2
var outroExemploTuplaCreate =  Tuple.Create((1, "Renato", "Ramon", 1.65M));   //ex3 

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");


*/