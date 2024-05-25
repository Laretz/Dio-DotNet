using Parte_6.Models;
using Parte_6.Models.Interfaces;


Corrente c = new Corrente();
c.Creditar(50);

c.ExibirSaldo();

Pessoa p1 = new Aluno("Angeliquinha"); 
p1.Apresentar();

Pessoa p2 = new Pessoa("Angeliquinha13");
p2.Apresentar();

Pessoa p3 = new Diretor("Adalberto");
p3.Apresentar();

Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////");
/////////////////////////////////// Pra baixo muda estamos testando Interfaces

ICalculadora calc = new Calucladora();
Console.WriteLine(calc.Multiplicar(2, 10));
Console.WriteLine(calc.Dividir(10, 2));