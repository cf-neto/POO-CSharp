using System;
using System.Collections.Generic;
using System.Linq; 

namespace Estudando
{
    class Program
    {

        class clienteIdade
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        static void Main(string[] args)
        {
            List<clienteIdade> clienteIdades = new List<clienteIdade>
            {
                new clienteIdade {Nome = "Carlos", Idade = 18},
                new clienteIdade {Nome = "Fernando", Idade = 25},
                new clienteIdade {Nome = "Isadora", Idade = 12} 
            };

            Console.WriteLine("\n");

            var verificar = from cliente in clienteIdades
                            where cliente.Idade >= 18
                            select cliente;

            foreach (var cliente in verificar)
            {
                Console.WriteLine($"Nome: {cliente.Nome} | Idade: {cliente.Idade}");
            }
        }
    }
}
