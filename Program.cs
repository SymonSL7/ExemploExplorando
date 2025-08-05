
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


try
{

    string[] linhas = File.ReadAllLines("Arquivos/t1/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {

        Console.WriteLine(linha);

    }

}
catch (FileNotFoundException ex)
{

    Console.WriteLine($"Arquivo não encontrado! {ex.Message}");

}
catch (DirectoryNotFoundException ex)
{

    Console.WriteLine($"Caminho da pasta não encontrado! {ex.Message}");

}
catch (Exception ex)
{

    Console.WriteLine($"Exceção generica! {ex.Message}");

}
finally
{

    Console.WriteLine("Chegou até aqui!");

}


new ExemploExcecao().Metodo1();

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{

    Console.WriteLine(item);

}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

Console.WriteLine("Nova Fila");
foreach (int item in fila)
{

    Console.WriteLine(item);

}

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

Console.WriteLine("---------------------PILHA---------------------");
foreach (int item in pilha)
{

    Console.WriteLine(item);

}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(30);

Console.WriteLine("---------------------PILHA NOVA---------------------");
foreach (int item in pilha)
{

    Console.WriteLine(item);

}

Console.WriteLine("---------------------DICTIONARY---------------------");

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("31", "MG");
estados.Add("21", "RJ");
estados.Add("11", "SP");
estados.Add("51", "RS");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("21");
estados.Add("47", "SC");
Console.WriteLine("---------------------DICTIONARY NOVO---------------------");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("---------------------DICTIONARY NOVO---------------------");
estados["47"] = "SC - Valor Alterado";
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

try
{
    estados.Add("31", "MG Novo");
}
catch (ArgumentException e)
{
    Console.WriteLine("Chave já existe! " + e.Message);
}

string chave = "21";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{

    Console.WriteLine($"Valor existente: {chave}");

}
else
{

    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");

}


Console.WriteLine(estados["31"]);