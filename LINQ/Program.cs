using System;
using System.Collections.Generic;
using System.Linq; 

namespace Estudando
{
    class Program
    {
        class Filme
        {
            public string Nome { get; set; }
            public string Genero { get; set; }
            public int Duracao { get; set; }
        }

        static void Main(string[] args)
        {
            var filmes = new List<Filme>
            {
                new Filme { Nome = "Velozes e Furiosos", Genero = "Ação", Duracao = 130 },
                new Filme { Nome = "Invocação do Mal", Genero = "Terror", Duracao = 110 },
                new Filme { Nome = "Titanic", Genero = "Romance", Duracao = 195 },
                new Filme { Nome = "Pantera Negra", Genero = "Ação", Duracao = 120 },
                new Filme { Nome = "Annabelle", Genero = "Terror", Duracao = 75 },
            };

            /// FILTRAR FILMES DE TERROR

            Console.WriteLine("Filmes de terror: ");

            var terror = filmes
                .Where(f => f.Genero == "Terror")
                .Select(f => f.Nome);

            foreach (var nome in terror)
            {
                Console.WriteLine(nome);
            }

            /// FILTRAR FILMES COM A DURAÇÃO MENOR QUE 100
            Console.WriteLine("\nFilmes com a duração menor que 100: ");

            var filmes100 = filmes
                .Where(f => f.Duracao < 100)
                .Select(f => f.Nome);

            foreach(var nome in filmes100)
            {
                Console.WriteLine(nome);
            }

            /// MÉDIA DE DURAÇÃO DOS FILMES

            var duracao = filmes.Average(f => f.Duracao);
            Console.WriteLine("\nDuração média dos filmes: ");
            Console.WriteLine(duracao);
        }
    }
}
