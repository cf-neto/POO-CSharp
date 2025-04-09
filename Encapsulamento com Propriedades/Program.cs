using System;
using System.Collections.Generic;

namespace POO
{

    class Produto
    {
        // Atributos privados
        private string nome;
        private double preco;
        private int quantidade;

        // Transformando atributos privados em atributos públicos
        public string Nome { get; set; }
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    Console.WriteLine("Preço inválido!");
                }
            }
        }
        public int Quantidade
        {
            get { return quantidade; }
            private set
            {
                if (value >= 0)
                {
                    quantidade = value;
                }
                else
                {
                    Console.WriteLine("Quantidade inválida!");
                }
            }
        }

        // Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void adicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade += quantidade;
                Console.WriteLine($"{quantidade} unidade adicionadas!");
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
        public void removerEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade -= quantidade;
                Console.WriteLine($"{quantidade} unidade removidas!");
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
        public void exibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} | Preço: {Preco:F2} | Quantidade: {Quantidade}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Produto produto = new Produto("Teclado mecânico", 299.90, 5);
            produto.exibirInfo();
            produto.adicionarEstoque(10);
            produto.removerEstoque(2);
            produto.exibirInfo();

        }
    }
}
