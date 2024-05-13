using _0._8_.NET.Models;

Pessoa p1 = new Pessoa("renato", "Ramon");
p1.Idade = 25;
p1.Apresentar();



Pessoa p2 = new Pessoa();
p2.Nome = "Angeliquinha";
p2.Sobrenome = "13";

Curso cursoDeIngles = new Curso();
cursoDeIngles.nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

