using System;
using System.Collections.Generic;

namespace Estudando
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Livro A");
            pilha.Push("Livro B");
            pilha.Push("Livro C");

            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Peek());

            Console.WriteLine(" ");
            foreach (string pil in pilha)
            {
                Console.WriteLine(pil);
            }
            

            Queue<string> filaClientes = new Queue<string> ();

            filaClientes.Enqueue("Carlos");
            filaClientes.Enqueue("Fernando");
            filaClientes.Enqueue("Bosta");

            while (filaClientes.Count > 0)
            {
                Console.WriteLine($"Atendendo {filaClientes.Dequeue()}");
            }

            // HASHSET SERVE PARA MUITA COISA, ORDENAR, VERIFICAR SE TEM NA LISTA, OPERAÇÃO MATEMÁTICA E ETC.
            List<int> ints = new List<int> {3, 2, 5, 4, 1};
            HashSet<int> Ordernar = new HashSet<int>(ints);



        }
    }
}
