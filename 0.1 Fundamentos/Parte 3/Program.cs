using System.Linq.Expressions;
using  Parte_3.Models;
new ExemploExcecao().Metodo1();


/*  Trabalhando com  Dictionaty */
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

 Console.WriteLine("------------------");

foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave)){
    Console.WriteLine($"Valor existente: {chave}");
}else {
     Console.WriteLine($"Valor não existente, é seguro adicionar a chave: {chave}");
}

/*  Trabalhando com  Pilhas */
Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
pilha.Push(7);

foreach(int item in pilha){
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo :{pilha.Pop()}");

pilha.Push(10);

foreach(int item in pilha){
    Console.WriteLine(item);
}

/*  Trabalhando com  Filas */

Queue <int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila){
    Console.WriteLine(item);
}

/*     teste exceptions
try
{
    
string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas){
    Console.WriteLine(linha);
}
}catch (FileNotFoundException e){
    Console.WriteLine($"Ocorreu um errinho: {e.Message}");

}catch (Exception e){
    Console.WriteLine($"Ocorreu um errinho: {e.Message}");
}finally {
    Console.WriteLine("Chegamos aqui!!");
} */






