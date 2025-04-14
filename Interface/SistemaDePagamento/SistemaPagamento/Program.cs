using Estudando.Interface;
using Estudando.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDePagamento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== Sistema De Pagamento =====");
            Console.WriteLine("Escolha o método de pagamento: ");
            Console.Write("1 - Cartão\n2 - Dinheiro\n3 - Pix");

            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a pagar: R$ ");
            double valor = double.Parse(Console.ReadLine());

            IPayament pagamento;

            switch (opcao)
            {
                case 1:
                    pagamento = new PagamentoCartao();
                    break;

                case 2:
                    pagamento = new PagamentoDinheiro();
                    break;

                case 3:
                    pagamento = new Pix();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }
            pagamento.Pagar(valor);
        }
    }
}
