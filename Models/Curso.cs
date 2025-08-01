using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {

        public Curso(string nome)
        {

            Nome = nome;

        }

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {

            Alunos.Add(aluno);

        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {

            return Alunos.Count;

        }

        public bool RemoverAluno(Pessoa aluno)
        {

            return Alunos.Remove(aluno);

        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos Matriculados no {Nome}");
            foreach (Pessoa aluno in Alunos)
            {

                Console.WriteLine(aluno.NomeCompleto);

            }

        }

    }
}