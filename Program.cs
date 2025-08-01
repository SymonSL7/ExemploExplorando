
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Symon", sobrenome: "Silva Lima", idade: 27);

p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Pietro", sobrenome: "De Miranda Lima");

Curso cursoDeIngles = new Curso(nome: "Curso de Inglês - Básico");

cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();
Console.WriteLine($"Quantidade: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");

cursoDeIngles.RemoverAluno(p2);

cursoDeIngles.ListarAlunos();
Console.WriteLine($"Quantidade: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");








