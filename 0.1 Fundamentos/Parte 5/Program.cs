using Parte_4.Models;
using Newtonsoft.Json;

// Codigo para deserializar Vendas!!

string counteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(counteudoArquivo);

foreach(Vendas vendas in listaVendas){
    Console.WriteLine($"Id: {vendas.Id}, Produto: {vendas.Produto}, Preco: {vendas.Preco}, Data: {vendas.DataVenda.ToString("dd/MM/yyyy HH:mm")}  ");
}

/* Codigo para serializar Venda! 
DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "material de escritorio", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 500.00M, dataAtual);
Venda v3 = new Venda(3, "cadeira de escritorio", 100.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);
*/