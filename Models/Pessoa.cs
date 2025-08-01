using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobrenome)
        {

            Nome = nome;
            Sobrenome = sobrenome;

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;

        } 

        private string _nome;
        private int _idade;
        public string Nome
        {

            get => _nome.ToUpper();

            set
            {

                if (value == "")
                {

                    throw new ArgumentException("O nome não pode ser vazio");

                }

                _nome = value;

            }

        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {

            get => _idade;

            set
            {

                if (value < 0)
                {

                    throw new ArgumentException("Idade não pode ser negativa");

                }

                _idade = value;

            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}