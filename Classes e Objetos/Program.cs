using System;
using System.Collections.Generic;

namespace POO
{
    public class Program
    {
        class Personagem
        {
            public string Nome;
            public int Nivel;
            public int Forca;

            public Personagem(string nome, int nivel, int forca)
            {
                Nome = nome;
                Nivel = nivel;
                Forca = forca;
                Console.WriteLine($"Nome do Personagem: {Nome} | Nivel: {Nivel} | Força {Forca}");
            }

            public void Atacar()
            {
                Console.WriteLine($"O personagem {Nome} atacou e deu {Nivel * Forca} de dano");
            }
        }

        public static void Main(string[] args)
        {
            Personagem person = new Personagem("Thomas", 10, 2);
            person.Atacar();
        }
    }
}
