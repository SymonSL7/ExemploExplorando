
using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa p1 = new Pessoa(nome: "Symon", sobrenome: "Silva Lima", idade: 27);

p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Pietro", sobrenome: "De Miranda Lima");

Curso cursoDeIngles = new Curso(nome: "Curso de Inglês - Básico");

cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();
Console.WriteLine($"Quantidade: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");

cursoDeIngles.RemoverAluno(p1);

cursoDeIngles.ListarAlunos();
Console.WriteLine($"Quantidade: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");


decimal valorMonetario = 1583259.90M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-PT")));
Console.WriteLine(valorMonetario.ToString("N2"));

double porcetagem = .3421;

Console.WriteLine(porcetagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
Console.WriteLine(data.ToString(CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime data2 = DateTime.Parse("03-08-2025 16:00");

Console.WriteLine(data2);

string dataString = "31/09/2025 18:00";
bool sucesso = DateTime.TryParseExact(dataString,
                       "dd/MM/yyyy HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None, out DateTime data3);

if (sucesso)
{
    Console.WriteLine($"Conversão realizada com sucesso: {data3}");
}
else
{
    Console.WriteLine($"{dataString} é uma data inváilida, não foi possivel realizar a conversão!");
}