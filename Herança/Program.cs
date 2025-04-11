using System;
using System.Collections.Generic;

namespace POO
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
        }
    }
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor(string nome, int idade, string disciplina)
        {
            Nome = nome;
            Idade = idade;
            Disciplina = disciplina;
        }

        public void Ensinar()
        {
            Console.WriteLine($"Você ensinou: {Disciplina}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Professor professor = new Professor("Carlos", 32, "Matemática");
            professor.Apresentar();
            professor.Ensinar();

        }
    }
}
