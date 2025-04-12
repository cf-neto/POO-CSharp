using System;
using System.Collections.Generic;

namespace POO
{

    class Veterinario
    {
        public string Nome_Veterinario { get; set; }

        public Veterinario(string nome)
        {
            Nome_Veterinario = nome;
        }

        public void Vacinar(Animal animal)
        {
            if (!animal.EstaVacinado)
            {
                animal.EstaVacinado = true;
                Console.WriteLine($"O {animal.GetType().Name.ToLower()} {animal.Nome} foi vacinado com sucesso!");
            }
            else
            {
                Console.WriteLine($"O {animal.GetType().Name.ToLower()} {animal.Nome} já está vacinado.");
            }
        }

    }

    class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nome_Dono { get; set; }
        public bool EstaVacinado { get; set; } = false;


        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal...");
        }
    }

    class Cachorro : Animal
    {
        // Construtor
        public Cachorro(string nome, int idade, string dono)
        {
            Nome = nome;
            Idade = idade;
            Nome_Dono = dono;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au!");
        }
    }

    class Gato : Animal
    {
        public Gato(string nome, int idade, string dono)
        {
            Nome = nome;
            Idade = idade;
            Nome_Dono = dono;
            EstaVacinado = true;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
    }

    class Papagaio : Animal
    {
        public Papagaio(string nome, int idade, string dono)
        {
            Nome = nome;
            Idade = idade;
            Nome_Dono = dono;
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Olá! papagaio aqui!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Cachorro rex = new Cachorro("Rex", 5, "Carlos");
            Gato lima = new Gato("Lima", 7, "Isabelle");
            Papagaio lucky = new Papagaio("Lucky", 3, "Fernando");

            Veterinario Marcos = new Veterinario("Dr. Marcos");

            Marcos.Vacinar(rex);
            Marcos.Vacinar(lima);
            Marcos.Vacinar(lucky);
        }
    }
}
